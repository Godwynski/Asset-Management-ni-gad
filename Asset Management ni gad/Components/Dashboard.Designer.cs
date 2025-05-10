namespace Asset_Management_ni_gad
{
    partial class Dashboard
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
            Panel panelHeader;
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btnRefresh = new Button();
            lblTitle = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            statTotalAssets = new Panel();
            lblTotalAssetsValue = new Label();
            lblTotalAssets = new Label();
            statAssignedAssets = new Panel();
            lblAssignedAssetsValue = new Label();
            lblAssignedAssets = new Label();
            statUnderMaintenance = new Panel();
            lblUnderMaintenanceValue = new Label();
            lblUnderMaintenance = new Label();
            statRetiredAssets = new Panel();
            lblRetiredAssetsValue = new Label();
            lblRetiredAssets = new Label();
            statTotalUsers = new Panel();
            lblTotalUsersValue = new Label();
            lblTotalUsers = new Label();
            statAvailableAssets = new Panel();
            lblAvailableAssetsValue = new Label();
            lblAvailableAssets = new Label();
            statPendingMaintenance = new Panel();
            lblPendingMaintenanceValue = new Label();
            lblPendingMaintenance = new Label();
            statActiveAssignments = new Panel();
            lblActiveAssignmentsValue = new Label();
            lblActiveAssignments = new Label();
            panelAssetValue = new Panel();
            lblTotalAssetValue = new Label();
            lblTotalAssetValueTitle = new Label();
            panelRecentActivity = new Panel();
            dataGridViewRecentActivity = new DataGridView();
            lblRecentActivity = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1 = new Panel();
            panelHeader = new Panel();
            panelHeader.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            statTotalAssets.SuspendLayout();
            statAssignedAssets.SuspendLayout();
            statUnderMaintenance.SuspendLayout();
            statRetiredAssets.SuspendLayout();
            statTotalUsers.SuspendLayout();
            statAvailableAssets.SuspendLayout();
            statPendingMaintenance.SuspendLayout();
            statActiveAssignments.SuspendLayout();
            panelAssetValue.SuspendLayout();
            panelRecentActivity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecentActivity).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(btnRefresh);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Fill;
            panelHeader.Location = new Point(3, 3);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1210, 60);
            panelHeader.TabIndex = 0;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(255, 79, 129);
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Berlin Sans FB", 12F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(1051, 9);
            btnRefresh.Margin = new Padding(10);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(150, 40);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "REFRESH DATA";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Visible = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Berlin Sans FB", 18F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(217, 58, 102);
            lblTitle.Location = new Point(12, 16);
            lblTitle.Margin = new Padding(10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(226, 26);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Maintenance Records";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(statTotalAssets, 0, 0);
            tableLayoutPanel1.Controls.Add(statAssignedAssets, 1, 0);
            tableLayoutPanel1.Controls.Add(statUnderMaintenance, 2, 0);
            tableLayoutPanel1.Controls.Add(statRetiredAssets, 3, 0);
            tableLayoutPanel1.Controls.Add(statTotalUsers, 0, 1);
            tableLayoutPanel1.Controls.Add(statAvailableAssets, 1, 1);
            tableLayoutPanel1.Controls.Add(statPendingMaintenance, 2, 1);
            tableLayoutPanel1.Controls.Add(statActiveAssignments, 3, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 69);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1210, 251);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // statTotalAssets
            // 
            statTotalAssets.BackColor = Color.White;
            statTotalAssets.BorderStyle = BorderStyle.FixedSingle;
            statTotalAssets.Controls.Add(lblTotalAssetsValue);
            statTotalAssets.Controls.Add(lblTotalAssets);
            statTotalAssets.Dock = DockStyle.Fill;
            statTotalAssets.Location = new Point(10, 10);
            statTotalAssets.Margin = new Padding(10);
            statTotalAssets.Name = "statTotalAssets";
            statTotalAssets.Size = new Size(282, 105);
            statTotalAssets.TabIndex = 0;
            // 
            // lblTotalAssetsValue
            // 
            lblTotalAssetsValue.AutoSize = true;
            lblTotalAssetsValue.Font = new Font("Berlin Sans FB", 24F, FontStyle.Bold);
            lblTotalAssetsValue.ForeColor = Color.FromArgb(255, 79, 129);
            lblTotalAssetsValue.Location = new Point(20, 50);
            lblTotalAssetsValue.Name = "lblTotalAssetsValue";
            lblTotalAssetsValue.Size = new Size(38, 40);
            lblTotalAssetsValue.TabIndex = 1;
            lblTotalAssetsValue.Text = "0";
            // 
            // lblTotalAssets
            // 
            lblTotalAssets.AutoSize = true;
            lblTotalAssets.Font = new Font("Berlin Sans FB", 12F);
            lblTotalAssets.ForeColor = Color.FromArgb(217, 58, 102);
            lblTotalAssets.Location = new Point(20, 20);
            lblTotalAssets.Name = "lblTotalAssets";
            lblTotalAssets.Size = new Size(84, 18);
            lblTotalAssets.TabIndex = 0;
            lblTotalAssets.Text = "Total Assets";
            // 
            // statAssignedAssets
            // 
            statAssignedAssets.BackColor = Color.White;
            statAssignedAssets.BorderStyle = BorderStyle.FixedSingle;
            statAssignedAssets.Controls.Add(lblAssignedAssetsValue);
            statAssignedAssets.Controls.Add(lblAssignedAssets);
            statAssignedAssets.Dock = DockStyle.Fill;
            statAssignedAssets.Location = new Point(312, 10);
            statAssignedAssets.Margin = new Padding(10);
            statAssignedAssets.Name = "statAssignedAssets";
            statAssignedAssets.Size = new Size(282, 105);
            statAssignedAssets.TabIndex = 1;
            // 
            // lblAssignedAssetsValue
            // 
            lblAssignedAssetsValue.AutoSize = true;
            lblAssignedAssetsValue.Font = new Font("Berlin Sans FB", 24F, FontStyle.Bold);
            lblAssignedAssetsValue.ForeColor = Color.FromArgb(255, 79, 129);
            lblAssignedAssetsValue.Location = new Point(20, 50);
            lblAssignedAssetsValue.Name = "lblAssignedAssetsValue";
            lblAssignedAssetsValue.Size = new Size(38, 40);
            lblAssignedAssetsValue.TabIndex = 1;
            lblAssignedAssetsValue.Text = "0";
            // 
            // lblAssignedAssets
            // 
            lblAssignedAssets.AutoSize = true;
            lblAssignedAssets.Font = new Font("Berlin Sans FB", 12F);
            lblAssignedAssets.ForeColor = Color.FromArgb(217, 58, 102);
            lblAssignedAssets.Location = new Point(20, 20);
            lblAssignedAssets.Name = "lblAssignedAssets";
            lblAssignedAssets.Size = new Size(108, 18);
            lblAssignedAssets.TabIndex = 0;
            lblAssignedAssets.Text = "Assigned Assets";
            // 
            // statUnderMaintenance
            // 
            statUnderMaintenance.BackColor = Color.White;
            statUnderMaintenance.BorderStyle = BorderStyle.FixedSingle;
            statUnderMaintenance.Controls.Add(lblUnderMaintenanceValue);
            statUnderMaintenance.Controls.Add(lblUnderMaintenance);
            statUnderMaintenance.Dock = DockStyle.Fill;
            statUnderMaintenance.Location = new Point(614, 10);
            statUnderMaintenance.Margin = new Padding(10);
            statUnderMaintenance.Name = "statUnderMaintenance";
            statUnderMaintenance.Size = new Size(282, 105);
            statUnderMaintenance.TabIndex = 2;
            // 
            // lblUnderMaintenanceValue
            // 
            lblUnderMaintenanceValue.AutoSize = true;
            lblUnderMaintenanceValue.Font = new Font("Berlin Sans FB", 24F, FontStyle.Bold);
            lblUnderMaintenanceValue.ForeColor = Color.FromArgb(255, 79, 129);
            lblUnderMaintenanceValue.Location = new Point(20, 50);
            lblUnderMaintenanceValue.Name = "lblUnderMaintenanceValue";
            lblUnderMaintenanceValue.Size = new Size(38, 40);
            lblUnderMaintenanceValue.TabIndex = 1;
            lblUnderMaintenanceValue.Text = "0";
            // 
            // lblUnderMaintenance
            // 
            lblUnderMaintenance.AutoSize = true;
            lblUnderMaintenance.Font = new Font("Berlin Sans FB", 12F);
            lblUnderMaintenance.ForeColor = Color.FromArgb(217, 58, 102);
            lblUnderMaintenance.Location = new Point(20, 20);
            lblUnderMaintenance.Name = "lblUnderMaintenance";
            lblUnderMaintenance.Size = new Size(136, 18);
            lblUnderMaintenance.TabIndex = 0;
            lblUnderMaintenance.Text = "Under Maintenance";
            // 
            // statRetiredAssets
            // 
            statRetiredAssets.BackColor = Color.White;
            statRetiredAssets.BorderStyle = BorderStyle.FixedSingle;
            statRetiredAssets.Controls.Add(lblRetiredAssetsValue);
            statRetiredAssets.Controls.Add(lblRetiredAssets);
            statRetiredAssets.Dock = DockStyle.Fill;
            statRetiredAssets.Location = new Point(916, 10);
            statRetiredAssets.Margin = new Padding(10);
            statRetiredAssets.Name = "statRetiredAssets";
            statRetiredAssets.Size = new Size(284, 105);
            statRetiredAssets.TabIndex = 3;
            // 
            // lblRetiredAssetsValue
            // 
            lblRetiredAssetsValue.AutoSize = true;
            lblRetiredAssetsValue.Font = new Font("Berlin Sans FB", 24F, FontStyle.Bold);
            lblRetiredAssetsValue.ForeColor = Color.FromArgb(255, 79, 129);
            lblRetiredAssetsValue.Location = new Point(20, 50);
            lblRetiredAssetsValue.Name = "lblRetiredAssetsValue";
            lblRetiredAssetsValue.Size = new Size(38, 40);
            lblRetiredAssetsValue.TabIndex = 1;
            lblRetiredAssetsValue.Text = "0";
            // 
            // lblRetiredAssets
            // 
            lblRetiredAssets.AutoSize = true;
            lblRetiredAssets.Font = new Font("Berlin Sans FB", 12F);
            lblRetiredAssets.ForeColor = Color.FromArgb(217, 58, 102);
            lblRetiredAssets.Location = new Point(20, 20);
            lblRetiredAssets.Name = "lblRetiredAssets";
            lblRetiredAssets.Size = new Size(99, 18);
            lblRetiredAssets.TabIndex = 0;
            lblRetiredAssets.Text = "Retired Assets";
            // 
            // statTotalUsers
            // 
            statTotalUsers.BackColor = Color.White;
            statTotalUsers.BorderStyle = BorderStyle.FixedSingle;
            statTotalUsers.Controls.Add(lblTotalUsersValue);
            statTotalUsers.Controls.Add(lblTotalUsers);
            statTotalUsers.Dock = DockStyle.Fill;
            statTotalUsers.Location = new Point(10, 135);
            statTotalUsers.Margin = new Padding(10);
            statTotalUsers.Name = "statTotalUsers";
            statTotalUsers.Size = new Size(282, 106);
            statTotalUsers.TabIndex = 4;
            // 
            // lblTotalUsersValue
            // 
            lblTotalUsersValue.AutoSize = true;
            lblTotalUsersValue.Font = new Font("Berlin Sans FB", 24F, FontStyle.Bold);
            lblTotalUsersValue.ForeColor = Color.FromArgb(255, 79, 129);
            lblTotalUsersValue.Location = new Point(20, 50);
            lblTotalUsersValue.Name = "lblTotalUsersValue";
            lblTotalUsersValue.Size = new Size(38, 40);
            lblTotalUsersValue.TabIndex = 1;
            lblTotalUsersValue.Text = "0";
            // 
            // lblTotalUsers
            // 
            lblTotalUsers.AutoSize = true;
            lblTotalUsers.Font = new Font("Berlin Sans FB", 12F);
            lblTotalUsers.ForeColor = Color.FromArgb(217, 58, 102);
            lblTotalUsers.Location = new Point(20, 20);
            lblTotalUsers.Name = "lblTotalUsers";
            lblTotalUsers.Size = new Size(79, 18);
            lblTotalUsers.TabIndex = 0;
            lblTotalUsers.Text = "Total Users";
            // 
            // statAvailableAssets
            // 
            statAvailableAssets.BackColor = Color.White;
            statAvailableAssets.BorderStyle = BorderStyle.FixedSingle;
            statAvailableAssets.Controls.Add(lblAvailableAssetsValue);
            statAvailableAssets.Controls.Add(lblAvailableAssets);
            statAvailableAssets.Dock = DockStyle.Fill;
            statAvailableAssets.Location = new Point(312, 135);
            statAvailableAssets.Margin = new Padding(10);
            statAvailableAssets.Name = "statAvailableAssets";
            statAvailableAssets.Size = new Size(282, 106);
            statAvailableAssets.TabIndex = 5;
            // 
            // lblAvailableAssetsValue
            // 
            lblAvailableAssetsValue.AutoSize = true;
            lblAvailableAssetsValue.Font = new Font("Berlin Sans FB", 24F, FontStyle.Bold);
            lblAvailableAssetsValue.ForeColor = Color.FromArgb(255, 79, 129);
            lblAvailableAssetsValue.Location = new Point(20, 50);
            lblAvailableAssetsValue.Name = "lblAvailableAssetsValue";
            lblAvailableAssetsValue.Size = new Size(38, 40);
            lblAvailableAssetsValue.TabIndex = 1;
            lblAvailableAssetsValue.Text = "0";
            // 
            // lblAvailableAssets
            // 
            lblAvailableAssets.AutoSize = true;
            lblAvailableAssets.Font = new Font("Berlin Sans FB", 12F);
            lblAvailableAssets.ForeColor = Color.FromArgb(217, 58, 102);
            lblAvailableAssets.Location = new Point(20, 20);
            lblAvailableAssets.Name = "lblAvailableAssets";
            lblAvailableAssets.Size = new Size(113, 18);
            lblAvailableAssets.TabIndex = 0;
            lblAvailableAssets.Text = "Available Assets";
            // 
            // statPendingMaintenance
            // 
            statPendingMaintenance.BackColor = Color.White;
            statPendingMaintenance.BorderStyle = BorderStyle.FixedSingle;
            statPendingMaintenance.Controls.Add(lblPendingMaintenanceValue);
            statPendingMaintenance.Controls.Add(lblPendingMaintenance);
            statPendingMaintenance.Dock = DockStyle.Fill;
            statPendingMaintenance.Location = new Point(614, 135);
            statPendingMaintenance.Margin = new Padding(10);
            statPendingMaintenance.Name = "statPendingMaintenance";
            statPendingMaintenance.Size = new Size(282, 106);
            statPendingMaintenance.TabIndex = 6;
            // 
            // lblPendingMaintenanceValue
            // 
            lblPendingMaintenanceValue.AutoSize = true;
            lblPendingMaintenanceValue.Font = new Font("Berlin Sans FB", 24F, FontStyle.Bold);
            lblPendingMaintenanceValue.ForeColor = Color.FromArgb(255, 79, 129);
            lblPendingMaintenanceValue.Location = new Point(20, 50);
            lblPendingMaintenanceValue.Name = "lblPendingMaintenanceValue";
            lblPendingMaintenanceValue.Size = new Size(38, 40);
            lblPendingMaintenanceValue.TabIndex = 1;
            lblPendingMaintenanceValue.Text = "0";
            // 
            // lblPendingMaintenance
            // 
            lblPendingMaintenance.AutoSize = true;
            lblPendingMaintenance.Font = new Font("Berlin Sans FB", 12F);
            lblPendingMaintenance.ForeColor = Color.FromArgb(217, 58, 102);
            lblPendingMaintenance.Location = new Point(20, 20);
            lblPendingMaintenance.Name = "lblPendingMaintenance";
            lblPendingMaintenance.Size = new Size(149, 18);
            lblPendingMaintenance.TabIndex = 0;
            lblPendingMaintenance.Text = "Pending Maintenance";
            // 
            // statActiveAssignments
            // 
            statActiveAssignments.BackColor = Color.White;
            statActiveAssignments.BorderStyle = BorderStyle.FixedSingle;
            statActiveAssignments.Controls.Add(lblActiveAssignmentsValue);
            statActiveAssignments.Controls.Add(lblActiveAssignments);
            statActiveAssignments.Dock = DockStyle.Fill;
            statActiveAssignments.Location = new Point(916, 135);
            statActiveAssignments.Margin = new Padding(10);
            statActiveAssignments.Name = "statActiveAssignments";
            statActiveAssignments.Size = new Size(284, 106);
            statActiveAssignments.TabIndex = 7;
            // 
            // lblActiveAssignmentsValue
            // 
            lblActiveAssignmentsValue.AutoSize = true;
            lblActiveAssignmentsValue.Font = new Font("Berlin Sans FB", 24F, FontStyle.Bold);
            lblActiveAssignmentsValue.ForeColor = Color.FromArgb(255, 79, 129);
            lblActiveAssignmentsValue.Location = new Point(20, 50);
            lblActiveAssignmentsValue.Name = "lblActiveAssignmentsValue";
            lblActiveAssignmentsValue.Size = new Size(38, 40);
            lblActiveAssignmentsValue.TabIndex = 1;
            lblActiveAssignmentsValue.Text = "0";
            // 
            // lblActiveAssignments
            // 
            lblActiveAssignments.AutoSize = true;
            lblActiveAssignments.Font = new Font("Berlin Sans FB", 12F);
            lblActiveAssignments.ForeColor = Color.FromArgb(217, 58, 102);
            lblActiveAssignments.Location = new Point(20, 20);
            lblActiveAssignments.Name = "lblActiveAssignments";
            lblActiveAssignments.Size = new Size(131, 18);
            lblActiveAssignments.TabIndex = 0;
            lblActiveAssignments.Text = "Active Assignments";
            // 
            // panelAssetValue
            // 
            panelAssetValue.BackColor = Color.Transparent;
            panelAssetValue.BorderStyle = BorderStyle.FixedSingle;
            panelAssetValue.Controls.Add(lblTotalAssetValue);
            panelAssetValue.Controls.Add(lblTotalAssetValueTitle);
            panelAssetValue.Dock = DockStyle.Fill;
            panelAssetValue.ForeColor = Color.Transparent;
            panelAssetValue.Location = new Point(0, 0);
            panelAssetValue.Margin = new Padding(10);
            panelAssetValue.Name = "panelAssetValue";
            panelAssetValue.Size = new Size(1210, 91);
            panelAssetValue.TabIndex = 2;
            // 
            // lblTotalAssetValue
            // 
            lblTotalAssetValue.AutoSize = true;
            lblTotalAssetValue.BackColor = Color.Transparent;
            lblTotalAssetValue.Font = new Font("Berlin Sans FB", 24F, FontStyle.Bold);
            lblTotalAssetValue.ForeColor = Color.FromArgb(255, 79, 129);
            lblTotalAssetValue.Location = new Point(20, 40);
            lblTotalAssetValue.Margin = new Padding(10);
            lblTotalAssetValue.Name = "lblTotalAssetValue";
            lblTotalAssetValue.Size = new Size(108, 40);
            lblTotalAssetValue.TabIndex = 1;
            lblTotalAssetValue.Text = "$0.00";
            // 
            // lblTotalAssetValueTitle
            // 
            lblTotalAssetValueTitle.AutoSize = true;
            lblTotalAssetValueTitle.Font = new Font("Berlin Sans FB", 12F);
            lblTotalAssetValueTitle.ForeColor = Color.FromArgb(217, 58, 102);
            lblTotalAssetValueTitle.Location = new Point(20, 10);
            lblTotalAssetValueTitle.Margin = new Padding(10);
            lblTotalAssetValueTitle.Name = "lblTotalAssetValueTitle";
            lblTotalAssetValueTitle.Size = new Size(121, 18);
            lblTotalAssetValueTitle.TabIndex = 0;
            lblTotalAssetValueTitle.Text = "Total Asset Value";
            // 
            // panelRecentActivity
            // 
            panelRecentActivity.BackColor = Color.White;
            panelRecentActivity.BorderStyle = BorderStyle.FixedSingle;
            panelRecentActivity.Controls.Add(dataGridViewRecentActivity);
            panelRecentActivity.Controls.Add(lblRecentActivity);
            panelRecentActivity.Dock = DockStyle.Fill;
            panelRecentActivity.Location = new Point(10, 430);
            panelRecentActivity.Margin = new Padding(10);
            panelRecentActivity.Name = "panelRecentActivity";
            panelRecentActivity.Size = new Size(1196, 621);
            panelRecentActivity.TabIndex = 3;
            // 
            // dataGridViewRecentActivity
            // 
            dataGridViewRecentActivity.AllowUserToAddRows = false;
            dataGridViewRecentActivity.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 228, 235);
            dataGridViewRecentActivity.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewRecentActivity.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewRecentActivity.BackgroundColor = Color.FromArgb(255, 246, 249);
            dataGridViewRecentActivity.BorderStyle = BorderStyle.None;
            dataGridViewRecentActivity.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewRecentActivity.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(217, 58, 102);
            dataGridViewCellStyle2.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(217, 58, 102);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewRecentActivity.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewRecentActivity.ColumnHeadersHeight = 40;
            dataGridViewRecentActivity.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 246, 249);
            dataGridViewCellStyle3.Font = new Font("Berlin Sans FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.Padding = new Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 211, 220);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewRecentActivity.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewRecentActivity.Dock = DockStyle.Fill;
            dataGridViewRecentActivity.EnableHeadersVisualStyles = false;
            dataGridViewRecentActivity.GridColor = Color.FromArgb(255, 211, 220);
            dataGridViewRecentActivity.Location = new Point(0, 23);
            dataGridViewRecentActivity.Name = "dataGridViewRecentActivity";
            dataGridViewRecentActivity.ReadOnly = true;
            dataGridViewRecentActivity.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewRecentActivity.RowHeadersVisible = false;
            dataGridViewRecentActivity.RowTemplate.Height = 35;
            dataGridViewRecentActivity.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewRecentActivity.Size = new Size(1194, 596);
            dataGridViewRecentActivity.TabIndex = 2;
            // 
            // lblRecentActivity
            // 
            lblRecentActivity.AutoSize = true;
            lblRecentActivity.Dock = DockStyle.Top;
            lblRecentActivity.Font = new Font("Berlin Sans FB", 14F, FontStyle.Bold);
            lblRecentActivity.ForeColor = Color.FromArgb(51, 51, 51);
            lblRecentActivity.Location = new Point(0, 0);
            lblRecentActivity.Name = "lblRecentActivity";
            lblRecentActivity.Size = new Size(150, 23);
            lblRecentActivity.TabIndex = 1;
            lblRecentActivity.Text = "Recent Activity";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(panelHeader, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 1);
            tableLayoutPanel2.Controls.Add(panelRecentActivity, 0, 3);
            tableLayoutPanel2.Controls.Add(panel1, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 66F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 257F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 97F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1216, 1061);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Controls.Add(panelAssetValue);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 326);
            panel1.Name = "panel1";
            panel1.Size = new Size(1210, 91);
            panel1.TabIndex = 4;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(255, 211, 220);
            ClientSize = new Size(1216, 1061);
            Controls.Add(tableLayoutPanel2);
            Name = "Dashboard";
            Text = "Dashboard";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            statTotalAssets.ResumeLayout(false);
            statTotalAssets.PerformLayout();
            statAssignedAssets.ResumeLayout(false);
            statAssignedAssets.PerformLayout();
            statUnderMaintenance.ResumeLayout(false);
            statUnderMaintenance.PerformLayout();
            statRetiredAssets.ResumeLayout(false);
            statRetiredAssets.PerformLayout();
            statTotalUsers.ResumeLayout(false);
            statTotalUsers.PerformLayout();
            statAvailableAssets.ResumeLayout(false);
            statAvailableAssets.PerformLayout();
            statPendingMaintenance.ResumeLayout(false);
            statPendingMaintenance.PerformLayout();
            statActiveAssignments.ResumeLayout(false);
            statActiveAssignments.PerformLayout();
            panelAssetValue.ResumeLayout(false);
            panelAssetValue.PerformLayout();
            panelRecentActivity.ResumeLayout(false);
            panelRecentActivity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecentActivity).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelHeader;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel statTotalAssets;
        private Label lblTotalAssetsValue;
        private Label lblTotalAssets;
        private Panel statAssignedAssets;
        private Label lblAssignedAssetsValue;
        private Label lblAssignedAssets;
        private Panel statUnderMaintenance;
        private Label lblUnderMaintenanceValue;
        private Label lblUnderMaintenance;
        private Panel statRetiredAssets;
        private Label lblRetiredAssetsValue;
        private Label lblRetiredAssets;
        private Panel statTotalUsers;
        private Label lblTotalUsersValue;
        private Label lblTotalUsers;
        private Panel statAvailableAssets;
        private Label lblAvailableAssetsValue;
        private Label lblAvailableAssets;
        private Panel statPendingMaintenance;
        private Label lblPendingMaintenanceValue;
        private Label lblPendingMaintenance;
        private Panel statActiveAssignments;
        private Label lblActiveAssignmentsValue;
        private Label lblActiveAssignments;
        private Panel panelRecentActivity;
        private Label lblRecentActivity;
        private Button btnRefresh;
        private Panel panelAssetValue;
        private Label lblTotalAssetValue;
        private Label lblTotalAssetValueTitle;
        private Label lblTitle;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private DataGridView dataGridViewRecentActivity;
    }
}