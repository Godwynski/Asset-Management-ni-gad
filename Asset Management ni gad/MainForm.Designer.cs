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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            NavigationBar = new Panel();
            label1 = new Label();
            button6 = new Button();
            User = new Button();
            button2 = new Button();
            SideBar = new Panel();
            panel4 = new Panel();
            UserManagementBtn = new Button();
            panel1 = new Panel();
            MaintenanceBtn = new Button();
            panel6 = new Panel();
            AssetAssignmentBtn = new Button();
            panel5 = new Panel();
            AssetManagementBtn = new Button();
            panel2 = new Panel();
            DashboardBtn = new Button();
            panel7 = new Panel();
            panel8 = new Panel();
            MainPanel = new Panel();
            SidePanelMain = new Panel();
            SidePanel = new Panel();
            panel3 = new Panel();
            button3 = new Button();
            NavigationBar.SuspendLayout();
            SideBar.SuspendLayout();
            panel8.SuspendLayout();
            SidePanelMain.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // NavigationBar
            // 
            NavigationBar.BackColor = Color.FromArgb(255, 79, 129);
            NavigationBar.Controls.Add(label1);
            NavigationBar.Controls.Add(button6);
            NavigationBar.Controls.Add(User);
            NavigationBar.Controls.Add(button2);
            NavigationBar.Dock = DockStyle.Top;
            NavigationBar.Location = new Point(0, 0);
            NavigationBar.Name = "NavigationBar";
            NavigationBar.Size = new Size(1127, 72);
            NavigationBar.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Berlin Sans FB Demi", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(255, 246, 249);
            label1.Location = new Point(790, 36);
            label1.Name = "label1";
            label1.Size = new Size(28, 18);
            label1.TabIndex = 4;
            label1.Text = "     ";
            // 
            // button6
            // 
            button6.BackgroundImage = (Image)resources.GetObject("button6.BackgroundImage");
            button6.BackgroundImageLayout = ImageLayout.Zoom;
            button6.Cursor = Cursors.Hand;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Location = new Point(22, 7);
            button6.Name = "button6";
            button6.Size = new Size(65, 56);
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
            User.Location = new Point(1055, 11);
            User.Name = "User";
            User.Size = new Size(60, 49);
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
            button2.Location = new Point(98, 7);
            button2.Name = "button2";
            button2.Size = new Size(386, 59);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = false;
            // 
            // SideBar
            // 
            SideBar.BackColor = Color.FromArgb(255, 246, 249);
            SideBar.Controls.Add(panel4);
            SideBar.Controls.Add(UserManagementBtn);
            SideBar.Controls.Add(panel1);
            SideBar.Controls.Add(MaintenanceBtn);
            SideBar.Controls.Add(panel6);
            SideBar.Controls.Add(AssetAssignmentBtn);
            SideBar.Controls.Add(panel5);
            SideBar.Controls.Add(AssetManagementBtn);
            SideBar.Controls.Add(panel2);
            SideBar.Controls.Add(DashboardBtn);
            SideBar.Controls.Add(panel7);
            SideBar.Dock = DockStyle.Left;
            SideBar.Location = new Point(0, 72);
            SideBar.Name = "SideBar";
            SideBar.Size = new Size(207, 669);
            SideBar.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 455);
            panel4.Name = "panel4";
            panel4.Size = new Size(207, 36);
            panel4.TabIndex = 8;
            // 
            // UserManagementBtn
            // 
            UserManagementBtn.BackColor = Color.Transparent;
            UserManagementBtn.BackgroundImage = (Image)resources.GetObject("UserManagementBtn.BackgroundImage");
            UserManagementBtn.BackgroundImageLayout = ImageLayout.Stretch;
            UserManagementBtn.Cursor = Cursors.Hand;
            UserManagementBtn.Dock = DockStyle.Top;
            UserManagementBtn.FlatAppearance.BorderColor = Color.FromArgb(255, 79, 129);
            UserManagementBtn.FlatAppearance.BorderSize = 0;
            UserManagementBtn.FlatStyle = FlatStyle.Flat;
            UserManagementBtn.Font = new Font("Berlin Sans FB Demi", 12F, FontStyle.Bold);
            UserManagementBtn.ForeColor = Color.FromArgb(255, 79, 129);
            UserManagementBtn.Location = new Point(0, 400);
            UserManagementBtn.Margin = new Padding(10);
            UserManagementBtn.Name = "UserManagementBtn";
            UserManagementBtn.Size = new Size(207, 55);
            UserManagementBtn.TabIndex = 4;
            UserManagementBtn.Text = "User Management";
            UserManagementBtn.UseVisualStyleBackColor = false;
            UserManagementBtn.Click += UserManagementBtn_Click;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 364);
            panel1.Name = "panel1";
            panel1.Size = new Size(207, 36);
            panel1.TabIndex = 5;
            // 
            // MaintenanceBtn
            // 
            MaintenanceBtn.BackColor = Color.Transparent;
            MaintenanceBtn.BackgroundImage = (Image)resources.GetObject("MaintenanceBtn.BackgroundImage");
            MaintenanceBtn.BackgroundImageLayout = ImageLayout.Stretch;
            MaintenanceBtn.Cursor = Cursors.Hand;
            MaintenanceBtn.Dock = DockStyle.Top;
            MaintenanceBtn.FlatAppearance.BorderColor = Color.FromArgb(255, 79, 129);
            MaintenanceBtn.FlatAppearance.BorderSize = 0;
            MaintenanceBtn.FlatStyle = FlatStyle.Flat;
            MaintenanceBtn.Font = new Font("Berlin Sans FB Demi", 12F, FontStyle.Bold);
            MaintenanceBtn.ForeColor = Color.FromArgb(255, 79, 129);
            MaintenanceBtn.Location = new Point(0, 309);
            MaintenanceBtn.Margin = new Padding(10);
            MaintenanceBtn.Name = "MaintenanceBtn";
            MaintenanceBtn.Size = new Size(207, 55);
            MaintenanceBtn.TabIndex = 3;
            MaintenanceBtn.Text = "Maintenance";
            MaintenanceBtn.UseVisualStyleBackColor = false;
            MaintenanceBtn.Click += MaintenanceBtn_Click;
            // 
            // panel6
            // 
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 273);
            panel6.Name = "panel6";
            panel6.Size = new Size(207, 36);
            panel6.TabIndex = 11;
            // 
            // AssetAssignmentBtn
            // 
            AssetAssignmentBtn.BackColor = Color.Transparent;
            AssetAssignmentBtn.BackgroundImage = (Image)resources.GetObject("AssetAssignmentBtn.BackgroundImage");
            AssetAssignmentBtn.BackgroundImageLayout = ImageLayout.Stretch;
            AssetAssignmentBtn.Cursor = Cursors.Hand;
            AssetAssignmentBtn.Dock = DockStyle.Top;
            AssetAssignmentBtn.FlatAppearance.BorderColor = Color.FromArgb(255, 79, 129);
            AssetAssignmentBtn.FlatAppearance.BorderSize = 0;
            AssetAssignmentBtn.FlatStyle = FlatStyle.Flat;
            AssetAssignmentBtn.Font = new Font("Berlin Sans FB Demi", 12F, FontStyle.Bold);
            AssetAssignmentBtn.ForeColor = Color.FromArgb(255, 79, 129);
            AssetAssignmentBtn.Location = new Point(0, 218);
            AssetAssignmentBtn.Margin = new Padding(10);
            AssetAssignmentBtn.Name = "AssetAssignmentBtn";
            AssetAssignmentBtn.Size = new Size(207, 55);
            AssetAssignmentBtn.TabIndex = 0;
            AssetAssignmentBtn.Text = "Asset Assignment";
            AssetAssignmentBtn.UseVisualStyleBackColor = false;
            AssetAssignmentBtn.Click += AssetAssignmentBtn_Click;
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 182);
            panel5.Name = "panel5";
            panel5.Size = new Size(207, 36);
            panel5.TabIndex = 10;
            // 
            // AssetManagementBtn
            // 
            AssetManagementBtn.BackColor = Color.Transparent;
            AssetManagementBtn.BackgroundImage = (Image)resources.GetObject("AssetManagementBtn.BackgroundImage");
            AssetManagementBtn.BackgroundImageLayout = ImageLayout.Stretch;
            AssetManagementBtn.Cursor = Cursors.Hand;
            AssetManagementBtn.Dock = DockStyle.Top;
            AssetManagementBtn.FlatAppearance.BorderColor = Color.FromArgb(255, 79, 129);
            AssetManagementBtn.FlatAppearance.BorderSize = 0;
            AssetManagementBtn.FlatStyle = FlatStyle.Flat;
            AssetManagementBtn.Font = new Font("Berlin Sans FB Demi", 12F, FontStyle.Bold);
            AssetManagementBtn.ForeColor = Color.FromArgb(255, 79, 129);
            AssetManagementBtn.Location = new Point(0, 127);
            AssetManagementBtn.Margin = new Padding(10);
            AssetManagementBtn.Name = "AssetManagementBtn";
            AssetManagementBtn.Size = new Size(207, 55);
            AssetManagementBtn.TabIndex = 1;
            AssetManagementBtn.Text = "Asset Management";
            AssetManagementBtn.UseVisualStyleBackColor = false;
            AssetManagementBtn.Click += AssetManagementBtn_Click;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 91);
            panel2.Name = "panel2";
            panel2.Size = new Size(207, 36);
            panel2.TabIndex = 9;
            // 
            // DashboardBtn
            // 
            DashboardBtn.BackColor = Color.Transparent;
            DashboardBtn.BackgroundImage = (Image)resources.GetObject("DashboardBtn.BackgroundImage");
            DashboardBtn.BackgroundImageLayout = ImageLayout.Stretch;
            DashboardBtn.Cursor = Cursors.Hand;
            DashboardBtn.Dock = DockStyle.Top;
            DashboardBtn.FlatAppearance.BorderColor = Color.FromArgb(255, 79, 129);
            DashboardBtn.FlatAppearance.BorderSize = 0;
            DashboardBtn.FlatStyle = FlatStyle.Flat;
            DashboardBtn.Font = new Font("Berlin Sans FB Demi", 12F, FontStyle.Bold);
            DashboardBtn.ForeColor = Color.FromArgb(255, 79, 129);
            DashboardBtn.Location = new Point(0, 36);
            DashboardBtn.Margin = new Padding(10);
            DashboardBtn.Name = "DashboardBtn";
            DashboardBtn.Size = new Size(207, 55);
            DashboardBtn.TabIndex = 2;
            DashboardBtn.Text = "Dashboard";
            DashboardBtn.UseVisualStyleBackColor = false;
            DashboardBtn.Click += DashboardBtn_Click;
            // 
            // panel7
            // 
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(207, 36);
            panel7.TabIndex = 12;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(255, 211, 220);
            panel8.Controls.Add(MainPanel);
            panel8.Controls.Add(SidePanelMain);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(207, 72);
            panel8.Name = "panel8";
            panel8.Size = new Size(920, 669);
            panel8.TabIndex = 3;
            // 
            // MainPanel
            // 
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(635, 669);
            MainPanel.TabIndex = 3;
            // 
            // SidePanelMain
            // 
            SidePanelMain.Controls.Add(SidePanel);
            SidePanelMain.Controls.Add(panel3);
            SidePanelMain.Dock = DockStyle.Right;
            SidePanelMain.Location = new Point(635, 0);
            SidePanelMain.Name = "SidePanelMain";
            SidePanelMain.Size = new Size(285, 669);
            SidePanelMain.TabIndex = 2;
            // 
            // SidePanel
            // 
            SidePanel.BackColor = Color.FromArgb(255, 211, 220);
            SidePanel.Dock = DockStyle.Fill;
            SidePanel.Location = new Point(0, 36);
            SidePanel.Name = "SidePanel";
            SidePanel.Size = new Size(285, 633);
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
            panel3.Size = new Size(285, 36);
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
            button3.Location = new Point(254, 8);
            button3.Margin = new Padding(10);
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
            ClientSize = new Size(1127, 741);
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
        private Panel panel4;
        private Panel panel1;
        private Panel panel6;
        private Panel panel5;
        private Panel panel2;
        private Panel panel7;
        private Label label1;
        private Panel panel8;
        private Panel SidePanelMain;
        private Panel panel3;
        private Panel SidePanel;
        private Button button3;
        private Panel MainPanel;
    }
}
