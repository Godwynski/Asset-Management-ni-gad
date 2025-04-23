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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {

            Form1 main = new Form1();
            main.Show();
            this.Hide();
        }
    }
}
