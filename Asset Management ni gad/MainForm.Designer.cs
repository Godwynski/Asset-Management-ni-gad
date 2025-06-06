namespace Asset_Management_ni_gad
{
    partial class MainForm
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            NavigationBar = new Panel();
            lblRecentActivity = new Label();
            User = new Button();
            SideBar = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            AssetAssignmentBtn = new Button();
            AssetReturnBtn = new Button();
            UserManagementBtn = new Button();
            AssetManagementBtn = new Button();
            MaintenanceBtn = new Button();
            panel8 = new Panel();
            MainPanel = new Panel();
            NavigationBar.SuspendLayout();
            SideBar.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // NavigationBar
            // 
            NavigationBar.BackColor = Color.FromArgb(255, 79, 129);
            NavigationBar.Controls.Add(lblRecentActivity);
            NavigationBar.Controls.Add(User);
            NavigationBar.Dock = DockStyle.Top;
            NavigationBar.Location = new Point(0, 0);
            NavigationBar.Name = "NavigationBar";
            NavigationBar.Size = new Size(1278, 82);
            NavigationBar.TabIndex = 0;
            // 
            // lblRecentActivity
            // 
            lblRecentActivity.Anchor = AnchorStyles.None;
            lblRecentActivity.AutoSize = true;
            lblRecentActivity.Font = new Font("Berlin Sans FB", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecentActivity.ForeColor = Color.White;
            lblRecentActivity.Location = new Point(15, 21);
            lblRecentActivity.Name = "lblRecentActivity";
            lblRecentActivity.Size = new Size(173, 40);
            lblRecentActivity.TabIndex = 4;
            lblRecentActivity.Text = "RoomEase";
            // 
            // User
            // 
            User.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            User.BackColor = Color.Transparent;
            User.BackgroundImage = (Image)resources.GetObject("User.BackgroundImage");
            User.BackgroundImageLayout = ImageLayout.Zoom;
            User.Cursor = Cursors.Hand;
            User.FlatAppearance.BorderSize = 0;
            User.FlatAppearance.MouseDownBackColor = Color.Transparent;
            User.FlatAppearance.MouseOverBackColor = Color.Transparent;
            User.FlatStyle = FlatStyle.Flat;
            User.Location = new Point(1206, 12);
            User.Name = "User";
            User.Size = new Size(60, 56);
            User.TabIndex = 2;
            User.UseVisualStyleBackColor = false;
            // 
            // SideBar
            // 
            SideBar.BackColor = Color.FromArgb(255, 246, 249);
            SideBar.Controls.Add(flowLayoutPanel1);
            SideBar.Dock = DockStyle.Left;
            SideBar.Location = new Point(0, 82);
            SideBar.Name = "SideBar";
            SideBar.Size = new Size(231, 647);
            SideBar.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(AssetAssignmentBtn);
            flowLayoutPanel1.Controls.Add(UserManagementBtn);
            flowLayoutPanel1.Controls.Add(MaintenanceBtn);
            flowLayoutPanel1.Controls.Add(AssetManagementBtn);
            flowLayoutPanel1.Controls.Add(AssetReturnBtn);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(231, 647);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // AssetAssignmentBtn
            // 
            AssetAssignmentBtn.BackColor = Color.Transparent;
            AssetAssignmentBtn.BackgroundImage = (Image)resources.GetObject("AssetAssignmentBtn.BackgroundImage");
            AssetAssignmentBtn.BackgroundImageLayout = ImageLayout.Stretch;
            AssetAssignmentBtn.Cursor = Cursors.Hand;
            AssetAssignmentBtn.FlatAppearance.BorderColor = Color.FromArgb(255, 79, 129);
            AssetAssignmentBtn.FlatAppearance.BorderSize = 0;
            AssetAssignmentBtn.FlatStyle = FlatStyle.Flat;
            AssetAssignmentBtn.Font = new Font("Berlin Sans FB Demi", 12F, FontStyle.Bold);
            AssetAssignmentBtn.ForeColor = Color.FromArgb(255, 79, 129);
            AssetAssignmentBtn.Location = new Point(15, 15);
            AssetAssignmentBtn.Margin = new Padding(15);
            AssetAssignmentBtn.Name = "AssetAssignmentBtn";
            AssetAssignmentBtn.Size = new Size(207, 62);
            AssetAssignmentBtn.TabIndex = 0;
            AssetAssignmentBtn.Text = "Booking";
            AssetAssignmentBtn.UseVisualStyleBackColor = false;
            AssetAssignmentBtn.Click += AssetAssignmentBtn_Click;
            // 
            // AssetReturnBtn
            // 
            AssetReturnBtn.BackColor = Color.Transparent;
            AssetReturnBtn.BackgroundImage = (Image)resources.GetObject("AssetReturnBtn.BackgroundImage");
            AssetReturnBtn.BackgroundImageLayout = ImageLayout.Stretch;
            AssetReturnBtn.Cursor = Cursors.Hand;
            AssetReturnBtn.FlatAppearance.BorderColor = Color.FromArgb(255, 79, 129);
            AssetReturnBtn.FlatAppearance.BorderSize = 0;
            AssetReturnBtn.FlatStyle = FlatStyle.Flat;
            AssetReturnBtn.Font = new Font("Berlin Sans FB Demi", 12F, FontStyle.Bold);
            AssetReturnBtn.ForeColor = Color.FromArgb(255, 79, 129);
            AssetReturnBtn.Location = new Point(15, 383);
            AssetReturnBtn.Margin = new Padding(15);
            AssetReturnBtn.Name = "AssetReturnBtn";
            AssetReturnBtn.Size = new Size(207, 62);
            AssetReturnBtn.TabIndex = 5;
            AssetReturnBtn.Text = "Cleaning";
            AssetReturnBtn.UseVisualStyleBackColor = false;
            AssetReturnBtn.Click += AssetReturnBtn_Click;
            // 
            // UserManagementBtn
            // 
            UserManagementBtn.BackColor = Color.Transparent;
            UserManagementBtn.BackgroundImage = (Image)resources.GetObject("UserManagementBtn.BackgroundImage");
            UserManagementBtn.BackgroundImageLayout = ImageLayout.Stretch;
            UserManagementBtn.Cursor = Cursors.Hand;
            UserManagementBtn.FlatAppearance.BorderColor = Color.FromArgb(255, 79, 129);
            UserManagementBtn.FlatAppearance.BorderSize = 0;
            UserManagementBtn.FlatStyle = FlatStyle.Flat;
            UserManagementBtn.Font = new Font("Berlin Sans FB Demi", 12F, FontStyle.Bold);
            UserManagementBtn.ForeColor = Color.FromArgb(255, 79, 129);
            UserManagementBtn.Location = new Point(15, 107);
            UserManagementBtn.Margin = new Padding(15);
            UserManagementBtn.Name = "UserManagementBtn";
            UserManagementBtn.Size = new Size(207, 62);
            UserManagementBtn.TabIndex = 4;
            UserManagementBtn.Text = "Guest Management";
            UserManagementBtn.UseVisualStyleBackColor = false;
            UserManagementBtn.Click += UserManagementBtn_Click;
            // 
            // AssetManagementBtn
            // 
            AssetManagementBtn.BackColor = Color.Transparent;
            AssetManagementBtn.BackgroundImage = (Image)resources.GetObject("AssetManagementBtn.BackgroundImage");
            AssetManagementBtn.BackgroundImageLayout = ImageLayout.Stretch;
            AssetManagementBtn.Cursor = Cursors.Hand;
            AssetManagementBtn.FlatAppearance.BorderColor = Color.FromArgb(255, 79, 129);
            AssetManagementBtn.FlatAppearance.BorderSize = 0;
            AssetManagementBtn.FlatStyle = FlatStyle.Flat;
            AssetManagementBtn.Font = new Font("Berlin Sans FB Demi", 12F, FontStyle.Bold);
            AssetManagementBtn.ForeColor = Color.FromArgb(255, 79, 129);
            AssetManagementBtn.Location = new Point(15, 291);
            AssetManagementBtn.Margin = new Padding(15);
            AssetManagementBtn.Name = "AssetManagementBtn";
            AssetManagementBtn.Size = new Size(207, 62);
            AssetManagementBtn.TabIndex = 1;
            AssetManagementBtn.Text = "Employee Management";
            AssetManagementBtn.UseVisualStyleBackColor = false;
            AssetManagementBtn.Click += AssetManagementBtn_Click;
            // 
            // MaintenanceBtn
            // 
            MaintenanceBtn.BackColor = Color.Transparent;
            MaintenanceBtn.BackgroundImage = (Image)resources.GetObject("MaintenanceBtn.BackgroundImage");
            MaintenanceBtn.BackgroundImageLayout = ImageLayout.Stretch;
            MaintenanceBtn.Cursor = Cursors.Hand;
            MaintenanceBtn.FlatAppearance.BorderColor = Color.FromArgb(255, 79, 129);
            MaintenanceBtn.FlatAppearance.BorderSize = 0;
            MaintenanceBtn.FlatStyle = FlatStyle.Flat;
            MaintenanceBtn.Font = new Font("Berlin Sans FB Demi", 12F, FontStyle.Bold);
            MaintenanceBtn.ForeColor = Color.FromArgb(255, 79, 129);
            MaintenanceBtn.Location = new Point(15, 199);
            MaintenanceBtn.Margin = new Padding(15);
            MaintenanceBtn.Name = "MaintenanceBtn";
            MaintenanceBtn.Size = new Size(207, 62);
            MaintenanceBtn.TabIndex = 3;
            MaintenanceBtn.Text = "Room Management";
            MaintenanceBtn.UseVisualStyleBackColor = false;
            MaintenanceBtn.Click += MaintenanceBtn_Click;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(255, 211, 220);
            panel8.Controls.Add(MainPanel);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(231, 82);
            panel8.Name = "panel8";
            panel8.Size = new Size(1047, 647);
            panel8.TabIndex = 3;
            // 
            // MainPanel
            // 
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1047, 647);
            MainPanel.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 246, 249);
            ClientSize = new Size(1278, 729);
            Controls.Add(panel8);
            Controls.Add(SideBar);
            Controls.Add(NavigationBar);
            Font = new Font("Segoe UI", 10F);
            MinimumSize = new Size(1024, 768);
            Name = "MainForm";
            Text = "Office Asset Management";
            NavigationBar.ResumeLayout(false);
            NavigationBar.PerformLayout();
            SideBar.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panel8.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel NavigationBar;
        private Panel SideBar;
        private Button AssetAssignmentBtn;
        private Button AssetManagementBtn;
        private Button MaintenanceBtn;
        private Button User;
        private Button UserManagementBtn;
        private Panel panel8;
        private Panel MainPanel;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button AssetReturnBtn;
        private Label lblRecentActivity;
    }
}
