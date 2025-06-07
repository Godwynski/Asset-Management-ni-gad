using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Asset_Management_ni_gad
{
    public partial class EmployeeManagement : Form
    {
        private MySqlConnection connection;
        private bool isEditMode = false;
        private int currentGuestId = -1;
        public EmployeeManagement()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            LoadGuests();
            dgvGuest.CellContentClick += DgvGuest_CellContentClick;
        }
        private void InitializeDatabaseConnection()
        {
            string connectionString = "server=localhost;database=HotelDB;uid=root;pwd=;";
            connection = new MySqlConnection(connectionString);
        }

        private void LoadGuests(string searchTerm = "")
        {
            try
            {
                connection.Open();
                string query = "SELECT GuestID, FullName, Contact, Email, CreatedAt FROM Guests";

                if (!string.IsNullOrEmpty(searchTerm))
                {
                    query += " WHERE FullName LIKE @searchTerm OR Contact LIKE @searchTerm OR Email LIKE @searchTerm";
                }

                query += " ORDER BY CreatedAt DESC";

                MySqlCommand cmd = new MySqlCommand(query, connection);

                if (!string.IsNullOrEmpty(searchTerm))
                {
                    cmd.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");
                }

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Clear existing data and columns
                dgvGuest.Columns.Clear();
                dgvGuest.DataSource = dt;

                // Add action buttons
                AddActionButtons();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading guests: " + ex.Message);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
        private void AddActionButtons()
        {
            // Edit button
            DataGridViewButtonColumn editButton = new DataGridViewButtonColumn
            {
                Name = "Edit",
                Text = "Edit",
                HeaderText = "Action",
                UseColumnTextForButtonValue = true,
                FlatStyle = FlatStyle.Standard,
                Width = 60
            };
            dgvGuest.Columns.Add(editButton);

            //// Delete button
            //DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn
            //{
            //    Name = "Delete",
            //    Text = "Delete",
            //    HeaderText = "Action",
            //    UseColumnTextForButtonValue = true,
            //    FlatStyle = FlatStyle.Standard,
            //    Width = 60
            //};
            //dgvGuest.Columns.Add(deleteButton);
        }

        private void DgvGuest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure we're handling button clicks only
            if (e.RowIndex < 0 || !(dgvGuest.Columns[e.ColumnIndex] is DataGridViewButtonColumn))
                return;

            var columnName = dgvGuest.Columns[e.ColumnIndex].Name;

            if (columnName == "Edit")
            {
                HandleEditClick(e.RowIndex);
            }
            else if (columnName == "Delete")
            {
                HandleDeleteClick(e.RowIndex);
            }
        }

        private void HandleEditClick(int rowIndex)
        {
            var row = dgvGuest.Rows[rowIndex];
            currentGuestId = Convert.ToInt32(row.Cells["GuestID"].Value);
            txtFullName.Text = row.Cells["FullName"].Value?.ToString() ?? "";
            txtNumber.Text = row.Cells["Contact"].Value?.ToString() ?? "";
            txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? "";

            isEditMode = true;
            btnAddGuest.Text = "Update Guest";
            this.Text = "Editing Guest";
        }

        private void HandleDeleteClick(int rowIndex)
        {
            var guestId = Convert.ToInt32(dgvGuest.Rows[rowIndex].Cells["GuestID"].Value);
            var guestName = dgvGuest.Rows[rowIndex].Cells["FullName"].Value?.ToString() ?? "this guest";

            if (MessageBox.Show($"Are you sure you want to delete {guestName}?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    connection.Open();
                    using (var cmd = new MySqlCommand("DELETE FROM Guests WHERE GuestID = @GuestID", connection))
                    {
                        cmd.Parameters.AddWithValue("@GuestID", guestId);
                        int affectedRows = cmd.ExecuteNonQuery();

                        if (affectedRows > 0)
                        {
                            LoadGuests();
                            MessageBox.Show("Guest deleted successfully!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting guest: {ex.Message}");
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void btnSearchGuest_Click(object sender, EventArgs e)
        {
            LoadGuests(txtSearchGuest.Text);
        }

        private void btnAddGuest_Click(object sender, EventArgs e)
        {

        }

        private void dgvGuest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Edit button clicked
            if (dgvGuest.Columns[e.ColumnIndex].Name == "Edit")
            {
                DataGridViewRow row = dgvGuest.Rows[e.RowIndex];

                // Safely get values with null checks
                currentGuestId = Convert.ToInt32(row.Cells["GuestID"].Value);
                txtFullName.Text = row.Cells["FullName"].Value?.ToString() ?? "";
                txtNumber.Text = row.Cells["Contact"].Value?.ToString() ?? "";
                txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? "";

                // Switch to edit mode
                isEditMode = true;
                btnAddGuest.Text = "Update Guest";
                this.Text = "Edit Guest - " + txtFullName.Text;
            }
            // Delete button clicked
            else if (dgvGuest.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this guest?", "Confirm Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int guestId = Convert.ToInt32(dgvGuest.Rows[e.RowIndex].Cells["GuestID"].Value);

                    try
                    {
                        connection.Open();
                        string query = "DELETE FROM Guests WHERE GuestID = @GuestID";
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@GuestID", guestId);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            LoadGuests();
                            MessageBox.Show("Guest deleted successfully!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting guest: " + ex.Message);
                    }
                    finally
                    {
                        if (connection.State == System.Data.ConnectionState.Open)
                        {
                            connection.Close();
                        }
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CancelOperation();
        }

        private void CancelOperation()
        {
            // Clear all fields
            txtFullName.Clear();
            txtNumber.Clear();
            txtEmail.Clear();

            // Reset to add mode
            isEditMode = false;
            currentGuestId = -1;
            btnAddGuest.Text = "Add Guest";
            this.Text = "Guest Management";
        }

        private void txtSearchGuest_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                LoadGuests(txtSearchGuest.Text);
                e.Handled = true;
            }
        }

        private void GuestManagement_Load(object sender, EventArgs e)
        {
            // Ensure CellClick event is properly hooked
            dgvGuest.CellClick += dgvGuest_CellClick;
        }

        private void btnAddGuest_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Please enter full name");
                return;
            }

            try
            {
                connection.Open();
                string query;

                if (isEditMode)
                {
                    query = "UPDATE Guests SET FullName = @FullName, Contact = @Contact, Email = @Email WHERE GuestID = @GuestID";
                }
                else
                {
                    query = "INSERT INTO Guests (FullName, Contact, Email) VALUES (@FullName, @Contact, @Email)";
                }

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@FullName", txtFullName.Text);
                cmd.Parameters.AddWithValue("@Contact", txtNumber.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);

                if (isEditMode)
                {
                    cmd.Parameters.AddWithValue("@GuestID", currentGuestId);
                }

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    CancelOperation();
                    connection.Close();
                    LoadGuests();
                    MessageBox.Show(isEditMode ? "Guest updated successfully!" : "Guest added successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            CancelOperation();
        }

        private void btnSearchGuest_Click_1(object sender, EventArgs e)
        {
            LoadGuests(txtSearchGuest.Text);
        }
    }
}