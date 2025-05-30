namespace Asset_Management_ni_gad
{
    partial class CheckOut
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
            mainPanel = new Panel();
            mainLayout = new TableLayoutPanel();
            headerPanel = new Panel();
            lblTitle = new Label();
            filterPanel = new Panel();
            txtSearch = new TextBox();
            btnRefresh = new Button();
            btnSearch = new Button();
            dataPanel = new Panel();
            dgvAssignedAssets = new DataGridView();
            statusPanel = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            grpStatus = new GroupBox();
            radRetired = new RadioButton();
            radUnderMaintenance = new RadioButton();
            radAvailable = new RadioButton();
            grpMaintenance = new GroupBox();
            txtIssueDescription = new RichTextBox();
            lblIssue = new Label();
            txtMaintenanceCost = new TextBox();
            lblCost = new Label();
            btnConfirmReturn = new Button();
            btnCancel = new Button();
            mainPanel.SuspendLayout();
            mainLayout.SuspendLayout();
            headerPanel.SuspendLayout();
            filterPanel.SuspendLayout();
            dataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAssignedAssets).BeginInit();
            statusPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            grpStatus.SuspendLayout();
            grpMaintenance.SuspendLayout();
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
            mainPanel.Size = new Size(1211, 666);
            mainPanel.TabIndex = 0;
            // 
            // mainLayout
            // 
            mainLayout.ColumnCount = 1;
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainLayout.Controls.Add(headerPanel, 0, 0);
            mainLayout.Controls.Add(filterPanel, 0, 1);
            mainLayout.Controls.Add(dataPanel, 0, 2);
            mainLayout.Controls.Add(statusPanel, 0, 3);
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.Location = new Point(10, 10);
            mainLayout.Name = "mainLayout";
            mainLayout.RowCount = 4;
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 204F));
            mainLayout.Size = new Size(1191, 646);
            mainLayout.TabIndex = 0;
            // 
            // headerPanel
            // 
            headerPanel.Controls.Add(lblTitle);
            headerPanel.Dock = DockStyle.Fill;
            headerPanel.Location = new Point(3, 3);
            headerPanel.Name = "headerPanel";
            headerPanel.Padding = new Padding(10, 5, 10, 5);
            headerPanel.Size = new Size(1185, 54);
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
            lblTitle.Size = new Size(117, 26);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Check Out";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // filterPanel
            // 
            filterPanel.Controls.Add(txtSearch);
            filterPanel.Controls.Add(btnRefresh);
            filterPanel.Controls.Add(btnSearch);
            filterPanel.Dock = DockStyle.Fill;
            filterPanel.Location = new Point(3, 63);
            filterPanel.Name = "filterPanel";
            filterPanel.Padding = new Padding(10, 5, 10, 5);
            filterPanel.Size = new Size(1185, 44);
            filterPanel.TabIndex = 1;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Font = new Font("Berlin Sans FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(10, 8);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search Check-In...";
            txtSearch.Size = new Size(908, 24);
            txtSearch.TabIndex = 0;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.BackColor = Color.FromArgb(217, 58, 102);
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Berlin Sans FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(1046, 7);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(100, 25);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.BackColor = Color.FromArgb(217, 58, 102);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Berlin Sans FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(928, 8);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 25);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // dataPanel
            // 
            dataPanel.Controls.Add(dgvAssignedAssets);
            dataPanel.Dock = DockStyle.Fill;
            dataPanel.Location = new Point(3, 113);
            dataPanel.Name = "dataPanel";
            dataPanel.Padding = new Padding(10);
            dataPanel.Size = new Size(1185, 326);
            dataPanel.TabIndex = 2;
            // 
            // dgvAssignedAssets
            // 
            dgvAssignedAssets.AllowUserToAddRows = false;
            dgvAssignedAssets.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 228, 235);
            dgvAssignedAssets.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvAssignedAssets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAssignedAssets.BackgroundColor = Color.FromArgb(255, 246, 249);
            dgvAssignedAssets.BorderStyle = BorderStyle.None;
            dgvAssignedAssets.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAssignedAssets.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(217, 58, 102);
            dataGridViewCellStyle5.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.Padding = new Padding(5);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(217, 58, 102);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvAssignedAssets.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvAssignedAssets.ColumnHeadersHeight = 40;
            dgvAssignedAssets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(255, 246, 249);
            dataGridViewCellStyle6.Font = new Font("Berlin Sans FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle6.Padding = new Padding(5);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(255, 211, 220);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvAssignedAssets.DefaultCellStyle = dataGridViewCellStyle6;
            dgvAssignedAssets.Dock = DockStyle.Fill;
            dgvAssignedAssets.EnableHeadersVisualStyles = false;
            dgvAssignedAssets.GridColor = Color.FromArgb(255, 211, 220);
            dgvAssignedAssets.Location = new Point(10, 10);
            dgvAssignedAssets.Name = "dgvAssignedAssets";
            dgvAssignedAssets.ReadOnly = true;
            dgvAssignedAssets.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvAssignedAssets.RowHeadersVisible = false;
            dgvAssignedAssets.RowTemplate.Height = 35;
            dgvAssignedAssets.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAssignedAssets.Size = new Size(1165, 306);
            dgvAssignedAssets.TabIndex = 1;
            // 
            // statusPanel
            // 
            statusPanel.Controls.Add(tableLayoutPanel1);
            statusPanel.Controls.Add(btnCancel);
            statusPanel.Dock = DockStyle.Bottom;
            statusPanel.Location = new Point(3, 445);
            statusPanel.Name = "statusPanel";
            statusPanel.Padding = new Padding(10);
            statusPanel.Size = new Size(1185, 198);
            statusPanel.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 159F));
            tableLayoutPanel1.Controls.Add(grpStatus, 0, 0);
            tableLayoutPanel1.Controls.Add(grpMaintenance, 1, 0);
            tableLayoutPanel1.Controls.Add(btnConfirmReturn, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(10, 10);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1165, 178);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // grpStatus
            // 
            grpStatus.Controls.Add(radRetired);
            grpStatus.Controls.Add(radUnderMaintenance);
            grpStatus.Controls.Add(radAvailable);
            grpStatus.Font = new Font("Berlin Sans FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpStatus.ForeColor = Color.FromArgb(217, 58, 102);
            grpStatus.Location = new Point(3, 3);
            grpStatus.Name = "grpStatus";
            grpStatus.Size = new Size(334, 172);
            grpStatus.TabIndex = 2;
            grpStatus.TabStop = false;
            grpStatus.Text = "Room Status";
            // 
            // radRetired
            // 
            radRetired.AutoSize = true;
            radRetired.Location = new Point(20, 100);
            radRetired.Name = "radRetired";
            radRetired.Size = new Size(98, 21);
            radRetired.TabIndex = 2;
            radRetired.TabStop = true;
            radRetired.Text = "Unavailable";
            radRetired.UseVisualStyleBackColor = true;
            // 
            // radUnderMaintenance
            // 
            radUnderMaintenance.AutoSize = true;
            radUnderMaintenance.Location = new Point(20, 60);
            radUnderMaintenance.Name = "radUnderMaintenance";
            radUnderMaintenance.Size = new Size(148, 21);
            radUnderMaintenance.TabIndex = 1;
            radUnderMaintenance.TabStop = true;
            radUnderMaintenance.Text = "Under Maintenance";
            radUnderMaintenance.UseVisualStyleBackColor = true;
            // 
            // radAvailable
            // 
            radAvailable.AutoSize = true;
            radAvailable.Checked = true;
            radAvailable.Location = new Point(20, 20);
            radAvailable.Name = "radAvailable";
            radAvailable.Size = new Size(82, 21);
            radAvailable.TabIndex = 0;
            radAvailable.TabStop = true;
            radAvailable.Text = "Available";
            radAvailable.UseVisualStyleBackColor = true;
            // 
            // grpMaintenance
            // 
            grpMaintenance.Controls.Add(txtIssueDescription);
            grpMaintenance.Controls.Add(lblIssue);
            grpMaintenance.Controls.Add(txtMaintenanceCost);
            grpMaintenance.Controls.Add(lblCost);
            grpMaintenance.Enabled = false;
            grpMaintenance.Font = new Font("Berlin Sans FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpMaintenance.ForeColor = Color.FromArgb(217, 58, 102);
            grpMaintenance.Location = new Point(506, 3);
            grpMaintenance.Name = "grpMaintenance";
            grpMaintenance.Size = new Size(383, 172);
            grpMaintenance.TabIndex = 3;
            grpMaintenance.TabStop = false;
            grpMaintenance.Text = "Payment Details";
            // 
            // txtIssueDescription
            // 
            txtIssueDescription.Location = new Point(5, 112);
            txtIssueDescription.Name = "txtIssueDescription";
            txtIssueDescription.Size = new Size(291, 60);
            txtIssueDescription.TabIndex = 7;
            txtIssueDescription.Text = "";
            // 
            // lblIssue
            // 
            lblIssue.AutoSize = true;
            lblIssue.Location = new Point(5, 92);
            lblIssue.Name = "lblIssue";
            lblIssue.Size = new Size(105, 17);
            lblIssue.TabIndex = 6;
            lblIssue.Text = "Issue Description";
            // 
            // txtMaintenanceCost
            // 
            txtMaintenanceCost.Location = new Point(6, 57);
            txtMaintenanceCost.Name = "txtMaintenanceCost";
            txtMaintenanceCost.Size = new Size(154, 24);
            txtMaintenanceCost.TabIndex = 3;
            // 
            // lblCost
            // 
            lblCost.AutoSize = true;
            lblCost.Location = new Point(6, 37);
            lblCost.Name = "lblCost";
            lblCost.Size = new Size(34, 17);
            lblCost.TabIndex = 2;
            lblCost.Text = "Cost";
            // 
            // btnConfirmReturn
            // 
            btnConfirmReturn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnConfirmReturn.BackColor = Color.FromArgb(217, 58, 102);
            btnConfirmReturn.FlatAppearance.BorderSize = 0;
            btnConfirmReturn.FlatStyle = FlatStyle.Flat;
            btnConfirmReturn.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfirmReturn.ForeColor = Color.White;
            btnConfirmReturn.Location = new Point(1012, 140);
            btnConfirmReturn.Name = "btnConfirmReturn";
            btnConfirmReturn.Size = new Size(150, 35);
            btnConfirmReturn.TabIndex = 0;
            btnConfirmReturn.Text = "Confirm Return";
            btnConfirmReturn.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.BackColor = Color.FromArgb(217, 58, 102);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(905, 150);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 35);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // CheckOut
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1211, 666);
            Controls.Add(mainPanel);
            Font = new Font("Berlin Sans FB", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "CheckOut";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Asset Return Management";
            mainPanel.ResumeLayout(false);
            mainLayout.ResumeLayout(false);
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            filterPanel.ResumeLayout(false);
            filterPanel.PerformLayout();
            dataPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAssignedAssets).EndInit();
            statusPanel.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            grpStatus.ResumeLayout(false);
            grpStatus.PerformLayout();
            grpMaintenance.ResumeLayout(false);
            grpMaintenance.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel filterPanel;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel dataPanel;
        private System.Windows.Forms.DataGridView dgvAssignedAssets;
        private System.Windows.Forms.Panel statusPanel;
        private System.Windows.Forms.GroupBox grpStatus;
        private System.Windows.Forms.RadioButton radRetired;
        private System.Windows.Forms.RadioButton radUnderMaintenance;
        private System.Windows.Forms.RadioButton radAvailable;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirmReturn;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox grpMaintenance;
        private TextBox txtMaintenanceCost;
        private Label lblCost;
        private RichTextBox txtIssueDescription;
        private Label lblIssue;
    }
}