namespace LibraryApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        // BOOK CONTROLS
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.TextBox txtBookAuthor;
        private System.Windows.Forms.TextBox txtBookCategory;
        private System.Windows.Forms.TextBox txtTotalCopies;
        private System.Windows.Forms.TextBox txtAvailableCopies;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnUpdateBook;
        private System.Windows.Forms.Button btnDeleteBook;

        // MEMBER CONTROLS
        private System.Windows.Forms.DataGridView dgvMembers;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.TextBox txtMemberEmail;
        private System.Windows.Forms.TextBox txtMemberMobile;
        private System.Windows.Forms.Button btnAddMember;

        // ISSUE CONTROLS
        private System.Windows.Forms.DataGridView dgvIssued;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Button btnReturn;

        // OVERDUE CONTROLS
        private System.Windows.Forms.DataGridView dgvOverdue;
        private System.Windows.Forms.TextBox txtOverdueDays;
        private System.Windows.Forms.Button btnCheckOverdue;

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabBooks;
        private System.Windows.Forms.TabPage tabMembers;
        private System.Windows.Forms.TabPage tabIssueReturn;
        private System.Windows.Forms.TabPage tabOverdue;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }


        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabBooks = new System.Windows.Forms.TabPage();
            this.tabMembers = new System.Windows.Forms.TabPage();
            this.tabIssueReturn = new System.Windows.Forms.TabPage();
            this.tabOverdue = new System.Windows.Forms.TabPage();

            // BOOKS CONTROLS
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.txtBookAuthor = new System.Windows.Forms.TextBox();
            this.txtBookCategory = new System.Windows.Forms.TextBox();
            this.txtTotalCopies = new System.Windows.Forms.TextBox();
            this.txtAvailableCopies = new System.Windows.Forms.TextBox();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnUpdateBook = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();

            // MEMBER CONTROLS
            this.dgvMembers = new System.Windows.Forms.DataGridView();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.txtMemberEmail = new System.Windows.Forms.TextBox();
            this.txtMemberMobile = new System.Windows.Forms.TextBox();
            this.btnAddMember = new System.Windows.Forms.Button();

            // ISSUE RETURN
            this.dgvIssued = new System.Windows.Forms.DataGridView();
            this.btnIssue = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();

            // OVERDUE
            this.dgvOverdue = new System.Windows.Forms.DataGridView();
            this.txtOverdueDays = new System.Windows.Forms.TextBox();
            this.btnCheckOverdue = new System.Windows.Forms.Button();


            // =========================
            // TAB CONTROL
            // =========================
            this.tabControl1.Controls.Add(this.tabBooks);
            this.tabControl1.Controls.Add(this.tabMembers);
            this.tabControl1.Controls.Add(this.tabIssueReturn);
            this.tabControl1.Controls.Add(this.tabOverdue);
            this.tabControl1.Location = new System.Drawing.Point(10, 10);
            this.tabControl1.Size = new System.Drawing.Size(900, 600);


            // =========================
            // BOOKS TAB
            // =========================
            this.tabBooks.Text = "Books";
            this.tabBooks.Controls.Add(this.dgvBooks);
            this.tabBooks.Controls.Add(this.txtBookTitle);
            this.tabBooks.Controls.Add(this.txtBookAuthor);
            this.tabBooks.Controls.Add(this.txtBookCategory);
            this.tabBooks.Controls.Add(this.txtTotalCopies);
            this.tabBooks.Controls.Add(this.txtAvailableCopies);
            this.tabBooks.Controls.Add(this.btnAddBook);
            this.tabBooks.Controls.Add(this.btnUpdateBook);
            this.tabBooks.Controls.Add(this.btnDeleteBook);

            // BOOK INPUTS
            this.txtBookTitle.Location = new System.Drawing.Point(20, 20);
            this.txtBookTitle.Size = new System.Drawing.Size(200, 25);

            this.txtBookAuthor.Location = new System.Drawing.Point(240, 20);
            this.txtBookAuthor.Size = new System.Drawing.Size(200, 25);

            this.txtBookCategory.Location = new System.Drawing.Point(460, 20);
            this.txtBookCategory.Size = new System.Drawing.Size(200, 25);

            this.txtTotalCopies.Location = new System.Drawing.Point(20, 60);
            this.txtTotalCopies.Size = new System.Drawing.Size(200, 25);

            this.txtAvailableCopies.Location = new System.Drawing.Point(240, 60);
            this.txtAvailableCopies.Size = new System.Drawing.Size(200, 25);

            this.btnAddBook.Location = new System.Drawing.Point(20, 100);
            this.btnAddBook.Size = new System.Drawing.Size(100, 30);
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);

            this.btnUpdateBook.Location = new System.Drawing.Point(130, 100);
            this.btnUpdateBook.Size = new System.Drawing.Size(100, 30);
            this.btnUpdateBook.Text = "Update";
            this.btnUpdateBook.Click += new System.EventHandler(this.btnUpdateBook_Click);

            this.btnDeleteBook.Location = new System.Drawing.Point(240, 100);
            this.btnDeleteBook.Size = new System.Drawing.Size(100, 30);
            this.btnDeleteBook.Text = "Delete";
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);

            this.dgvBooks.Location = new System.Drawing.Point(20, 150);
            this.dgvBooks.Size = new System.Drawing.Size(830, 380);
            this.dgvBooks.ReadOnly = true;
            this.dgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooks_CellClick);


            // =========================
            // MEMBERS TAB
            // =========================
            this.tabMembers.Text = "Members";
            this.tabMembers.Controls.Add(this.dgvMembers);
            this.tabMembers.Controls.Add(this.txtMemberName);
            this.tabMembers.Controls.Add(this.txtMemberEmail);
            this.tabMembers.Controls.Add(this.txtMemberMobile);
            this.tabMembers.Controls.Add(this.btnAddMember);

            this.txtMemberName.Location = new System.Drawing.Point(20, 20);
            this.txtMemberName.Size = new System.Drawing.Size(200, 25);

            this.txtMemberEmail.Location = new System.Drawing.Point(240, 20);
            this.txtMemberEmail.Size = new System.Drawing.Size(200, 25);

            this.txtMemberMobile.Location = new System.Drawing.Point(460, 20);
            this.txtMemberMobile.Size = new System.Drawing.Size(200, 25);

            this.btnAddMember.Location = new System.Drawing.Point(680, 20);
            this.btnAddMember.Size = new System.Drawing.Size(120, 30);
            this.btnAddMember.Text = "Add Member";
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);

            this.dgvMembers.Location = new System.Drawing.Point(20, 70);
            this.dgvMembers.Size = new System.Drawing.Size(830, 460);
            this.dgvMembers.ReadOnly = true;
            this.dgvMembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMembers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMembers_CellClick);


            // =========================
            // ISSUE / RETURN TAB
            // =========================
            this.tabIssueReturn.Text = "Issue / Return";
            this.tabIssueReturn.Controls.Add(this.dgvIssued);
            this.tabIssueReturn.Controls.Add(this.btnIssue);
            this.tabIssueReturn.Controls.Add(this.btnReturn);

            this.btnIssue.Location = new System.Drawing.Point(20, 20);
            this.btnIssue.Size = new System.Drawing.Size(120, 30);
            this.btnIssue.Text = "Issue Book";
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);

            this.btnReturn.Location = new System.Drawing.Point(150, 20);
            this.btnReturn.Size = new System.Drawing.Size(120, 30);
            this.btnReturn.Text = "Return Book";
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);

            this.dgvIssued.Location = new System.Drawing.Point(20, 70);
            this.dgvIssued.Size = new System.Drawing.Size(830, 460);
            this.dgvIssued.ReadOnly = true;
            this.dgvIssued.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;


            // =========================
            // OVERDUE TAB
            // =========================
            this.tabOverdue.Text = "Overdue";
            this.tabOverdue.Controls.Add(this.dgvOverdue);
            this.tabOverdue.Controls.Add(this.txtOverdueDays);
            this.tabOverdue.Controls.Add(this.btnCheckOverdue);

            this.txtOverdueDays.Location = new System.Drawing.Point(20, 20);
            this.txtOverdueDays.Size = new System.Drawing.Size(150, 25);

            this.btnCheckOverdue.Location = new System.Drawing.Point(180, 20);
            this.btnCheckOverdue.Size = new System.Drawing.Size(150, 30);
            this.btnCheckOverdue.Text = "Check Overdue";
            this.btnCheckOverdue.Click += new System.EventHandler(this.btnCheckOverdue_Click);

            this.dgvOverdue.Location = new System.Drawing.Point(20, 70);
            this.dgvOverdue.Size = new System.Drawing.Size(830, 460);
            this.dgvOverdue.ReadOnly = true;
            this.dgvOverdue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;


            // =========================
            // MAIN FORM
            // =========================
            this.ClientSize = new System.Drawing.Size(930, 630);
            this.Controls.Add(this.tabControl1);
            this.Text = "Library Book Management System";

            this.ResumeLayout(false);
        }
    }
}
