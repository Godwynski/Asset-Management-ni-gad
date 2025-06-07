namespace Asset_Management_ni_gad.Components
{
    partial class AssetManagement
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
            txtUsername = new TextBox();
            lblUsername = new Label();
            btnCancel = new Button();
            lblRecordTitle = new Label();
            dataPanel = new Panel();
            dgvUsers = new DataGridView();
            textBox1 = new TextBox();
            btnCloseForm = new Button();
            formPanel = new Panel();
            textBox2 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            btnSave = new Button();
            contentPanel = new TableLayoutPanel();
            txtSearch = new TextBox();
            btnReset = new Button();
            btnSearch = new Button();
            filterPanel = new Panel();
            button1 = new Button();
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
            lblRole.Location = new Point(21, 289);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(72, 18);
            lblRole.TabIndex = 11;
            lblRole.Text = "Password";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFullName.ForeColor = Color.FromArgb(217, 58, 102);
            lblFullName.Location = new Point(21, 92);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(80, 18);
            lblFullName.TabIndex = 9;
            lblFullName.Text = "First Name";
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Berlin Sans FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFullName.Location = new Point(23, 113);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(300, 24);
            txtFullName.TabIndex = 8;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Berlin Sans FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(21, 179);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(300, 24);
            txtUsername.TabIndex = 5;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.FromArgb(217, 58, 102);
            lblUsername.Location = new Point(21, 158);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(80, 18);
            lblUsername.TabIndex = 4;
            lblUsername.Text = "Last Name";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.BackColor = Color.FromArgb(217, 58, 102);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(296, 929);
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
            lblRecordTitle.Location = new Point(23, 40);
            lblRecordTitle.Name = "lblRecordTitle";
            lblRecordTitle.Size = new Size(139, 23);
            lblRecordTitle.TabIndex = 0;
            lblRecordTitle.Text = "Add Employee";
            // 
            // dataPanel
            // 
            dataPanel.Controls.Add(dgvUsers);
            dataPanel.Dock = DockStyle.Fill;
            dataPanel.Location = new Point(3, 3);
            dataPanel.Name = "dataPanel";
            dataPanel.Padding = new Padding(10);
            dataPanel.Size = new Size(852, 551);
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
            dgvUsers.Size = new Size(832, 531);
            dgvUsers.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Berlin Sans FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(21, 310);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(300, 24);
            textBox1.TabIndex = 13;
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
            formPanel.Controls.Add(textBox2);
            formPanel.Controls.Add(label2);
            formPanel.Controls.Add(label1);
            formPanel.Controls.Add(comboBox1);
            formPanel.Controls.Add(textBox1);
            formPanel.Controls.Add(btnCloseForm);
            formPanel.Controls.Add(lblRole);
            formPanel.Controls.Add(lblFullName);
            formPanel.Controls.Add(txtFullName);
            formPanel.Controls.Add(txtUsername);
            formPanel.Controls.Add(lblUsername);
            formPanel.Controls.Add(btnCancel);
            formPanel.Controls.Add(btnSave);
            formPanel.Controls.Add(lblRecordTitle);
            formPanel.Dock = DockStyle.Fill;
            formPanel.Location = new Point(861, 3);
            formPanel.Name = "formPanel";
            formPanel.Padding = new Padding(20);
            formPanel.Size = new Size(346, 551);
            formPanel.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Berlin Sans FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(21, 244);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(300, 24);
            textBox2.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(217, 58, 102);
            label2.Location = new Point(21, 223);
            label2.Name = "label2";
            label2.Size = new Size(45, 18);
            label2.TabIndex = 16;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(217, 58, 102);
            label1.Location = new Point(21, 354);
            label1.Name = "label1";
            label1.Size = new Size(37, 18);
            label1.TabIndex = 15;
            label1.Text = "Role";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(21, 375);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(302, 23);
            comboBox1.TabIndex = 14;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSave.BackColor = Color.FromArgb(217, 58, 102);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(43, 929);
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
            contentPanel.Size = new Size(1210, 557);
            contentPanel.TabIndex = 2;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Berlin Sans FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(10, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search users...";
            txtSearch.Size = new Size(441, 24);
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
            btnReset.Location = new Point(1970, 13);
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
            btnSearch.Location = new Point(1820, 13);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 25);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // filterPanel
            // 
            filterPanel.Controls.Add(button1);
            filterPanel.Controls.Add(txtSearch);
            filterPanel.Controls.Add(btnReset);
            filterPanel.Controls.Add(btnSearch);
            filterPanel.Dock = DockStyle.Fill;
            filterPanel.Location = new Point(3, 63);
            filterPanel.Name = "filterPanel";
            filterPanel.Padding = new Padding(10, 5, 10, 5);
            filterPanel.Size = new Size(1210, 44);
            filterPanel.TabIndex = 1;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(217, 58, 102);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(466, 8);
            button1.Name = "button1";
            button1.Size = new Size(106, 31);
            button1.TabIndex = 3;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Dock = DockStyle.Left;
            lblTitle.Font = new Font("Berlin Sans FB", 18F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(217, 58, 102);
            lblTitle.Location = new Point(10, 5);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(252, 26);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Employee Management";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // headerPanel
            // 
            headerPanel.Controls.Add(lblTitle);
            headerPanel.Dock = DockStyle.Fill;
            headerPanel.Location = new Point(3, 3);
            headerPanel.Name = "headerPanel";
            headerPanel.Padding = new Padding(10, 5, 10, 5);
            headerPanel.Size = new Size(1210, 54);
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
            mainLayout.Size = new Size(1216, 673);
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
            mainPanel.Size = new Size(1236, 693);
            mainPanel.TabIndex = 1;
            // 
            // AssetManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1236, 693);
            Controls.Add(mainPanel);
            Name = "AssetManagement";
            Text = "Asset Management System";
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
        private TextBox txtUsername;
        private Label lblUsername;
        private Button btnCancel;
        private Label lblRecordTitle;
        private Panel dataPanel;
        private DataGridView dgvUsers;
        private TextBox textBox1;
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
        private Label label1;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private Label label2;
        private Button button1;
    }
}