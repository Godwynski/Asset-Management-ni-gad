using MySql.Data.MySqlClient;
using System.Data;

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

    }
}
