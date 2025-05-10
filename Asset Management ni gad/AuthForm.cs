using MySql.Data.MySqlClient;
using System.Data;

namespace Asset_Management_ni_gad
{
    public partial class AuthForm : Form
    {
        private DatabaseHelper dbHelper = new DatabaseHelper("localhost", "office_asset_manager", "root", "");

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
            string username = UsernameTextbox.Text.Trim();
            string password = PasswordTextbox.Text.Trim(); // In production, hash passwords.

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter username and password.");
                return;
            }

            string query = "SELECT * FROM users WHERE username = @username AND password = @password";

            MySqlParameter[] parameters = new MySqlParameter[]
            {
        new MySqlParameter("@username", username),
        new MySqlParameter("@password", password) // 🔐 Store hashed passwords for security
            };

            DataTable result = dbHelper.ExecuteParameterizedQuery(query, parameters);

            if (result.Rows.Count > 0)
            {
                string fullName = result.Rows[0]["full_name"].ToString();
                string role = result.Rows[0]["role"].ToString();
                Session.FullName = result.Rows[0]["full_name"].ToString();
                Session.Role = result.Rows[0]["role"].ToString();
                MainForm main = new MainForm(); // or whatever your main form is named
                main.Show();
                this.Hide(); // hides the login form

            }
            else
            {
                MessageBox.Show("Invalid login.");
            }
        }


    }
}
