namespace Asset_Management_ni_gad
{
    partial class EmployeeManagement
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
            mainPanel = new Panel();
            mainLayout = new TableLayoutPanel();
            headerPanel = new Panel();
            lblTitle = new Label();
            filterPanel = new Panel();
            txtSearchGuest = new TextBox();
            btnSearchGuest = new Button();
            contentPanel = new TableLayoutPanel();
            dataPanel = new Panel();
            dgvGuest = new DataGridView();
            formPanel = new Panel();
            txtEmail = new TextBox();
            btnCloseForm = new Button();
            lblRole = new Label();
            lblFullName = new Label();
            txtFullName = new TextBox();
            txtNumber = new TextBox();
            lblPassword = new Label();
            btnCancel = new Button();
            btnAddGuest = new Button();
            lblRecordTitle = new Label();
            mainPanel.SuspendLayout();
            mainLayout.SuspendLayout();
            headerPanel.SuspendLayout();
            filterPanel.SuspendLayout();
            contentPanel.SuspendLayout();
            dataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGuest).BeginInit();
            formPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(255, 211, 220);
            mainPanel.Controls.Add(mainLayout);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new Padding(10);
            mainPanel.Size = new Size(1183, 700);
            mainPanel.TabIndex = 0;
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
            mainLayout.Size = new Size(1163, 680);
            mainLayout.TabIndex = 0;
            // 
            // headerPanel
            // 
            headerPanel.Controls.Add(lblTitle);
            headerPanel.Dock = DockStyle.Fill;
            headerPanel.Location = new Point(3, 3);
            headerPanel.Name = "headerPanel";
            headerPanel.Padding = new Padding(10, 5, 10, 5);
            headerPanel.Size = new Size(1157, 54);
            headerPanel.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Dock = DockStyle.Left;
            lblTitle.Font = new Font("Berlin Sans FB", 18F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(217, 58, 102);
            lblTitle.Location = new Point(10, 5);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(210, 26);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Guest Management";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // filterPanel
            // 
            filterPanel.Controls.Add(txtSearchGuest);
            filterPanel.Controls.Add(btnSearchGuest);
            filterPanel.Dock = DockStyle.Fill;
            filterPanel.Location = new Point(3, 63);
            filterPanel.Name = "filterPanel";
            filterPanel.Padding = new Padding(10, 5, 10, 5);
            filterPanel.Size = new Size(1157, 44);
            filterPanel.TabIndex = 1;
            // 
            // txtSearchGuest
            // 
            txtSearchGuest.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearchGuest.Font = new Font("Berlin Sans FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchGuest.Location = new Point(10, 8);
            txtSearchGuest.Name = "txtSearchGuest";
            txtSearchGuest.PlaceholderText = "Search users...";
            txtSearchGuest.Size = new Size(783, 24);
            txtSearchGuest.TabIndex = 0;
            // 
            // btnSearchGuest
            // 
            btnSearchGuest.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearchGuest.BackColor = Color.FromArgb(217, 58, 102);
            btnSearchGuest.FlatAppearance.BorderSize = 0;
            btnSearchGuest.FlatStyle = FlatStyle.Flat;
            btnSearchGuest.Font = new Font("Berlin Sans FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearchGuest.ForeColor = Color.White;
            btnSearchGuest.Location = new Point(803, 8);
            btnSearchGuest.Name = "btnSearchGuest";
            btnSearchGuest.Size = new Size(100, 25);
            btnSearchGuest.TabIndex = 1;
            btnSearchGuest.Text = "Search";
            btnSearchGuest.UseVisualStyleBackColor = false;
            btnSearchGuest.Click += btnSearchGuest_Click_1;
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
            contentPanel.Size = new Size(1157, 564);
            contentPanel.TabIndex = 2;
            // 
            // dataPanel
            // 
            dataPanel.Controls.Add(dgvGuest);
            dataPanel.Dock = DockStyle.Fill;
            dataPanel.Location = new Point(3, 3);
            dataPanel.Name = "dataPanel";
            dataPanel.Padding = new Padding(10);
            dataPanel.Size = new Size(799, 558);
            dataPanel.TabIndex = 0;
            // 
            // dgvGuest
            // 
            dgvGuest.AllowUserToAddRows = false;
            dgvGuest.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 228, 235);
            dgvGuest.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvGuest.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGuest.BackgroundColor = Color.FromArgb(255, 246, 249);
            dgvGuest.BorderStyle = BorderStyle.None;
            dgvGuest.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvGuest.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(217, 58, 102);
            dataGridViewCellStyle2.Font = new Font("Berlin Sans FB", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(217, 58, 102);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvGuest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvGuest.ColumnHeadersHeight = 40;
            dgvGuest.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 246, 249);
            dataGridViewCellStyle3.Font = new Font("Berlin Sans FB", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.Padding = new Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 211, 220);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvGuest.DefaultCellStyle = dataGridViewCellStyle3;
            dgvGuest.Dock = DockStyle.Fill;
            dgvGuest.EnableHeadersVisualStyles = false;
            dgvGuest.GridColor = Color.FromArgb(255, 211, 220);
            dgvGuest.Location = new Point(10, 10);
            dgvGuest.Name = "dgvGuest";
            dgvGuest.ReadOnly = true;
            dgvGuest.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvGuest.RowHeadersVisible = false;
            dgvGuest.RowTemplate.Height = 35;
            dgvGuest.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGuest.Size = new Size(779, 538);
            dgvGuest.TabIndex = 1;
            // 
            // formPanel
            // 
            formPanel.BackColor = Color.FromArgb(255, 228, 235);
            formPanel.BorderStyle = BorderStyle.FixedSingle;
            formPanel.Controls.Add(txtEmail);
            formPanel.Controls.Add(btnCloseForm);
            formPanel.Controls.Add(lblRole);
            formPanel.Controls.Add(lblFullName);
            formPanel.Controls.Add(txtFullName);
            formPanel.Controls.Add(txtNumber);
            formPanel.Controls.Add(lblPassword);
            formPanel.Controls.Add(btnCancel);
            formPanel.Controls.Add(btnAddGuest);
            formPanel.Controls.Add(lblRecordTitle);
            formPanel.Dock = DockStyle.Fill;
            formPanel.Location = new Point(808, 3);
            formPanel.Name = "formPanel";
            formPanel.Padding = new Padding(20);
            formPanel.Size = new Size(346, 558);
            formPanel.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Berlin Sans FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(21, 209);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(300, 24);
            txtEmail.TabIndex = 13;
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
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRole.ForeColor = Color.FromArgb(217, 58, 102);
            lblRole.Location = new Point(19, 183);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(45, 18);
            lblRole.TabIndex = 11;
            lblRole.Text = "Email";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFullName.ForeColor = Color.FromArgb(217, 58, 102);
            lblFullName.Location = new Point(23, 72);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(76, 18);
            lblFullName.TabIndex = 9;
            lblFullName.Text = "Full Name";
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Berlin Sans FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFullName.Location = new Point(23, 93);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(300, 24);
            txtFullName.TabIndex = 8;
            // 
            // txtNumber
            // 
            txtNumber.Font = new Font("Berlin Sans FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumber.Location = new Point(21, 147);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(300, 24);
            txtNumber.TabIndex = 7;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.FromArgb(217, 58, 102);
            lblPassword.Location = new Point(21, 126);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(116, 18);
            lblPassword.TabIndex = 6;
            lblPassword.Text = "Contact Number";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.BackColor = Color.FromArgb(217, 58, 102);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(179, 500);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(146, 35);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click_1;
            // 
            // btnAddGuest
            // 
            btnAddGuest.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddGuest.BackColor = Color.FromArgb(217, 58, 102);
            btnAddGuest.FlatAppearance.BorderSize = 0;
            btnAddGuest.FlatStyle = FlatStyle.Flat;
            btnAddGuest.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddGuest.ForeColor = Color.White;
            btnAddGuest.Location = new Point(23, 500);
            btnAddGuest.Name = "btnAddGuest";
            btnAddGuest.Size = new Size(131, 35);
            btnAddGuest.TabIndex = 1;
            btnAddGuest.Text = "Add Guest";
            btnAddGuest.UseVisualStyleBackColor = false;
            btnAddGuest.Click += btnAddGuest_Click_1;
            // 
            // lblRecordTitle
            // 
            lblRecordTitle.AutoSize = true;
            lblRecordTitle.Font = new Font("Berlin Sans FB", 15.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblRecordTitle.ForeColor = Color.FromArgb(217, 58, 102);
            lblRecordTitle.Location = new Point(23, 20);
            lblRecordTitle.Name = "lblRecordTitle";
            lblRecordTitle.Size = new Size(175, 23);
            lblRecordTitle.TabIndex = 0;
            lblRecordTitle.Text = "Add/Update Guest";
            // 
            // EmployeeManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1183, 700);
            Controls.Add(mainPanel);
            Font = new Font("Berlin Sans FB", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinimumSize = new Size(1000, 600);
            Name = "EmployeeManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User Management";
            mainPanel.ResumeLayout(false);
            mainLayout.ResumeLayout(false);
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            filterPanel.ResumeLayout(false);
            filterPanel.PerformLayout();
            contentPanel.ResumeLayout(false);
            dataPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGuest).EndInit();
            formPanel.ResumeLayout(false);
            formPanel.PerformLayout();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel filterPanel;
        private System.Windows.Forms.TextBox txtSearchGuest;
        private System.Windows.Forms.Button btnSearchGuest;
        private System.Windows.Forms.TableLayoutPanel contentPanel;
        private System.Windows.Forms.Panel dataPanel;
        private System.Windows.Forms.DataGridView dgvGuest;
        private System.Windows.Forms.Panel formPanel;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddGuest;
        private System.Windows.Forms.Label lblRecordTitle;
        private Button btnCloseForm;
        private Label lblRole;
        private TextBox txtEmail;
    }
}