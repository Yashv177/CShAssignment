using System;
using System.Data;
using System.Data.SqlClient;
using LibraryManagerLib.Models;

namespace LibraryManagerLib
{
    public class LibraryManager
    {
        private readonly string _conn;

        public LibraryManager(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentException("connectionString required");
            _conn = connectionString;
        }

        // ---------- BOOKS ----------
        public int AddBook(Book b)
        {
            const string sql = @"
                INSERT INTO Books (Title, Author, Category, TotalCopies, AvailableCopies)
                VALUES (@Title,@Author,@Category,@TotalCopies,@AvailableCopies);
                SELECT CAST(SCOPE_IDENTITY() AS INT);";
            using var conn = new SqlConnection(_conn);
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Title", b.Title);
            cmd.Parameters.AddWithValue("@Author", b.Author);
            cmd.Parameters.AddWithValue("@Category", (object?)b.Category ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@TotalCopies", b.TotalCopies);
            cmd.Parameters.AddWithValue("@AvailableCopies", b.AvailableCopies);
            conn.Open();
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        public bool UpdateBook(Book b)
        {
            const string sql = @"
                UPDATE Books SET Title=@Title, Author=@Author, Category=@Category,
                TotalCopies=@TotalCopies, AvailableCopies=@AvailableCopies
                WHERE BookID=@Id";
            using var conn = new SqlConnection(_conn);
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Title", b.Title);
            cmd.Parameters.AddWithValue("@Author", b.Author);
            cmd.Parameters.AddWithValue("@Category", (object?)b.Category ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@TotalCopies", b.TotalCopies);
            cmd.Parameters.AddWithValue("@AvailableCopies", b.AvailableCopies);
            cmd.Parameters.AddWithValue("@Id", b.BookID);
            conn.Open();
            return cmd.ExecuteNonQuery() > 0;
        }

        public bool DeleteBook(int bookId)
        {
            const string sql = "DELETE FROM Books WHERE BookID=@Id";
            using var conn = new SqlConnection(_conn);
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Id", bookId);
            conn.Open();
            return cmd.ExecuteNonQuery() > 0;
        }

        public DataTable GetAllBooks()
        {
            var dt = new DataTable();
            using var conn = new SqlConnection(_conn);
            using var da = new SqlDataAdapter("SELECT * FROM Books ORDER BY BookID DESC", conn);
            da.Fill(dt);
            return dt;
        }

        public DataTable SearchBooks(string q)
        {
            var dt = new DataTable();
            using var conn = new SqlConnection(_conn);
            using var cmd = new SqlCommand("SELECT * FROM Books WHERE Title LIKE @q OR Author LIKE @q OR Category LIKE @q", conn);
            cmd.Parameters.AddWithValue("@q", "%" + q + "%");
            using var da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        // ---------- MEMBERS ----------
        public int AddMember(Member m)
        {
            const string sql = @"
                INSERT INTO Members (Name, Email, Mobile) VALUES (@Name,@Email,@Mobile);
                SELECT CAST(SCOPE_IDENTITY() AS INT);";
            using var conn = new SqlConnection(_conn);
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Name", m.Name);
            cmd.Parameters.AddWithValue("@Email", (object?)m.Email ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Mobile", (object?)m.Mobile ?? DBNull.Value);
            conn.Open();
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        public DataTable GetAllMembers()
        {
            var dt = new DataTable();
            using var conn = new SqlConnection(_conn);
            using var da = new SqlDataAdapter("SELECT * FROM Members ORDER BY MemberID DESC", conn);
            da.Fill(dt);
            return dt;
        }

        // ---------- ISSUE / RETURN ----------
        public bool IssueBook(int bookId, int memberId)
        {
            // Check availability and then issue
            using var conn = new SqlConnection(_conn);
            conn.Open();
            using var tran = conn.BeginTransaction();
            try
            {
                // check available
                using (var cmdCheck = new SqlCommand("SELECT AvailableCopies FROM Books WHERE BookID=@id", conn, tran))
                {
                    cmdCheck.Parameters.AddWithValue("@id", bookId);
                    var avail = cmdCheck.ExecuteScalar();
                    if (avail == null || Convert.ToInt32(avail) <= 0)
                        return false;
                }

                // insert into IssueReturn
                using (var cmdIns = new SqlCommand("INSERT INTO IssueReturn (BookID, MemberID, IssueDate, Status) VALUES (@b,@m,GETDATE(),'Issued')", conn, tran))
                {
                    cmdIns.Parameters.AddWithValue("@b", bookId);
                    cmdIns.Parameters.AddWithValue("@m", memberId);
                    cmdIns.ExecuteNonQuery();
                }

                // decrement available
                using (var cmdUpd = new SqlCommand("UPDATE Books SET AvailableCopies = AvailableCopies - 1 WHERE BookID=@id", conn, tran))
                {
                    cmdUpd.Parameters.AddWithValue("@id", bookId);
                    cmdUpd.ExecuteNonQuery();
                }

                tran.Commit();
                return true;
            }
            catch
            {
                tran.Rollback();
                throw;
            }
        }

        public bool ReturnBook(int transactionId)
        {
            using var conn = new SqlConnection(_conn);
            conn.Open();
            using var tran = conn.BeginTransaction();
            try
            {
                // get book id
                int bookId;
                using (var cmd = new SqlCommand("SELECT BookID FROM IssueReturn WHERE TransactionID=@t AND Status='Issued'", conn, tran))
                {
                    cmd.Parameters.AddWithValue("@t", transactionId);
                    var r = cmd.ExecuteScalar();
                    if (r == null) return false;
                    bookId = Convert.ToInt32(r);
                }

                // update IssueReturn row
                using (var cmd = new SqlCommand("UPDATE IssueReturn SET ReturnDate=GETDATE(), Status='Returned' WHERE TransactionID=@t", conn, tran))
                {
                    cmd.Parameters.AddWithValue("@t", transactionId);
                    cmd.ExecuteNonQuery();
                }

                // increment available copies
                using (var cmd = new SqlCommand("UPDATE Books SET AvailableCopies = AvailableCopies + 1 WHERE BookID=@id", conn, tran))
                {
                    cmd.Parameters.AddWithValue("@id", bookId);
                    cmd.ExecuteNonQuery();
                }

                tran.Commit();
                return true;
            }
            catch
            {
                tran.Rollback();
                throw;
            }
        }

        public DataTable GetIssuedBooks()
        {
            var dt = new DataTable();
            const string sql = @"
                SELECT ir.TransactionID, b.Title, m.Name AS MemberName, ir.IssueDate, ir.ReturnDate, ir.Status
                FROM IssueReturn ir
                INNER JOIN Books b ON ir.BookID = b.BookID
                INNER JOIN Members m ON ir.MemberID = m.MemberID
                ORDER BY ir.TransactionID DESC";
            using var conn = new SqlConnection(_conn);
            using var da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            return dt;
        }

        // Overdue example: issued and not returned for more than given days
        public DataTable GetOverdue(int daysThreshold)
        {
            var dt = new DataTable();
            string sql = @"
                SELECT ir.TransactionID, b.Title, m.Name AS MemberName, ir.IssueDate, DATEDIFF(day, ir.IssueDate, GETDATE()) AS DaysPassed
                FROM IssueReturn ir
                INNER JOIN Books b ON ir.BookID = b.BookID
                INNER JOIN Members m ON ir.MemberID = m.MemberID
                WHERE ir.Status='Issued' AND DATEDIFF(day, ir.IssueDate, GETDATE()) > @d";
            using var conn = new SqlConnection(_conn);
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@d", daysThreshold);
            using var da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
    }
}
