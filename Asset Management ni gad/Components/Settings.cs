using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asset_Management_ni_gad.Components
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            FullNameTextbox.Text = Session.FullName;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            Logout();
        }
        private void Logout()
        {
            AuthForm loginForm = new AuthForm(); // your login form
            loginForm.Show();
        }

    }
}
