namespace Asset_Management_ni_gad
{
    partial class Maintenance
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblTitle = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            SidePanel = new Panel();
            lblCost = new Label();
            txtCost = new TextBox();
            cmbStatus = new ComboBox();
            lblDate = new Label();
            dtpMaintenanceDate = new DateTimePicker();
            txtIssueDescription = new RichTextBox();
            lblIssueDescription = new Label();
            cmbAsset = new ComboBox();
            btnClose = new Button();
            btnCancel = new Button();
            btnSave = new Button();
            lblRecordTitle = new Label();
            lblStatus = new Label();
            lblAsset = new Label();
            dgvMaintenance = new DataGridView();
            panel2 = new Panel();
            cmbStatusFilter = new ComboBox();
            txtSearch = new TextBox();
            btnReset = new Button();
            btnSearch = new Button();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMaintenance).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 211, 220);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1200, 700);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lblTitle, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 2);
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1200, 700);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Berlin Sans FB", 18F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(217, 58, 102);
            lblTitle.Location = new Point(30, 20);
            lblTitle.Margin = new Padding(30, 20, 0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1170, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Maintenance Records";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 350F));
            tableLayoutPanel3.Controls.Add(SidePanel, 1, 0);
            tableLayoutPanel3.Controls.Add(dgvMaintenance, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(10, 126);
            tableLayoutPanel3.Margin = new Padding(10);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1180, 564);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // SidePanel
            // 
            SidePanel.BackColor = Color.FromArgb(255, 228, 235);
            SidePanel.BorderStyle = BorderStyle.FixedSingle;
            SidePanel.Controls.Add(lblCost);
            SidePanel.Controls.Add(txtCost);
            SidePanel.Controls.Add(cmbStatus);
            SidePanel.Controls.Add(lblDate);
            SidePanel.Controls.Add(dtpMaintenanceDate);
            SidePanel.Controls.Add(txtIssueDescription);
            SidePanel.Controls.Add(lblIssueDescription);
            SidePanel.Controls.Add(cmbAsset);
            SidePanel.Controls.Add(btnClose);
            SidePanel.Controls.Add(btnCancel);
            SidePanel.Controls.Add(btnSave);
            SidePanel.Controls.Add(lblRecordTitle);
            SidePanel.Controls.Add(lblStatus);
            SidePanel.Controls.Add(lblAsset);
            SidePanel.Dock = DockStyle.Fill;
            SidePanel.Location = new Point(833, 3);
            SidePanel.Name = "SidePanel";
            SidePanel.Padding = new Padding(20);
            SidePanel.Size = new Size(344, 558);
            SidePanel.TabIndex = 0;
            // 
            // lblCost
            // 
            lblCost.AutoSize = true;
            lblCost.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCost.ForeColor = Color.FromArgb(217, 58, 102);
            lblCost.Location = new Point(23, 365);
            lblCost.Name = "lblCost";
            lblCost.Size = new Size(35, 18);
            lblCost.TabIndex = 13;
            lblCost.Text = "Cost";
            // 
            // txtCost
            // 
            txtCost.Location = new Point(23, 386);
            txtCost.Name = "txtCost";
            txtCost.Size = new Size(300, 23);
            txtCost.TabIndex = 12;
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Pending", "In Progress", "Completed" });
            cmbStatus.Location = new Point(23, 339);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(300, 23);
            cmbStatus.TabIndex = 11;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDate.ForeColor = Color.FromArgb(217, 58, 102);
            lblDate.Location = new Point(23, 262);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(128, 18);
            lblDate.TabIndex = 10;
            lblDate.Text = "Maintenance Date";
            // 
            // dtpMaintenanceDate
            // 
            dtpMaintenanceDate.Location = new Point(23, 283);
            dtpMaintenanceDate.Name = "dtpMaintenanceDate";
            dtpMaintenanceDate.Size = new Size(300, 23);
            dtpMaintenanceDate.TabIndex = 9;
            // 
            // txtIssueDescription
            // 
            txtIssueDescription.BorderStyle = BorderStyle.FixedSingle;
            txtIssueDescription.Location = new Point(23, 160);
            txtIssueDescription.Name = "txtIssueDescription";
            txtIssueDescription.Size = new Size(300, 99);
            txtIssueDescription.TabIndex = 8;
            txtIssueDescription.Text = "";
            // 
            // lblIssueDescription
            // 
            lblIssueDescription.AutoSize = true;
            lblIssueDescription.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIssueDescription.ForeColor = Color.FromArgb(217, 58, 102);
            lblIssueDescription.Location = new Point(23, 139);
            lblIssueDescription.Name = "lblIssueDescription";
            lblIssueDescription.Size = new Size(112, 18);
            lblIssueDescription.TabIndex = 7;
            lblIssueDescription.Text = "Issue Description";
            // 
            // cmbAsset
            // 
            cmbAsset.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAsset.FormattingEnabled = true;
            cmbAsset.Location = new Point(23, 100);
            cmbAsset.Name = "cmbAsset";
            cmbAsset.Size = new Size(300, 23);
            cmbAsset.TabIndex = 6;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(310, 20);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(20, 20);
            btnClose.TabIndex = 5;
            btnClose.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.BackColor = Color.FromArgb(217, 58, 102);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(168, 504);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 35);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSave.BackColor = Color.FromArgb(217, 58, 102);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(23, 504);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 35);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save Record";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // lblRecordTitle
            // 
            lblRecordTitle.AutoSize = true;
            lblRecordTitle.Font = new Font("Berlin Sans FB", 15.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblRecordTitle.ForeColor = Color.FromArgb(217, 58, 102);
            lblRecordTitle.Location = new Point(23, 20);
            lblRecordTitle.Name = "lblRecordTitle";
            lblRecordTitle.Size = new Size(70, 23);
            lblRecordTitle.TabIndex = 2;
            lblRecordTitle.Text = "Record";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.FromArgb(217, 58, 102);
            lblStatus.Location = new Point(23, 318);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(47, 18);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "Status";
            // 
            // lblAsset
            // 
            lblAsset.AutoSize = true;
            lblAsset.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAsset.ForeColor = Color.FromArgb(217, 58, 102);
            lblAsset.Location = new Point(23, 80);
            lblAsset.Name = "lblAsset";
            lblAsset.Size = new Size(83, 18);
            lblAsset.TabIndex = 0;
            lblAsset.Text = "Select Asset";
            // 
            // dgvMaintenance
            // 
            dgvMaintenance.AllowUserToAddRows = false;
            dgvMaintenance.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 228, 235);
            dgvMaintenance.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvMaintenance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMaintenance.BackgroundColor = Color.FromArgb(255, 246, 249);
            dgvMaintenance.BorderStyle = BorderStyle.None;
            dgvMaintenance.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvMaintenance.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(217, 58, 102);
            dataGridViewCellStyle5.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.Padding = new Padding(5);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(217, 58, 102);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvMaintenance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvMaintenance.ColumnHeadersHeight = 40;
            dgvMaintenance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(255, 246, 249);
            dataGridViewCellStyle6.Font = new Font("Berlin Sans FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle6.Padding = new Padding(5);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(255, 211, 220);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvMaintenance.DefaultCellStyle = dataGridViewCellStyle6;
            dgvMaintenance.Dock = DockStyle.Fill;
            dgvMaintenance.EnableHeadersVisualStyles = false;
            dgvMaintenance.GridColor = Color.FromArgb(255, 211, 220);
            dgvMaintenance.Location = new Point(20, 20);
            dgvMaintenance.Margin = new Padding(20);
            dgvMaintenance.Name = "dgvMaintenance";
            dgvMaintenance.ReadOnly = true;
            dgvMaintenance.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvMaintenance.RowHeadersVisible = false;
            dgvMaintenance.RowTemplate.Height = 35;
            dgvMaintenance.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMaintenance.Size = new Size(790, 524);
            dgvMaintenance.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(cmbStatusFilter);
            panel2.Controls.Add(txtSearch);
            panel2.Controls.Add(btnReset);
            panel2.Controls.Add(btnSearch);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(20, 68);
            panel2.Margin = new Padding(20, 10, 20, 10);
            panel2.Name = "panel2";
            panel2.Size = new Size(1160, 38);
            panel2.TabIndex = 2;
            // 
            // cmbStatusFilter
            // 
            cmbStatusFilter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbStatusFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatusFilter.FormattingEnabled = true;
            cmbStatusFilter.Items.AddRange(new object[] { "All Statuses", "Pending", "In Progress", "Completed" });
            cmbStatusFilter.Location = new Point(900, 8);
            cmbStatusFilter.Name = "cmbStatusFilter";
            cmbStatusFilter.Size = new Size(150, 23);
            cmbStatusFilter.TabIndex = 3;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Location = new Point(10, 8);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search maintenance records...";
            txtSearch.Size = new Size(600, 23);
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
            btnReset.Location = new Point(1060, 8);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(90, 25);
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
            btnSearch.Location = new Point(620, 8);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(90, 25);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // Maintenance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 700);
            Controls.Add(panel1);
            MinimumSize = new Size(1000, 600);
            Name = "Maintenance";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Maintenance Records";
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            SidePanel.ResumeLayout(false);
            SidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMaintenance).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblTitle;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel SidePanel;
        private Label lblCost;
        private TextBox txtCost;
        private ComboBox cmbStatus;
        private Label lblDate;
        private DateTimePicker dtpMaintenanceDate;
        private RichTextBox txtIssueDescription;
        private Label lblIssueDescription;
        private ComboBox cmbAsset;
        private Button btnClose;
        private Button btnCancel;
        private Button btnSave;
        private Label lblRecordTitle;
        private Label lblStatus;
        private Label lblAsset;
        private DataGridView dgvMaintenance;
        private Panel panel2;
        private ComboBox cmbStatusFilter;
        private TextBox txtSearch;
        private Button btnReset;
        private Button btnSearch;
    }
}