namespace Asset_Management_ni_gad
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();

        }

        private void resize(object sender, EventArgs e)
        {
            DesigningFunctions.CenterPanel(MainPanel, LoginForm);
        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {

            MainForm main = new MainForm();
            main.Show();
            //this.Hide();
        }
    }
}
