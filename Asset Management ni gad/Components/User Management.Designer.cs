namespace Asset_Management_ni_gad.Components
{
    partial class User_Management
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lblRole = new Label();
            lblFullName = new Label();
            txtFullName = new TextBox();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtUsername = new TextBox();
            lblUsername = new Label();
            btnCancel = new Button();
            lblRecordTitle = new Label();
            dataPanel = new Panel();
            dgvUsers = new DataGridView();
            btnCloseForm = new Button();
            formPanel = new Panel();
            comboBox1 = new ComboBox();
            btnSave = new Button();
            contentPanel = new TableLayoutPanel();
            txtSearch = new TextBox();
            btnReset = new Button();
            btnSearch = new Button();
            filterPanel = new Panel();
            lblTitle = new Label();
            headerPanel = new Panel();
            mainLayout = new TableLayoutPanel();
            mainPanel = new Panel();
            dataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            formPanel.SuspendLayout();
            contentPanel.SuspendLayout();
            filterPanel.SuspendLayout();
            headerPanel.SuspendLayout();
            mainLayout.SuspendLayout();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRole.ForeColor = Color.FromArgb(217, 58, 102);
            lblRole.Location = new Point(22, 266);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(37, 18);
            lblRole.TabIndex = 11;
            lblRole.Text = "Role";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFullName.ForeColor = Color.FromArgb(217, 58, 102);
            lblFullName.Location = new Point(22, 77);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(76, 18);
            lblFullName.TabIndex = 9;
            lblFullName.Text = "Full Name";
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Berlin Sans FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFullName.Location = new Point(21, 98);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(300, 24);
            txtFullName.TabIndex = 8;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Berlin Sans FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(23, 230);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(300, 24);
            txtPassword.TabIndex = 7;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.FromArgb(217, 58, 102);
            lblPassword.Location = new Point(24, 209);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(72, 18);
            lblPassword.TabIndex = 6;
            lblPassword.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Berlin Sans FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(22, 164);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(300, 24);
            txtUsername.TabIndex = 5;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.FromArgb(217, 58, 102);
            lblUsername.Location = new Point(23, 143);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(75, 18);
            lblUsername.TabIndex = 4;
            lblUsername.Text = "Username";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.BackColor = Color.FromArgb(217, 58, 102);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(296, 1033);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 35);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // lblRecordTitle
            // 
            lblRecordTitle.AutoSize = true;
            lblRecordTitle.Font = new Font("Berlin Sans FB", 15.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblRecordTitle.ForeColor = Color.FromArgb(217, 58, 102);
            lblRecordTitle.Location = new Point(22, 25);
            lblRecordTitle.Name = "lblRecordTitle";
            lblRecordTitle.Size = new Size(90, 23);
            lblRecordTitle.TabIndex = 0;
            lblRecordTitle.Text = "Add User";
            // 
            // dataPanel
            // 
            dataPanel.Controls.Add(dgvUsers);
            dataPanel.Dock = DockStyle.Fill;
            dataPanel.Location = new Point(3, 3);
            dataPanel.Name = "dataPanel";
            dataPanel.Padding = new Padding(10);
            dataPanel.Size = new Size(950, 655);
            dataPanel.TabIndex = 0;
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 228, 235);
            dgvUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.BackgroundColor = Color.FromArgb(255, 246, 249);
            dgvUsers.BorderStyle = BorderStyle.None;
            dgvUsers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvUsers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(217, 58, 102);
            dataGridViewCellStyle2.Font = new Font("Berlin Sans FB", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(217, 58, 102);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvUsers.ColumnHeadersHeight = 40;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 246, 249);
            dataGridViewCellStyle3.Font = new Font("Berlin Sans FB", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.Padding = new Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 211, 220);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvUsers.DefaultCellStyle = dataGridViewCellStyle3;
            dgvUsers.Dock = DockStyle.Fill;
            dgvUsers.EnableHeadersVisualStyles = false;
            dgvUsers.GridColor = Color.FromArgb(255, 211, 220);
            dgvUsers.Location = new Point(10, 10);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvUsers.RowHeadersVisible = false;
            dgvUsers.RowTemplate.Height = 35;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(930, 635);
            dgvUsers.TabIndex = 1;
            // 
            // btnCloseForm
            // 
            btnCloseForm.BackColor = Color.Transparent;
            btnCloseForm.BackgroundImage = Properties.Resources.close;
            btnCloseForm.BackgroundImageLayout = ImageLayout.Stretch;
            btnCloseForm.Cursor = Cursors.Hand;
            btnCloseForm.FlatAppearance.BorderColor = Color.FromArgb(255, 79, 129);
            btnCloseForm.FlatAppearance.BorderSize = 0;
            btnCloseForm.FlatStyle = FlatStyle.Flat;
            btnCloseForm.Font = new Font("Berlin Sans FB Demi", 12F, FontStyle.Bold);
            btnCloseForm.ForeColor = Color.FromArgb(255, 79, 129);
            btnCloseForm.Location = new Point(303, 20);
            btnCloseForm.Margin = new Padding(10, 11, 10, 11);
            btnCloseForm.Name = "btnCloseForm";
            btnCloseForm.Size = new Size(20, 20);
            btnCloseForm.TabIndex = 12;
            btnCloseForm.UseVisualStyleBackColor = false;
            btnCloseForm.Visible = false;
            // 
            // formPanel
            // 
            formPanel.BackColor = Color.FromArgb(255, 228, 235);
            formPanel.BorderStyle = BorderStyle.FixedSingle;
            formPanel.Controls.Add(comboBox1);
            formPanel.Controls.Add(btnCloseForm);
            formPanel.Controls.Add(lblRole);
            formPanel.Controls.Add(lblFullName);
            formPanel.Controls.Add(txtFullName);
            formPanel.Controls.Add(txtPassword);
            formPanel.Controls.Add(lblPassword);
            formPanel.Controls.Add(txtUsername);
            formPanel.Controls.Add(lblUsername);
            formPanel.Controls.Add(btnCancel);
            formPanel.Controls.Add(btnSave);
            formPanel.Controls.Add(lblRecordTitle);
            formPanel.Dock = DockStyle.Fill;
            formPanel.Location = new Point(959, 3);
            formPanel.Name = "formPanel";
            formPanel.Padding = new Padding(20);
            formPanel.Size = new Size(346, 655);
            formPanel.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(26, 288);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(297, 23);
            comboBox1.TabIndex = 13;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSave.BackColor = Color.FromArgb(217, 58, 102);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(43, 1033);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 35);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save User";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // contentPanel
            // 
            contentPanel.ColumnCount = 2;
            contentPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            contentPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 352F));
            contentPanel.Controls.Add(dataPanel, 0, 0);
            contentPanel.Controls.Add(formPanel, 1, 0);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(3, 113);
            contentPanel.Name = "contentPanel";
            contentPanel.RowCount = 1;
            contentPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            contentPanel.Size = new Size(1308, 661);
            contentPanel.TabIndex = 2;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Font = new Font("Berlin Sans FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(7, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search users...";
            txtSearch.Size = new Size(1012, 24);
            txtSearch.TabIndex = 0;
            // 
            // btnReset
            // 
            btnReset.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnReset.BackColor = Color.FromArgb(217, 58, 102);
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Berlin Sans FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(2068, 13);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(100, 25);
            btnReset.TabIndex = 2;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.BackColor = Color.FromArgb(217, 58, 102);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Berlin Sans FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(1918, 13);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 25);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // filterPanel
            // 
            filterPanel.Controls.Add(txtSearch);
            filterPanel.Controls.Add(btnReset);
            filterPanel.Controls.Add(btnSearch);
            filterPanel.Dock = DockStyle.Fill;
            filterPanel.Location = new Point(3, 63);
            filterPanel.Name = "filterPanel";
            filterPanel.Padding = new Padding(10, 5, 10, 5);
            filterPanel.Size = new Size(1308, 44);
            filterPanel.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Dock = DockStyle.Left;
            lblTitle.Font = new Font("Berlin Sans FB", 18F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(217, 58, 102);
            lblTitle.Location = new Point(10, 5);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(197, 26);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "User Management";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // headerPanel
            // 
            headerPanel.Controls.Add(lblTitle);
            headerPanel.Dock = DockStyle.Fill;
            headerPanel.Location = new Point(3, 3);
            headerPanel.Name = "headerPanel";
            headerPanel.Padding = new Padding(10, 5, 10, 5);
            headerPanel.Size = new Size(1308, 54);
            headerPanel.TabIndex = 0;
            // 
            // mainLayout
            // 
            mainLayout.ColumnCount = 1;
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainLayout.Controls.Add(headerPanel, 0, 0);
            mainLayout.Controls.Add(filterPanel, 0, 1);
            mainLayout.Controls.Add(contentPanel, 0, 2);
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.Location = new Point(10, 10);
            mainLayout.Name = "mainLayout";
            mainLayout.RowCount = 3;
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainLayout.Size = new Size(1314, 777);
            mainLayout.TabIndex = 0;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(255, 211, 220);
            mainPanel.Controls.Add(mainLayout);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new Padding(10);
            mainPanel.Size = new Size(1334, 797);
            mainPanel.TabIndex = 1;
            // 
            // User_Management
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1334, 797);
            Controls.Add(mainPanel);
            Name = "User_Management";
            Text = "User_Management";
            dataPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            formPanel.ResumeLayout(false);
            formPanel.PerformLayout();
            contentPanel.ResumeLayout(false);
            filterPanel.ResumeLayout(false);
            filterPanel.PerformLayout();
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            mainLayout.ResumeLayout(false);
            mainPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblRole;
        private Label lblFullName;
        private TextBox txtFullName;
        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtUsername;
        private Label lblUsername;
        private Button btnCancel;
        private Label lblRecordTitle;
        private Panel dataPanel;
        private DataGridView dgvUsers;
        private Button btnCloseForm;
        private Panel formPanel;
        private Button btnSave;
        private TableLayoutPanel contentPanel;
        private TextBox txtSearch;
        private Button btnReset;
        private Button btnSearch;
        private Panel filterPanel;
        private Label lblTitle;
        private Panel headerPanel;
        private TableLayoutPanel mainLayout;
        private Panel mainPanel;
        private ComboBox comboBox1;
    }
}