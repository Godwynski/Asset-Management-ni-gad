using Asset_Management_ni_gad.Components;

namespace Asset_Management_ni_gad
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            //FullNameTextbox.Text = Session.FullName;
            InitializeComponent();
            SidePanelMain.Hide();
            LoadForm(MainPanel, new Dashboard());
            DashboardBtn.Click += NavBtn_Click;
            AssetManagementBtn.Click += NavBtn_Click;
            AssetAssignmentBtn.Click += NavBtn_Click;
            UserManagementBtn.Click += NavBtn_Click;
            MaintenanceBtn.Click += NavBtn_Click;
            AssetReturnBtn.Click += NavBtn_Click;
            DesigningFunctions.btnSelected(DashboardBtn, DashboardBtn, AssetManagementBtn, AssetAssignmentBtn, UserManagementBtn, MaintenanceBtn, AssetReturnBtn);
            FullNameTextbox.Text = Session.FullName;
        }

        private void NavBtn_Click(object sender, EventArgs e)
        {
            DesigningFunctions.btnSelected((Button)sender, DashboardBtn, AssetManagementBtn, AssetAssignmentBtn, UserManagementBtn, MaintenanceBtn, AssetReturnBtn);
        }

        private void User_Click(object sender, EventArgs e)
        {
            if (SidePanelMain.Visible) { 
            SidePanelMain.Hide();
            }
            else
            {
                SidePanelMain.Show();
            }
            //LoadForm(SidePanel, new Settings());
            //SidePanelMain.Show();

        }
        public void LoadForm(Panel container, Form formToLoad)
        {
            container.Show();
            container.Controls.Clear();
            formToLoad.TopLevel = false;
            formToLoad.FormBorderStyle = FormBorderStyle.None;
            formToLoad.Dock = DockStyle.Fill;
            container.Controls.Add(formToLoad);
            formToLoad.Show();
        }

        private void AssetManagementBtn_Click(object sender, EventArgs e)
        {
            LoadForm(MainPanel, new AssetManagement());
        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            LoadForm(MainPanel, new Dashboard());
        }

        private void AssetAssignmentBtn_Click(object sender, EventArgs e)
        {
            LoadForm(MainPanel, new AssetAssign());
        }

        private void MaintenanceBtn_Click(object sender, EventArgs e)
        {
            LoadForm(MainPanel, new Maintenance());
        }

        private void UserManagementBtn_Click(object sender, EventArgs e)
        {
            LoadForm(MainPanel, new EmployeeManagement());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SidePanelMain.Hide();
        }

        private void AssetReturnBtn_Click(object sender, EventArgs e)
        {
            LoadForm(MainPanel, new AssetReturn());
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            AuthForm loginForm = new AuthForm(); // your login form
            loginForm.Show();
            this.Close(); // closes the main form
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            SidePanelMain.Hide();
        }
    }
}
