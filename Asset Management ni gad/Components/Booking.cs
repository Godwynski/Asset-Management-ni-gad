using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Asset_Management_ni_gad.Components
{
    public partial class Booking : Form
    {
        private MySqlConnection connection;
        private string connectionString = "server=localhost;database=HotelDB;uid=root;pwd=;";

        public Booking()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            LoadInitialData();
            WireUpEvents();
        }

        private void InitializeDatabaseConnection()
        {
            connection = new MySqlConnection(connectionString);
        }

        private void LoadInitialData()
        {
            LoadGuests();
            LoadRooms();
            LoadRecentLogs();

            // Set default dates
            dtpCheckIn.Value = DateTime.Now;
            dtpCheckOut.Value = DateTime.Now.AddDays(1);
        }

        private void WireUpEvents()
        {
            // Search buttons
            btnSearchGuest.Click += (s, e) => LoadGuests(txtSearchGuest.Text);
            btnSearchRoom.Click += (s, e) => LoadRooms(txtSearchRoom.Text);
            btnSearchRecent.Click += (s, e) => LoadRecentLogs(txtSearchRecent.Text);

            // Data grid view selection changes
            dgvGuests.SelectionChanged += (s, e) => CalculateTotalAmount();
            dgvRooms.SelectionChanged += (s, e) => CalculateTotalAmount();

            // Date time pickers value changes
            dtpCheckIn.ValueChanged += (s, e) => CalculateTotalAmount();
            dtpCheckOut.ValueChanged += (s, e) => CalculateTotalAmount();

            // Action buttons
            btnCheckIn.Click += BtnCheckIn_Click;
            btnCreateAssignment.Click += BtnCreateAssignment_Click;

            // Recent logs grid buttons
            dgvRecentLogs.CellContentClick += DgvRecentLogs_CellContentClick;
        }

        private void LoadGuests(string searchTerm = "")
        {
            try
            {
                connection.Open();
                string query = "SELECT GuestID, FullName, Contact, Email FROM Guests";

                if (!string.IsNullOrEmpty(searchTerm))
                {
                    query += " WHERE FullName LIKE @search OR Contact LIKE @search OR Email LIKE @search";
                }

                query += " ORDER BY CreatedAt DESC";

                MySqlCommand cmd = new MySqlCommand(query, connection);

                if (!string.IsNullOrEmpty(searchTerm))
                {
                    cmd.Parameters.AddWithValue("@search", $"%{searchTerm}%");
                }

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvGuests.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading guests: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }

        private void LoadRooms(string searchTerm = "")
        {
            try
            {
                connection.Open();
                string query = "SELECT RoomID, RoomName, Status, PricePerHour, Capacity FROM Rooms WHERE Status = 'Available'";

                if (!string.IsNullOrEmpty(searchTerm))
                {
                    query += " AND (RoomName LIKE @search OR CAST(PricePerHour AS CHAR) LIKE @search)";
                }

                MySqlCommand cmd = new MySqlCommand(query, connection);

                if (!string.IsNullOrEmpty(searchTerm))
                {
                    cmd.Parameters.AddWithValue("@search", $"%{searchTerm}%");
                }

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvRooms.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading rooms: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }

        private void LoadRecentLogs(string searchTerm = "")
        {
            try
            {
                connection.Open();
                string query = @"SELECT b.BookingID, g.FullName AS GuestName, r.RoomName, 
                                 b.CheckIn, b.CheckOut, b.TotalAmount, b.Status
                                 FROM Bookings b
                                 JOIN Guests g ON b.GuestID = g.GuestID
                                 JOIN Rooms r ON b.RoomID = r.RoomID";

                if (!string.IsNullOrEmpty(searchTerm))
                {
                    query += " WHERE g.FullName LIKE @search OR r.RoomName LIKE @search";
                }

                query += " ORDER BY b.CreatedAt DESC LIMIT 50";

                MySqlCommand cmd = new MySqlCommand(query, connection);

                if (!string.IsNullOrEmpty(searchTerm))
                {
                    cmd.Parameters.AddWithValue("@search", $"%{searchTerm}%");
                }

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvRecentLogs.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading recent logs: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }

        private void CalculateTotalAmount()
        {
            if (dgvGuests.SelectedRows.Count == 0 || dgvRooms.SelectedRows.Count == 0)
                return;

            try
            {
                DateTime checkIn = dtpCheckIn.Value;
                DateTime checkOut = dtpCheckOut.Value;

                if (checkOut <= checkIn)
                {
                    lblAmount.Text = "Invalid dates";
                    return;
                }

                decimal pricePerHour = Convert.ToDecimal(dgvRooms.SelectedRows[0].Cells["PricePerHour"].Value);
                TimeSpan duration = checkOut - checkIn;
                decimal totalHours = (decimal)duration.TotalHours;
                decimal totalAmount = pricePerHour * totalHours;

                lblAmount.Text = totalAmount.ToString("0.00"); // Shows just numbers without currency symbol
                lblAmount.Tag = totalAmount; // Store the numeric value in Tag property
            }
            catch (Exception ex)
            {
                lblAmount.Text = "Error calculating";
                Console.WriteLine(ex.Message);
            }
        }

        private void BtnCreateAssignment_Click(object sender, EventArgs e)
        {
            if (dgvGuests.SelectedRows.Count == 0 || dgvRooms.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select both a guest and a room");
                return;
            }

            if (dtpCheckOut.Value <= dtpCheckIn.Value)
            {
                MessageBox.Show("Check-out date must be after check-in date");
                return;
            }

            try
            {
                int guestId = Convert.ToInt32(dgvGuests.SelectedRows[0].Cells["GuestID"].Value);
                int roomId = Convert.ToInt32(dgvRooms.SelectedRows[0].Cells["RoomID"].Value);
                DateTime checkIn = dtpCheckIn.Value;
                DateTime checkOut = dtpCheckOut.Value;
                decimal totalAmount = decimal.Parse(lblAmount.Text.Replace("$", "").Replace(",", ""));

                connection.Open();

                // Check if room is available for the selected dates
                string availabilityQuery = @"SELECT COUNT(*) FROM Bookings 
                                          WHERE RoomID = @roomId AND Status IN ('Booked', 'Checked-in')
                                          AND ((CheckIn <= @checkOut AND CheckOut >= @checkIn))";

                MySqlCommand availabilityCmd = new MySqlCommand(availabilityQuery, connection);
                availabilityCmd.Parameters.AddWithValue("@roomId", roomId);
                availabilityCmd.Parameters.AddWithValue("@checkIn", checkIn);
                availabilityCmd.Parameters.AddWithValue("@checkOut", checkOut);

                int conflictingBookings = Convert.ToInt32(availabilityCmd.ExecuteScalar());

                if (conflictingBookings > 0)
                {
                    MessageBox.Show("The room is not available for the selected dates");
                    return;
                }

                // Create booking
                string bookingQuery = @"INSERT INTO Bookings (GuestID, RoomID, CheckIn, CheckOut, TotalAmount, Status)
                                      VALUES (@guestId, @roomId, @checkIn, @checkOut, @totalAmount, 'Booked')";

                MySqlCommand bookingCmd = new MySqlCommand(bookingQuery, connection);
                bookingCmd.Parameters.AddWithValue("@guestId", guestId);
                bookingCmd.Parameters.AddWithValue("@roomId", roomId);
                bookingCmd.Parameters.AddWithValue("@checkIn", checkIn);
                bookingCmd.Parameters.AddWithValue("@checkOut", checkOut);
                bookingCmd.Parameters.AddWithValue("@totalAmount", totalAmount);

                bookingCmd.ExecuteNonQuery();

                // Update room status
                string roomUpdateQuery = "UPDATE Rooms SET Status = 'Occupied' WHERE RoomID = @roomId";
                MySqlCommand roomUpdateCmd = new MySqlCommand(roomUpdateQuery, connection);
                roomUpdateCmd.Parameters.AddWithValue("@roomId", roomId);
                roomUpdateCmd.ExecuteNonQuery();

                MessageBox.Show("Booking created successfully!");
                connection.Close();
                LoadRooms();
                LoadRecentLogs();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating booking: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }

        private void BtnCheckIn_Click(object sender, EventArgs e)
        {
            if (dgvRecentLogs.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a booking to check in");
                return;
            }

            DataGridViewRow selectedRow = dgvRecentLogs.SelectedRows[0];
            string status = selectedRow.Cells["Status"].Value.ToString();

            if (status != "Booked")
            {
                MessageBox.Show("Only 'Booked' reservations can be checked in");
                return;
            }

            int bookingId = Convert.ToInt32(selectedRow.Cells["BookingID"].Value);

            try
            {
                connection.Open();

                // Update booking status
                string bookingUpdate = "UPDATE Bookings SET Status = 'Checked-in' WHERE BookingID = @bookingId";
                MySqlCommand bookingCmd = new MySqlCommand(bookingUpdate, connection);
                bookingCmd.Parameters.AddWithValue("@bookingId", bookingId);
                bookingCmd.ExecuteNonQuery();

                MessageBox.Show("Guest checked in successfully!");
                connection.Close();
                LoadRecentLogs();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking in: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }

        private void DgvRecentLogs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                int bookingId = Convert.ToInt32(senderGrid.Rows[e.RowIndex].Cells["BookingID"].Value);
                string status = senderGrid.Rows[e.RowIndex].Cells["Status"].Value.ToString();
                int roomId = 0;

                // Get room ID for this booking
                try
                {
                    connection.Open();
                    string roomQuery = "SELECT RoomID FROM Bookings WHERE BookingID = @bookingId";
                    MySqlCommand roomCmd = new MySqlCommand(roomQuery, connection);
                    roomCmd.Parameters.AddWithValue("@bookingId", bookingId);
                    roomId = Convert.ToInt32(roomCmd.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error getting room information: {ex.Message}");
                    return;
                }
                finally
                {
                    connection.Close();
                }

                string buttonText = senderGrid.Columns[e.ColumnIndex].HeaderText;

                try
                {
                    connection.Open();

                    if (buttonText == "Clean")
                    {
                        // Update room status to Cleaning
                        string roomUpdate = "UPDATE Rooms SET Status = 'Cleaning' WHERE RoomID = @roomId";
                        MySqlCommand roomCmd = new MySqlCommand(roomUpdate, connection);
                        roomCmd.Parameters.AddWithValue("@roomId", roomId);
                        roomCmd.ExecuteNonQuery();

                        MessageBox.Show("Room marked for cleaning");
                    }
                    else if (buttonText == "Check In" && status == "Booked")
                    {
                        // Update booking status to Checked-in
                        string bookingUpdate = "UPDATE Bookings SET Status = 'Checked-in' WHERE BookingID = @bookingId";
                        MySqlCommand bookingCmd = new MySqlCommand(bookingUpdate, connection);
                        bookingCmd.Parameters.AddWithValue("@bookingId", bookingId);
                        bookingCmd.ExecuteNonQuery();

                        // Update room status to Occupied
                        string roomUpdate = "UPDATE Rooms SET Status = 'Occupied' WHERE RoomID = @roomId";
                        MySqlCommand roomCmd = new MySqlCommand(roomUpdate, connection);
                        roomCmd.Parameters.AddWithValue("@roomId", roomId);
                        roomCmd.ExecuteNonQuery();

                        MessageBox.Show("Guest checked in successfully!");
                    }
                    else if (buttonText == "Check Out" && (status == "Booked" || status == "Checked-in"))
                    {
                        // Update booking status to Completed
                        string bookingUpdate = "UPDATE Bookings SET Status = 'Completed' WHERE BookingID = @bookingId";
                        MySqlCommand bookingCmd = new MySqlCommand(bookingUpdate, connection);
                        bookingCmd.Parameters.AddWithValue("@bookingId", bookingId);
                        bookingCmd.ExecuteNonQuery();

                        // Update room status to Available
                        string roomUpdate = "UPDATE Rooms SET Status = 'Available' WHERE RoomID = @roomId";
                        MySqlCommand roomCmd = new MySqlCommand(roomUpdate, connection);
                        roomCmd.Parameters.AddWithValue("@roomId", roomId);
                        roomCmd.ExecuteNonQuery();

                        MessageBox.Show("Guest checked out successfully!");
                    }

                    LoadRecentLogs();
                    LoadRooms();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error processing action: {ex.Message}");
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}