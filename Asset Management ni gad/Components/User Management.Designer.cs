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
            txtConfirmPassword = new TextBox();
            lblPassword = new Label();
            txtEmail = new TextBox();
            emailtext = new Label();
            btnCancel = new Button();
            lblRecordTitle = new Label();
            dataPanel = new Panel();
            dgvEmployee = new DataGridView();
            btnCloseForm = new Button();
            formPanel = new Panel();
            txtPassword = new TextBox();
            label1 = new Label();
            button1 = new Button();
            btnAddEmployee = new Button();
            cmbRole = new ComboBox();
            btnSave = new Button();
            contentPanel = new TableLayoutPanel();
            txtSearchEmployee = new TextBox();
            btnReset = new Button();
            btnSearch = new Button();
            filterPanel = new Panel();
            btnSearchEmployee = new Button();
            lblTitle = new Label();
            headerPanel = new Panel();
            mainLayout = new TableLayoutPanel();
            mainPanel = new Panel();
            dataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
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
            lblRole.Location = new Point(20, 329);
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
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("Berlin Sans FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmPassword.Location = new Point(21, 293);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(300, 24);
            txtConfirmPassword.TabIndex = 7;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.FromArgb(217, 58, 102);
            lblPassword.Location = new Point(22, 272);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(127, 18);
            lblPassword.TabIndex = 6;
            lblPassword.Text = "Confirm Password";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Berlin Sans FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(22, 164);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(300, 24);
            txtEmail.TabIndex = 5;
            // 
            // emailtext
            // 
            emailtext.AutoSize = true;
            emailtext.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailtext.ForeColor = Color.FromArgb(217, 58, 102);
            emailtext.Location = new Point(23, 143);
            emailtext.Name = "emailtext";
            emailtext.Size = new Size(45, 18);
            emailtext.TabIndex = 4;
            emailtext.Text = "Email";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.BackColor = Color.FromArgb(217, 58, 102);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(296, 913);
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
            lblRecordTitle.Size = new Size(130, 23);
            lblRecordTitle.TabIndex = 0;
            lblRecordTitle.Text = "Add/Edit User";
            // 
            // dataPanel
            // 
            dataPanel.Controls.Add(dgvEmployee);
            dataPanel.Dock = DockStyle.Fill;
            dataPanel.Location = new Point(3, 3);
            dataPanel.Name = "dataPanel";
            dataPanel.Padding = new Padding(10);
            dataPanel.Size = new Size(344, 535);
            dataPanel.TabIndex = 0;
            // 
            // dgvEmployee
            // 
            dgvEmployee.AllowUserToAddRows = false;
            dgvEmployee.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 228, 235);
            dgvEmployee.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployee.BackgroundColor = Color.FromArgb(255, 246, 249);
            dgvEmployee.BorderStyle = BorderStyle.None;
            dgvEmployee.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvEmployee.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(217, 58, 102);
            dataGridViewCellStyle2.Font = new Font("Berlin Sans FB", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(217, 58, 102);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvEmployee.ColumnHeadersHeight = 40;
            dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 246, 249);
            dataGridViewCellStyle3.Font = new Font("Berlin Sans FB", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.Padding = new Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 211, 220);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvEmployee.DefaultCellStyle = dataGridViewCellStyle3;
            dgvEmployee.Dock = DockStyle.Fill;
            dgvEmployee.EnableHeadersVisualStyles = false;
            dgvEmployee.GridColor = Color.FromArgb(255, 211, 220);
            dgvEmployee.Location = new Point(10, 10);
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.ReadOnly = true;
            dgvEmployee.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvEmployee.RowHeadersVisible = false;
            dgvEmployee.RowTemplate.Height = 35;
            dgvEmployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployee.Size = new Size(324, 515);
            dgvEmployee.TabIndex = 1;
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
            formPanel.Controls.Add(txtPassword);
            formPanel.Controls.Add(label1);
            formPanel.Controls.Add(button1);
            formPanel.Controls.Add(btnAddEmployee);
            formPanel.Controls.Add(cmbRole);
            formPanel.Controls.Add(btnCloseForm);
            formPanel.Controls.Add(lblRole);
            formPanel.Controls.Add(lblFullName);
            formPanel.Controls.Add(txtFullName);
            formPanel.Controls.Add(txtConfirmPassword);
            formPanel.Controls.Add(lblPassword);
            formPanel.Controls.Add(txtEmail);
            formPanel.Controls.Add(emailtext);
            formPanel.Controls.Add(btnCancel);
            formPanel.Controls.Add(btnSave);
            formPanel.Controls.Add(lblRecordTitle);
            formPanel.Dock = DockStyle.Fill;
            formPanel.Location = new Point(353, 3);
            formPanel.Name = "formPanel";
            formPanel.Padding = new Padding(20);
            formPanel.Size = new Size(346, 535);
            formPanel.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Berlin Sans FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(21, 230);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(300, 24);
            txtPassword.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(217, 58, 102);
            label1.Location = new Point(22, 209);
            label1.Name = "label1";
            label1.Size = new Size(72, 18);
            label1.TabIndex = 16;
            label1.Text = "Password";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(217, 58, 102);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(175, 475);
            button1.Name = "button1";
            button1.Size = new Size(146, 35);
            button1.TabIndex = 15;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddEmployee.BackColor = Color.FromArgb(217, 58, 102);
            btnAddEmployee.FlatAppearance.BorderSize = 0;
            btnAddEmployee.FlatStyle = FlatStyle.Flat;
            btnAddEmployee.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddEmployee.ForeColor = Color.White;
            btnAddEmployee.Location = new Point(19, 475);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(131, 35);
            btnAddEmployee.TabIndex = 14;
            btnAddEmployee.Text = "Add user";
            btnAddEmployee.UseVisualStyleBackColor = false;
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(24, 351);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(297, 23);
            cmbRole.TabIndex = 13;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSave.BackColor = Color.FromArgb(217, 58, 102);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(43, 913);
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
            contentPanel.Size = new Size(702, 541);
            contentPanel.TabIndex = 2;
            // 
            // txtSearchEmployee
            // 
            txtSearchEmployee.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearchEmployee.Font = new Font("Berlin Sans FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchEmployee.Location = new Point(7, 12);
            txtSearchEmployee.Name = "txtSearchEmployee";
            txtSearchEmployee.PlaceholderText = "Search users...";
            txtSearchEmployee.Size = new Size(406, 24);
            txtSearchEmployee.TabIndex = 0;
            // 
            // btnReset
            // 
            btnReset.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnReset.BackColor = Color.FromArgb(217, 58, 102);
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Berlin Sans FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(1462, 13);
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
            btnSearch.Location = new Point(1312, 13);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 25);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // filterPanel
            // 
            filterPanel.Controls.Add(btnSearchEmployee);
            filterPanel.Controls.Add(txtSearchEmployee);
            filterPanel.Controls.Add(btnReset);
            filterPanel.Controls.Add(btnSearch);
            filterPanel.Dock = DockStyle.Fill;
            filterPanel.Location = new Point(3, 63);
            filterPanel.Name = "filterPanel";
            filterPanel.Padding = new Padding(10, 5, 10, 5);
            filterPanel.Size = new Size(702, 44);
            filterPanel.TabIndex = 1;
            // 
            // btnSearchEmployee
            // 
            btnSearchEmployee.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSearchEmployee.BackColor = Color.FromArgb(217, 58, 102);
            btnSearchEmployee.FlatAppearance.BorderSize = 0;
            btnSearchEmployee.FlatStyle = FlatStyle.Flat;
            btnSearchEmployee.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearchEmployee.ForeColor = Color.White;
            btnSearchEmployee.Location = new Point(429, 6);
            btnSearchEmployee.Name = "btnSearchEmployee";
            btnSearchEmployee.Size = new Size(146, 35);
            btnSearchEmployee.TabIndex = 18;
            btnSearchEmployee.Text = "Search";
            btnSearchEmployee.UseVisualStyleBackColor = false;
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
            headerPanel.Size = new Size(702, 54);
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
            mainLayout.Size = new Size(708, 657);
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
            mainPanel.Size = new Size(728, 677);
            mainPanel.TabIndex = 1;
            // 
            // User_Management
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 677);
            Controls.Add(mainPanel);
            Name = "User_Management";
            Text = "User_Management";
            dataPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
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
        private TextBox txtConfirmPassword;
        private Label lblPassword;
        private TextBox txtEmail;
        private Label emailtext;
        private Button btnCancel;
        private Label lblRecordTitle;
        private Panel dataPanel;
        private DataGridView dgvEmployee;
        private Button btnCloseForm;
        private Panel formPanel;
        private Button btnSave;
        private TableLayoutPanel contentPanel;
        private TextBox txtSearchEmployee;
        private Button btnReset;
        private Button btnSearch;
        private Panel filterPanel;
        private Label lblTitle;
        private Panel headerPanel;
        private TableLayoutPanel mainLayout;
        private Panel mainPanel;
        private ComboBox cmbRole;
        private Button button1;
        private Button btnAddEmployee;
        private TextBox txtPassword;
        private Label label1;
        private Button btnSearchEmployee;
    }
}