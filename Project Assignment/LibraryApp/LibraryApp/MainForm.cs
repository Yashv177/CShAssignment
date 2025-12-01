using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using LibraryManagerLib;
using LibraryManagerLib.Models;

namespace LibraryApp
{
    public partial class MainForm : Form
    {
        private LibraryManager mgr;

        public MainForm()
        {
            InitializeComponent();

            var cs = ConfigurationManager.ConnectionStrings["LibraryDB"]?.ConnectionString;
            if (string.IsNullOrWhiteSpace(cs))
            {
                MessageBox.Show("Missing connection string 'LibraryDB' in config.");
                return; // or throw a clearer exception
            }
            mgr = new LibraryManager(cs);

            LoadBooks();
            LoadMembers();
            LoadIssued();
        }

        private void LoadBooks()
        {
            dgvBooks.DataSource = mgr.GetAllBooks();
        }

        private void LoadMembers()
        {
            dgvMembers.DataSource = mgr.GetAllMembers();
        }

        private void LoadIssued()
        {
            dgvIssued.DataSource = mgr.GetIssuedBooks();
        }

        // Book CRUD
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            var b = new Book
            {
                Title = txtBookTitle.Text.Trim(),
                Author = txtBookAuthor.Text.Trim(),
                Category = txtBookCategory.Text.Trim(),
                TotalCopies = int.TryParse(txtTotalCopies.Text.Trim(), out int t) ? t : 0,
                AvailableCopies = int.TryParse(txtAvailableCopies.Text.Trim(), out int a) ? a : 0
            };
            mgr.AddBook(b);
            LoadBooks();
            MessageBox.Show("Book added");
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            if (dgvBooks.SelectedRows.Count == 0) { MessageBox.Show("Select book"); return; }

            int id = Convert.ToInt32(dgvBooks.SelectedRows[0].Cells["BookID"].Value);
            var b = new Book
            {
                BookID = id,
                Title = txtBookTitle.Text.Trim(),
                Author = txtBookAuthor.Text.Trim(),
                Category = txtBookCategory.Text.Trim(),
                TotalCopies = int.TryParse(txtTotalCopies.Text.Trim(), out int t) ? t : 0,
                AvailableCopies = int.TryParse(txtAvailableCopies.Text.Trim(), out int a) ? a : 0
            };
            mgr.UpdateBook(b);
            LoadBooks();
            MessageBox.Show("Updated");
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (dgvBooks.SelectedRows.Count == 0) { MessageBox.Show("Select book"); return; }
            int id = Convert.ToInt32(dgvBooks.SelectedRows[0].Cells["BookID"].Value);
            mgr.DeleteBook(id);
            LoadBooks();
            MessageBox.Show("Deleted");
        }

        private void dgvBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvBooks.Rows[e.RowIndex];
            txtBookTitle.Text = row.Cells["Title"].Value?.ToString();
            txtBookAuthor.Text = row.Cells["Author"].Value?.ToString();
            txtBookCategory.Text = row.Cells["Category"].Value?.ToString();
            txtTotalCopies.Text = row.Cells["TotalCopies"].Value?.ToString();
            txtAvailableCopies.Text = row.Cells["AvailableCopies"].Value?.ToString();
        }

        // Member CRUD
        private void btnAddMember_Click(object sender, EventArgs e)
        {
            var m = new Member
            {
                Name = txtMemberName.Text.Trim(),
                Email = txtMemberEmail.Text.Trim(),
                Mobile = txtMemberMobile.Text.Trim()
            };
            mgr.AddMember(m);
            LoadMembers();
            MessageBox.Show("Member added");
        }

        private void dgvMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvMembers.Rows[e.RowIndex];
            txtMemberName.Text = row.Cells["Name"].Value?.ToString();
            txtMemberEmail.Text = row.Cells["Email"].Value?.ToString();
            txtMemberMobile.Text = row.Cells["Mobile"].Value?.ToString();
        }

        // Issue / Return
        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (dgvBooks.SelectedRows.Count == 0 || dgvMembers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select book and member");
                return;
            }
            int bookId = Convert.ToInt32(dgvBooks.SelectedRows[0].Cells["BookID"].Value);
            int memberId = Convert.ToInt32(dgvMembers.SelectedRows[0].Cells["MemberID"].Value);

            bool ok = mgr.IssueBook(bookId, memberId);
            MessageBox.Show(ok ? "Issued successfully" : "Issue failed (no copies)");
            LoadBooks();
            LoadIssued();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (dgvIssued.SelectedRows.Count == 0) { MessageBox.Show("Select transaction"); return; }
            int transId = Convert.ToInt32(dgvIssued.SelectedRows[0].Cells["TransactionID"].Value);
            bool ok = mgr.ReturnBook(transId);
            MessageBox.Show(ok ? "Returned" : "Return failed");
            LoadBooks();
            LoadIssued();
        }

        // Overdue search
        private void btnCheckOverdue_Click(object sender, EventArgs e)
        {
            int days = int.TryParse(txtOverdueDays.Text.Trim(), out int d) ? d : 7;
            dgvOverdue.DataSource = mgr.GetOverdue(days);
        }
    }
}
