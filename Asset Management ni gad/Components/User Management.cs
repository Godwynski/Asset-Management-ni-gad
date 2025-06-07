using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace Asset_Management_ni_gad.Components
{
    public partial class User_Management : Form
    {
        private MySqlConnection connection;
        private bool isEditMode = false;
        private int currentEmployeeId = -1;

        public User_Management()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            InitializeUIComponents();
            LoadEmployees();
        }

        private void InitializeDatabaseConnection()
        {
            try
            {
                string connectionString = "server=localhost;database=HotelDB;uid=root;pwd=;";
                connection = new MySqlConnection(connectionString);
                connection.Open(); // Test connection
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database connection failed: " + ex.Message);
                Environment.Exit(1); // Close application if DB connection fails
            }
        }

        private void InitializeUIComponents()
        {
            // Initialize combo box items
            cmbRole.Items.AddRange(new string[] { "Admin", "Employee" });
            cmbRole.SelectedIndex = 0;

            // Set password fields to use password characters
            txtPassword.UseSystemPasswordChar = true;
            txtConfirmPassword.UseSystemPasswordChar = true;

            // Wire up all event handlers
            btnSearchEmployee.Click += BtnSearchEmployee_Click;
            btnAddEmployee.Click += BtnAddEmployee_Click;
            btnCancel.Click += BtnCancel_Click;
            dgvEmployee.CellContentClick += DgvEmployee_CellContentClick;
            txtSearchEmployee.KeyPress += TxtSearchEmployee_KeyPress;
        }

        private void LoadEmployees(string searchTerm = "")
        {
            try
            {
                connection.Open();
                string query = @"SELECT EmployeeID, FullName, Email, Role, 
                               DATE_FORMAT(CreatedAt, '%Y-%m-%d %H:%i') as CreatedAt 
                               FROM Employees";

                if (!string.IsNullOrEmpty(searchTerm))
                {
                    query += " WHERE FullName LIKE @searchTerm OR Email LIKE @searchTerm";
                }

                query += " ORDER BY CreatedAt DESC";

                MySqlCommand cmd = new MySqlCommand(query, connection);

                if (!string.IsNullOrEmpty(searchTerm))
                {
                    cmd.Parameters.AddWithValue("@searchTerm", $"%{searchTerm}%");
                }

                DataTable dt = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);

                dgvEmployee.DataSource = dt;
                AddActionButtonsToGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading employees: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }


        private void AddActionButtonsToGrid()
        {
            // Remove existing buttons if they exist
            if (dgvEmployee.Columns.Contains("Edit"))
                dgvEmployee.Columns.Remove("Edit");
            if (dgvEmployee.Columns.Contains("Delete"))
                dgvEmployee.Columns.Remove("Delete");

            // Add Edit button
            DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn
            {
                Name = "Edit",
                Text = "Edit",
                HeaderText = "Action",
                UseColumnTextForButtonValue = true,
                FlatStyle = FlatStyle.Flat,
                Width = 70
            };
            dgvEmployee.Columns.Add(editColumn);

            // Add Delete button
            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn
            {
                Name = "Delete",
                Text = "Delete",
                HeaderText = "Action",
                UseColumnTextForButtonValue = true,
                FlatStyle = FlatStyle.Flat,
                Width = 70
            };
            dgvEmployee.Columns.Add(deleteColumn);
        }

        private void BtnSearchEmployee_Click(object sender, EventArgs e)
        {
            LoadEmployees(txtSearchEmployee.Text.Trim());
        }

        private void TxtSearchEmployee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                LoadEmployees(txtSearchEmployee.Text.Trim());
                e.Handled = true;
            }
        }

        private void DgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var columnName = dgvEmployee.Columns[e.ColumnIndex].Name;

            if (columnName == "Edit")
            {
                DataGridViewRow row = dgvEmployee.Rows[e.RowIndex];
                currentEmployeeId = Convert.ToInt32(row.Cells["EmployeeID"].Value);
                txtFullName.Text = row.Cells["FullName"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                cmbRole.SelectedItem = row.Cells["Role"].Value.ToString();

                // Clear password fields for security
                txtPassword.Clear();
                txtConfirmPassword.Clear();

                isEditMode = true;
                btnAddEmployee.Text = "Update Employee";
            }
            else if (columnName == "Delete")
            {
                DataGridViewRow row = dgvEmployee.Rows[e.RowIndex];
                int employeeId = Convert.ToInt32(row.Cells["EmployeeID"].Value);
                string employeeName = row.Cells["FullName"].Value.ToString();

                if (MessageBox.Show($"Are you sure you want to delete {employeeName}?",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    DeleteEmployee(employeeId);
                }
            }
        }

        private void DeleteEmployee(int employeeId)
        {
            try
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand(
                    "DELETE FROM Employees WHERE EmployeeID = @EmployeeID", connection))
                {
                    cmd.Parameters.AddWithValue("@EmployeeID", employeeId);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Employee deleted successfully!");
                        connection.Close();
                        LoadEmployees();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting employee: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        private void BtnAddEmployee_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            try
            {
                string passwordHash = isEditMode && string.IsNullOrEmpty(txtPassword.Text)
                    ? GetExistingPasswordHash(currentEmployeeId)
                    : HashPassword(txtPassword.Text);

                connection.Open();
                string query = isEditMode
                    ? @"UPDATE Employees SET 
                      FullName = @FullName, 
                      Email = @Email, 
                      Role = @Role, 
                      PasswordHash = @PasswordHash 
                      WHERE EmployeeID = @EmployeeID"
                    : @"INSERT INTO Employees 
                      (FullName, Email, PasswordHash, Role) 
                      VALUES 
                      (@FullName, @Email, @PasswordHash, @Role)";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@FullName", txtFullName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@Role", cmbRole.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@PasswordHash", passwordHash);

                    if (isEditMode)
                    {
                        cmd.Parameters.AddWithValue("@EmployeeID", currentEmployeeId);
                    }

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show(isEditMode ? "Employee updated successfully!" : "Employee added successfully!");
                        
                        ResetForm();
                        connection.Close();
                        LoadEmployees();
                    }
                }
            }
            catch (MySqlException ex) when (ex.Number == 1062)
            {
                MessageBox.Show("This email already exists. Please use a different email.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving employee: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        private string GetExistingPasswordHash(int employeeId)
        {
            try
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand(
                    "SELECT PasswordHash FROM Employees WHERE EmployeeID = @EmployeeID", connection))
                {
                    cmd.Parameters.AddWithValue("@EmployeeID", employeeId);
                    return cmd.ExecuteScalar()?.ToString();
                }
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        private bool ValidateInputs()
        {
            // Validate full name
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Please enter full name");
                return false;
            }

            // Validate email format
            if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Please enter a valid email address");
                return false;
            }

            // Password validation
            if (!isEditMode && string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please enter password");
                return false;
            }

            if (!string.IsNullOrEmpty(txtPassword.Text) && txtPassword.Text.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters");
                return false;
            }

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Password and confirmation do not match");
                return false;
            }

            return true;
        }

        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase);
            }
            catch
            {
                return false;
            }
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetForm()
        {
            txtFullName.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            cmbRole.SelectedIndex = 0;

            isEditMode = false;
            currentEmployeeId = -1;
            btnAddEmployee.Text = "Add Employee";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
    }
}