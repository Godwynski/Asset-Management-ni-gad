namespace Asset_Management_ni_gad
{
    partial class AssetReturn
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
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
            assetIdColumn = new DataGridViewTextBoxColumn();
            assetNameColumn = new DataGridViewTextBoxColumn();
            userColumn = new DataGridViewTextBoxColumn();
            assignedDateColumn = new DataGridViewTextBoxColumn();
            actionColumn = new DataGridViewButtonColumn();
            statusPanel = new Panel();
            grpMaintenance = new GroupBox();
            txtIssueDescription = new RichTextBox();
            lblIssue = new Label();
            txtMaintenanceCost = new TextBox();
            lblCost = new Label();
            grpStatus = new GroupBox();
            radRetired = new RadioButton();
            radUnderMaintenance = new RadioButton();
            radAvailable = new RadioButton();
            btnCancel = new Button();
            btnConfirmReturn = new Button();
            mainPanel.SuspendLayout();
            mainLayout.SuspendLayout();
            headerPanel.SuspendLayout();
            filterPanel.SuspendLayout();
            dataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAssignedAssets).BeginInit();
            statusPanel.SuspendLayout();
            grpMaintenance.SuspendLayout();
            grpStatus.SuspendLayout();
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
            mainPanel.Size = new Size(1203, 666);
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
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 38.6194038F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 61.3805962F));
            mainLayout.Size = new Size(1183, 646);
            mainLayout.TabIndex = 0;
            // 
            // headerPanel
            // 
            headerPanel.Controls.Add(lblTitle);
            headerPanel.Dock = DockStyle.Fill;
            headerPanel.Location = new Point(3, 3);
            headerPanel.Name = "headerPanel";
            headerPanel.Padding = new Padding(10, 5, 10, 5);
            headerPanel.Size = new Size(1177, 54);
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
            lblTitle.Size = new Size(146, 26);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Asset Returns";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
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
            filterPanel.Size = new Size(1177, 44);
            filterPanel.TabIndex = 1;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Font = new Font("Berlin Sans FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(10, 8);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search assigned assets...";
            txtSearch.Size = new Size(900, 24);
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
            btnRefresh.Location = new Point(1038, 7);
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
            btnSearch.Location = new Point(920, 8);
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
            dataPanel.Size = new Size(1177, 201);
            dataPanel.TabIndex = 2;
            // 
            // dgvAssignedAssets
            // 
            dgvAssignedAssets.AllowUserToAddRows = false;
            dgvAssignedAssets.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 228, 235);
            dgvAssignedAssets.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvAssignedAssets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAssignedAssets.BackgroundColor = Color.FromArgb(255, 246, 249);
            dgvAssignedAssets.BorderStyle = BorderStyle.None;
            dgvAssignedAssets.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAssignedAssets.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(217, 58, 102);
            dataGridViewCellStyle2.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(217, 58, 102);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvAssignedAssets.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvAssignedAssets.ColumnHeadersHeight = 40;
            dgvAssignedAssets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvAssignedAssets.Columns.AddRange(new DataGridViewColumn[] { assetIdColumn, assetNameColumn, userColumn, assignedDateColumn, actionColumn });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 246, 249);
            dataGridViewCellStyle3.Font = new Font("Berlin Sans FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.Padding = new Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 211, 220);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvAssignedAssets.DefaultCellStyle = dataGridViewCellStyle3;
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
            dgvAssignedAssets.Size = new Size(1157, 181);
            dgvAssignedAssets.TabIndex = 1;
            // 
            // assetIdColumn
            // 
            assetIdColumn.DataPropertyName = "asset_id";
            assetIdColumn.HeaderText = "Asset ID";
            assetIdColumn.Name = "assetIdColumn";
            assetIdColumn.ReadOnly = true;
            assetIdColumn.Visible = false;
            // 
            // assetNameColumn
            // 
            assetNameColumn.DataPropertyName = "asset_name";
            assetNameColumn.HeaderText = "Asset Name";
            assetNameColumn.Name = "assetNameColumn";
            assetNameColumn.ReadOnly = true;
            // 
            // userColumn
            // 
            userColumn.DataPropertyName = "full_name";
            userColumn.HeaderText = "Assigned To";
            userColumn.Name = "userColumn";
            userColumn.ReadOnly = true;
            // 
            // assignedDateColumn
            // 
            assignedDateColumn.DataPropertyName = "assigned_date";
            assignedDateColumn.HeaderText = "Assigned Date";
            assignedDateColumn.Name = "assignedDateColumn";
            assignedDateColumn.ReadOnly = true;
            // 
            // actionColumn
            // 
            actionColumn.HeaderText = "Action";
            actionColumn.Name = "actionColumn";
            actionColumn.ReadOnly = true;
            actionColumn.Text = "Return";
            actionColumn.UseColumnTextForButtonValue = true;
            // 
            // statusPanel
            // 
            statusPanel.Controls.Add(grpMaintenance);
            statusPanel.Controls.Add(grpStatus);
            statusPanel.Controls.Add(btnCancel);
            statusPanel.Controls.Add(btnConfirmReturn);
            statusPanel.Dock = DockStyle.Fill;
            statusPanel.Location = new Point(3, 320);
            statusPanel.Name = "statusPanel";
            statusPanel.Padding = new Padding(10);
            statusPanel.Size = new Size(1177, 323);
            statusPanel.TabIndex = 3;
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
            grpMaintenance.Location = new Point(500, 13);
            grpMaintenance.Name = "grpMaintenance";
            grpMaintenance.Size = new Size(400, 195);
            grpMaintenance.TabIndex = 3;
            grpMaintenance.TabStop = false;
            grpMaintenance.Text = "Maintenance Details";
            // 
            // txtIssueDescription
            // 
            txtIssueDescription.Location = new Point(1, 104);
            txtIssueDescription.Name = "txtIssueDescription";
            txtIssueDescription.Size = new Size(360, 60);
            txtIssueDescription.TabIndex = 5;
            txtIssueDescription.Text = "";
            // 
            // lblIssue
            // 
            lblIssue.AutoSize = true;
            lblIssue.Location = new Point(1, 84);
            lblIssue.Name = "lblIssue";
            lblIssue.Size = new Size(105, 17);
            lblIssue.TabIndex = 4;
            lblIssue.Text = "Issue Description";
            // 
            // txtMaintenanceCost
            // 
            txtMaintenanceCost.Location = new Point(6, 57);
            txtMaintenanceCost.Name = "txtMaintenanceCost";
            txtMaintenanceCost.Size = new Size(100, 24);
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
            // grpStatus
            // 
            grpStatus.Controls.Add(radRetired);
            grpStatus.Controls.Add(radUnderMaintenance);
            grpStatus.Controls.Add(radAvailable);
            grpStatus.Font = new Font("Berlin Sans FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpStatus.ForeColor = Color.FromArgb(217, 58, 102);
            grpStatus.Location = new Point(20, 13);
            grpStatus.Name = "grpStatus";
            grpStatus.Size = new Size(445, 173);
            grpStatus.TabIndex = 2;
            grpStatus.TabStop = false;
            grpStatus.Text = "Return Status";
            // 
            // radRetired
            // 
            radRetired.AutoSize = true;
            radRetired.Location = new Point(20, 100);
            radRetired.Name = "radRetired";
            radRetired.Size = new Size(70, 21);
            radRetired.TabIndex = 2;
            radRetired.TabStop = true;
            radRetired.Text = "Retired";
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
            radUnderMaintenance.CheckedChanged += radUnderMaintenance_CheckedChanged;
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
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.BackColor = Color.FromArgb(217, 58, 102);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(920, 275);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 35);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnConfirmReturn
            // 
            btnConfirmReturn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnConfirmReturn.BackColor = Color.FromArgb(217, 58, 102);
            btnConfirmReturn.FlatAppearance.BorderSize = 0;
            btnConfirmReturn.FlatStyle = FlatStyle.Flat;
            btnConfirmReturn.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfirmReturn.ForeColor = Color.White;
            btnConfirmReturn.Location = new Point(1020, 275);
            btnConfirmReturn.Name = "btnConfirmReturn";
            btnConfirmReturn.Size = new Size(150, 35);
            btnConfirmReturn.TabIndex = 0;
            btnConfirmReturn.Text = "Confirm Return";
            btnConfirmReturn.UseVisualStyleBackColor = false;
            // 
            // AssetReturn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1203, 666);
            Controls.Add(mainPanel);
            Font = new Font("Berlin Sans FB", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinimumSize = new Size(1000, 600);
            Name = "AssetReturn";
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
            grpMaintenance.ResumeLayout(false);
            grpMaintenance.PerformLayout();
            grpStatus.ResumeLayout(false);
            grpStatus.PerformLayout();
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
        private System.Windows.Forms.GroupBox grpMaintenance;
        private System.Windows.Forms.TextBox txtMaintenanceCost;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.GroupBox grpStatus;
        private System.Windows.Forms.RadioButton radRetired;
        private System.Windows.Forms.RadioButton radUnderMaintenance;
        private System.Windows.Forms.RadioButton radAvailable;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirmReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assetIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assetNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assignedDateColumn;
        private System.Windows.Forms.DataGridViewButtonColumn actionColumn;
        private RichTextBox txtIssueDescription;
        private Label lblIssue;
    }
}