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
    public partial class Maintenance : Form
    {
        private MySqlConnection connection;
        private bool isEditMode = false;
        private int currentRoomId = -1;
        public Maintenance()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            LoadRoomStatusComboBox();
            LoadRooms();

            // Wire up event handlers
            dgvRoom.CellContentClick += DgvRoom_CellContentClick;
            btnAddRoom.Click += BtnAddRoom_Click;
            btnCancel.Click += BtnCancel_Click;
            btnSearchRoom.Click += BtnSearchRoom_Click;
            txtSearchRoom.KeyPress += TxtSearchRoom_KeyPress;
        }
        private void InitializeDatabaseConnection()
        {
            string connectionString = "server=localhost;database=HotelDB;uid=root;pwd=;";
            connection = new MySqlConnection(connectionString);
        }

        private void LoadRoomStatusComboBox()
        {
            cmbRoomStatus.Items.AddRange(new object[] { "Available", "Occupied", "Cleaning" });
            cmbRoomStatus.SelectedIndex = 0;
        }

        private void LoadRooms(string searchTerm = "")
        {
            try
            {
                connection.Open();
                string query = @"SELECT RoomID, RoomName, Status, PricePerHour, Capacity, UpdatedAt 
                               FROM Rooms";

                if (!string.IsNullOrEmpty(searchTerm))
                {
                    query += " WHERE RoomName LIKE @searchTerm OR Status LIKE @searchTerm";
                }

                query += " ORDER BY UpdatedAt DESC";

                MySqlCommand cmd = new MySqlCommand(query, connection);

                if (!string.IsNullOrEmpty(searchTerm))
                {
                    cmd.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");
                }

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Clear existing data and columns
                dgvRoom.Columns.Clear();
                dgvRoom.DataSource = dt;

                // Add action buttons
                AddActionButtons();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading rooms: " + ex.Message);
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
            dgvRoom.Columns.Add(editButton);

            // Delete button
            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn
            {
                Name = "Delete",
                Text = "Delete",
                HeaderText = "Action",
                UseColumnTextForButtonValue = true,
                FlatStyle = FlatStyle.Standard,
                Width = 60
            };
            dgvRoom.Columns.Add(deleteButton);
        }

        private void DgvRoom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || !(dgvRoom.Columns[e.ColumnIndex] is DataGridViewButtonColumn))
                return;

            var columnName = dgvRoom.Columns[e.ColumnIndex].Name;

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
            var row = dgvRoom.Rows[rowIndex];
            currentRoomId = Convert.ToInt32(row.Cells["RoomID"].Value);
            txtRoomName.Text = row.Cells["RoomName"].Value?.ToString() ?? "";
            cmbRoomStatus.SelectedItem = row.Cells["Status"].Value?.ToString() ?? "Available";
            txtRoomPrice.Text = row.Cells["PricePerHour"].Value?.ToString() ?? "0";
            txtCapacity.Text = row.Cells["Capacity"].Value?.ToString() ?? "1";

            isEditMode = true;
            btnAddRoom.Text = "Update Room";
            this.Text = "Editing Room";
        }

        private void HandleDeleteClick(int rowIndex)
        {
            var roomId = Convert.ToInt32(dgvRoom.Rows[rowIndex].Cells["RoomID"].Value);
            var roomName = dgvRoom.Rows[rowIndex].Cells["RoomName"].Value?.ToString() ?? "this room";

            if (MessageBox.Show($"Are you sure you want to delete {roomName}?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    connection.Open();
                    using (var cmd = new MySqlCommand("DELETE FROM Rooms WHERE RoomID = @RoomID", connection))
                    {
                        cmd.Parameters.AddWithValue("@RoomID", roomId);
                        int affectedRows = cmd.ExecuteNonQuery();

                        if (affectedRows > 0)
                        {
                            LoadRooms();
                            MessageBox.Show("Room deleted successfully!");
                        }
                    }
                }
                catch (MySqlException ex) when (ex.Number == 1451) // Foreign key constraint
                {
                    MessageBox.Show($"Cannot delete {roomName} because it has existing bookings. " +
                                  "Please delete the bookings first.", "Delete Failed");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting room: {ex.Message}");
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void BtnAddRoom_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            try
            {
                connection.Open();
                string query;

                if (isEditMode)
                {
                    query = @"UPDATE Rooms SET 
                            RoomName = @RoomName, 
                            Status = @Status, 
                            PricePerHour = @PricePerHour, 
                            Capacity = @Capacity 
                            WHERE RoomID = @RoomID";
                }
                else
                {
                    query = @"INSERT INTO Rooms 
                            (RoomName, Status, PricePerHour, Capacity) 
                            VALUES 
                            (@RoomName, @Status, @PricePerHour, @Capacity)";
                }

                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@RoomName", txtRoomName.Text);
                    cmd.Parameters.AddWithValue("@Status", cmbRoomStatus.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@PricePerHour", decimal.Parse(txtRoomPrice.Text));
                    cmd.Parameters.AddWithValue("@Capacity", int.Parse(txtCapacity.Text));

                    if (isEditMode)
                    {
                        cmd.Parameters.AddWithValue("@RoomID", currentRoomId);
                    }

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        CancelOperation();
                        connection.Close();
                        LoadRooms();
                        MessageBox.Show(isEditMode ? "Room updated successfully!" : "Room added successfully!");
                    }
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

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtRoomName.Text))
            {
                MessageBox.Show("Please enter room name");
                return false;
            }

            if (!decimal.TryParse(txtRoomPrice.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Please enter a valid price (greater than 0)");
                return false;
            }

            if (!int.TryParse(txtCapacity.Text, out int capacity) || capacity <= 0)
            {
                MessageBox.Show("Please enter a valid capacity (greater than 0)");
                return false;
            }

            return true;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            CancelOperation();
        }

        private void CancelOperation()
        {
            // Clear all fields
            txtRoomName.Clear();
            cmbRoomStatus.SelectedIndex = 0;
            txtRoomPrice.Text = "0";
            txtCapacity.Text = "1";

            // Reset to add mode
            isEditMode = false;
            currentRoomId = -1;
            btnAddRoom.Text = "Add Room";
            this.Text = "Room Management";
        }

        private void BtnSearchRoom_Click(object sender, EventArgs e)
        {
            LoadRooms(txtSearchRoom.Text);
        }

        private void TxtSearchRoom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                LoadRooms(txtSearchRoom.Text);
                e.Handled = true;
            }
        }
    }
}
