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
            button6 = new Button();
            User = new Button();
            button2 = new Button();
            SideBar = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            DashboardBtn = new Button();
            AssetManagementBtn = new Button();
            AssetAssignmentBtn = new Button();
            MaintenanceBtn = new Button();
            UserManagementBtn = new Button();
            panel8 = new Panel();
            MainPanel = new Panel();
            SidePanelMain = new Panel();
            SidePanel = new Panel();
            panel3 = new Panel();
            button3 = new Button();
            NavigationBar.SuspendLayout();
            SideBar.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel8.SuspendLayout();
            SidePanelMain.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // NavigationBar
            // 
            NavigationBar.BackColor = Color.FromArgb(255, 79, 129);
            NavigationBar.Controls.Add(button6);
            NavigationBar.Controls.Add(User);
            NavigationBar.Controls.Add(button2);
            NavigationBar.Dock = DockStyle.Top;
            NavigationBar.Location = new Point(0, 0);
            NavigationBar.Name = "NavigationBar";
            NavigationBar.Size = new Size(1278, 82);
            NavigationBar.TabIndex = 0;
            // 
            // button6
            // 
            button6.BackgroundImage = (Image)resources.GetObject("button6.BackgroundImage");
            button6.BackgroundImageLayout = ImageLayout.Zoom;
            button6.Cursor = Cursors.Hand;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Location = new Point(22, 8);
            button6.Name = "button6";
            button6.Size = new Size(65, 63);
            button6.TabIndex = 3;
            button6.UseVisualStyleBackColor = false;
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
            User.Click += User_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(98, 8);
            button2.Name = "button2";
            button2.Size = new Size(386, 67);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = false;
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
            flowLayoutPanel1.Controls.Add(DashboardBtn);
            flowLayoutPanel1.Controls.Add(AssetManagementBtn);
            flowLayoutPanel1.Controls.Add(AssetAssignmentBtn);
            flowLayoutPanel1.Controls.Add(MaintenanceBtn);
            flowLayoutPanel1.Controls.Add(UserManagementBtn);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(231, 647);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // DashboardBtn
            // 
            DashboardBtn.BackColor = Color.Transparent;
            DashboardBtn.BackgroundImage = (Image)resources.GetObject("DashboardBtn.BackgroundImage");
            DashboardBtn.BackgroundImageLayout = ImageLayout.Stretch;
            DashboardBtn.Cursor = Cursors.Hand;
            DashboardBtn.FlatAppearance.BorderColor = Color.FromArgb(255, 79, 129);
            DashboardBtn.FlatAppearance.BorderSize = 0;
            DashboardBtn.FlatStyle = FlatStyle.Flat;
            DashboardBtn.Font = new Font("Berlin Sans FB Demi", 12F, FontStyle.Bold);
            DashboardBtn.ForeColor = Color.FromArgb(255, 79, 129);
            DashboardBtn.Location = new Point(15, 15);
            DashboardBtn.Margin = new Padding(15);
            DashboardBtn.Name = "DashboardBtn";
            DashboardBtn.Size = new Size(207, 62);
            DashboardBtn.TabIndex = 2;
            DashboardBtn.Text = "Dashboard";
            DashboardBtn.UseVisualStyleBackColor = false;
            DashboardBtn.Click += DashboardBtn_Click;
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
            AssetManagementBtn.Location = new Point(15, 107);
            AssetManagementBtn.Margin = new Padding(15);
            AssetManagementBtn.Name = "AssetManagementBtn";
            AssetManagementBtn.Size = new Size(207, 62);
            AssetManagementBtn.TabIndex = 1;
            AssetManagementBtn.Text = "Asset Management";
            AssetManagementBtn.UseVisualStyleBackColor = false;
            AssetManagementBtn.Click += AssetManagementBtn_Click;
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
            AssetAssignmentBtn.Location = new Point(15, 199);
            AssetAssignmentBtn.Margin = new Padding(15);
            AssetAssignmentBtn.Name = "AssetAssignmentBtn";
            AssetAssignmentBtn.Size = new Size(207, 62);
            AssetAssignmentBtn.TabIndex = 0;
            AssetAssignmentBtn.Text = "Asset Assignment";
            AssetAssignmentBtn.UseVisualStyleBackColor = false;
            AssetAssignmentBtn.Click += AssetAssignmentBtn_Click;
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
            MaintenanceBtn.Location = new Point(15, 291);
            MaintenanceBtn.Margin = new Padding(15);
            MaintenanceBtn.Name = "MaintenanceBtn";
            MaintenanceBtn.Size = new Size(207, 62);
            MaintenanceBtn.TabIndex = 3;
            MaintenanceBtn.Text = "Maintenance";
            MaintenanceBtn.UseVisualStyleBackColor = false;
            MaintenanceBtn.Click += MaintenanceBtn_Click;
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
            UserManagementBtn.Location = new Point(15, 383);
            UserManagementBtn.Margin = new Padding(15);
            UserManagementBtn.Name = "UserManagementBtn";
            UserManagementBtn.Size = new Size(207, 62);
            UserManagementBtn.TabIndex = 4;
            UserManagementBtn.Text = "User Management";
            UserManagementBtn.UseVisualStyleBackColor = false;
            UserManagementBtn.Click += UserManagementBtn_Click;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(255, 211, 220);
            panel8.Controls.Add(MainPanel);
            panel8.Controls.Add(SidePanelMain);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(231, 82);
            panel8.Name = "panel8";
            panel8.Size = new Size(1047, 647);
            panel8.TabIndex = 3;
            // 
            // MainPanel
            // 
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(762, 647);
            MainPanel.TabIndex = 3;
            // 
            // SidePanelMain
            // 
            SidePanelMain.Controls.Add(SidePanel);
            SidePanelMain.Controls.Add(panel3);
            SidePanelMain.Dock = DockStyle.Right;
            SidePanelMain.Location = new Point(762, 0);
            SidePanelMain.Name = "SidePanelMain";
            SidePanelMain.Size = new Size(285, 647);
            SidePanelMain.TabIndex = 2;
            // 
            // SidePanel
            // 
            SidePanel.BackColor = Color.FromArgb(255, 211, 220);
            SidePanel.Dock = DockStyle.Fill;
            SidePanel.Location = new Point(0, 41);
            SidePanel.Name = "SidePanel";
            SidePanel.Size = new Size(285, 606);
            SidePanel.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 246, 249);
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.Controls.Add(button3);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(285, 41);
            panel3.TabIndex = 0;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.BackgroundImage = Properties.Resources.close;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderColor = Color.FromArgb(255, 79, 129);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Berlin Sans FB Demi", 12F, FontStyle.Bold);
            button3.ForeColor = Color.FromArgb(255, 79, 129);
            button3.Location = new Point(254, 9);
            button3.Margin = new Padding(10, 11, 10, 11);
            button3.Name = "button3";
            button3.Size = new Size(20, 20);
            button3.TabIndex = 9;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
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
            SideBar.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panel8.ResumeLayout(false);
            SidePanelMain.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel NavigationBar;
        private Panel SideBar;
        private Button DashboardBtn;
        private Button button2;
        private Button AssetAssignmentBtn;
        private Button AssetManagementBtn;
        private Button MaintenanceBtn;
        private Button User;
        private Button UserManagementBtn;
        private Button button6;
        private Panel panel8;
        private Panel SidePanelMain;
        private Panel panel3;
        private Panel SidePanel;
        private Button button3;
        private Panel MainPanel;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
