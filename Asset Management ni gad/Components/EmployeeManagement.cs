using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Asset_Management_ni_gad
{
    public partial class EmployeeManagement : Form
    {
        private DatabaseHelper dbHelper;
        private DataTable usersData;
        private int currentUserId = -1;

        public EmployeeManagement()
        {
            InitializeComponent();
            InitializeDatabase();
            LoadUserData();
            SetupEventHandlers();
            clearAll();
        }

        private void InitializeDatabase()
        {
            // XAMPP default connection settings
            string server = "localhost";
            string database = "office_asset_manager";
            string username = "root";
            string password = ""; // XAMPP default is empty password

            dbHelper = new DatabaseHelper(server, database, username, password);
        }

        private void LoadUserData()
        {
            try
            {
                string query = "SELECT user_id, username, full_name, role FROM users ORDER BY username";
                usersData = dbHelper.ExecuteQuery(query);
                dgvUsers.DataSource = usersData;

                // Configure DataGridView columns
                dgvUsers.Columns["user_id"].HeaderText = "ID";
                dgvUsers.Columns["user_id"].Visible = false; // Hide ID column
                dgvUsers.Columns["username"].HeaderText = "Username";
                dgvUsers.Columns["full_name"].HeaderText = "Full Name";
                dgvUsers.Columns["role"].HeaderText = "Role";

                // Clear selection
                dgvUsers.ClearSelection();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading user data: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupEventHandlers()
        {
            // Button events
            btnSave.Click += BtnSave_Click;
            btnCancel.Click += BtnCancel_Click;
            btnCloseForm.Click += BtnCloseForm_Click;
            btnSearch.Click += BtnSearch_Click;
            btnReset.Click += BtnReset_Click;

            // DataGridView events
            dgvUsers.SelectionChanged += DgvUsers_SelectionChanged;
            dgvUsers.CellDoubleClick += DgvUsers_CellDoubleClick;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                try
                {
                    if (currentUserId == -1)
                    {
                        // Add new user
                        string query = @"
                            INSERT INTO users 
                            (username, password, full_name, role)
                            VALUES (@username, @password, @fullName, @role)";

                        MySqlParameter[] parameters = {
                            new MySqlParameter("@username", txtUsername.Text.Trim()),
                            new MySqlParameter("@password", HashPassword(txtPassword.Text)), // Always hash passwords!
                            new MySqlParameter("@fullName", txtFullName.Text.Trim()),
                            new MySqlParameter("@role", cmbRole.SelectedItem.ToString())
                        };

                        int rowsAffected = ExecuteParameterizedNonQuery(query, parameters);

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User added successfully!", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadUserData();
                        }
                    }
                    else
                    {
                        // Update existing user
                        string query = @"
                            UPDATE users 
                            SET 
                                username = @username,
                                full_name = @fullName,
                                role = @role
                            WHERE user_id = @id";

                        // Only update password if it was changed
                        if (!string.IsNullOrEmpty(txtPassword.Text))
                        {
                            query = @"
                                UPDATE users 
                                SET 
                                    username = @username,
                                    password = @password,
                                    full_name = @fullName,
                                    role = @role
                                WHERE user_id = @id";
                        }

                        MySqlParameter[] parameters = {
                            new MySqlParameter("@username", txtUsername.Text.Trim()),
                            new MySqlParameter("@fullName", txtFullName.Text.Trim()),
                            new MySqlParameter("@role", cmbRole.SelectedItem.ToString()),
                            new MySqlParameter("@id", currentUserId)
                        };

                        // Add password parameter only if it was changed
                        if (!string.IsNullOrEmpty(txtPassword.Text))
                        {
                            Array.Resize(ref parameters, parameters.Length + 1);
                            parameters[parameters.Length - 1] = new MySqlParameter("@password", HashPassword(txtPassword.Text));
                        }

                        int rowsAffected = ExecuteParameterizedNonQuery(query, parameters);

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User updated successfully!", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadUserData();
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    if (ex.Number == 1062) // MySQL duplicate entry error
                    {
                        MessageBox.Show("Username already exists. Please choose a different username.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show($"Error saving user: {ex.Message}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving user: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void BtnCloseForm_Click(object sender, EventArgs e)
        {
            formPanel.Visible = false;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = txtSearch.Text.Trim();
                string query = @"
                    SELECT user_id, username, full_name, role 
                    FROM users 
                    WHERE username LIKE @searchTerm 
                    OR full_name LIKE @searchTerm
                    ORDER BY username";

                MySqlParameter[] parameters = {
                    new MySqlParameter("@searchTerm", $"%{searchTerm}%")
                };

                usersData = ExecuteParameterizedQuery(query, parameters);
                dgvUsers.DataSource = usersData;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching users: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadUserData();
        }

        private void DgvUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvUsers.SelectedRows[0];
                currentUserId = Convert.ToInt32(row.Cells["user_id"].Value);

                txtUsername.Text = row.Cells["username"].Value.ToString();
                txtFullName.Text = row.Cells["full_name"].Value.ToString();
                cmbRole.SelectedItem = row.Cells["role"].Value.ToString();

                // Clear password field for security
                txtPassword.Clear();

                lblRecordTitle.Text = "Edit User";
                btnSave.Text = "Update User";
            }
        }

        private void DgvUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUsers.Rows[e.RowIndex];
                string details = $"Username: {row.Cells["username"].Value}\n" +
                               $"Full Name: {row.Cells["full_name"].Value}\n" +
                               $"Role: {row.Cells["role"].Value}";

                MessageBox.Show(details, "User Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Please enter a username", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Only validate password for new users or when changing password
            if ((currentUserId == -1 || !string.IsNullOrEmpty(txtPassword.Text)) &&
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter a password", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbRole.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a role", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ClearForm()
        {
            currentUserId = -1;
            txtUsername.Clear();
            txtPassword.Clear();
            txtFullName.Clear();
            cmbRole.SelectedIndex = 0;

            lblRecordTitle.Text = "New User";
            btnSave.Text = "Save User";
            dgvUsers.ClearSelection();
        }

        private string HashPassword(string password)
        {
            // In a real application, use a proper hashing algorithm like BCrypt
            // This is just a placeholder - NEVER store plain text passwords!
            return password; // Replace with actual hashing in production
        }

        // Helper methods to work with parameterized queries
        private int ExecuteParameterizedNonQuery(string query, MySqlParameter[] parameters)
        {
            try
            {
                dbHelper.OpenConnection();
                using (MySqlCommand cmd = new MySqlCommand(query, dbHelper.GetConnection()))
                {
                    cmd.Parameters.AddRange(parameters);
                    return cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                dbHelper.CloseConnection();
            }
        }

        private DataTable ExecuteParameterizedQuery(string query, MySqlParameter[] parameters)
        {
            DataTable dt = new DataTable();
            try
            {
                dbHelper.OpenConnection();
                using (MySqlCommand cmd = new MySqlCommand(query, dbHelper.GetConnection()))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            finally
            {
                dbHelper.CloseConnection();
            }
            return dt;
        }

        // Helper property to get the connection from DatabaseHelper
        private MySqlConnection GetConnection()
        {
            return dbHelper.GetConnection();
        }
        public void clearAll()
        {
            txtSearch.Clear();
            LoadUserData();
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRole.SelectedItem?.ToString() == "Admin")
            {
                txtPassword.Visible = true;
                lblPassword.Visible = true;
            }
            else
            {
                txtPassword.Visible = false;
                lblPassword.Visible = false;
            }
        }
    }
}
