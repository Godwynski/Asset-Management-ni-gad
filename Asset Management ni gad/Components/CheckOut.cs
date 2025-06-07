using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Asset_Management_ni_gad
{
    public partial class CheckOut : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;pwd=;database=HotelDB");

        public CheckOut()
        {
            InitializeComponent();

            // Event connections
            btnSearch.Click += BtnSearch_Click;
            dgvBookings.CellClick += DgvBookings_CellClick;
            btnClean.Click += BtnClean_Click;
            btnCheckOut.Click += BtnCheckOut_Click;


            btnClean.Visible = false;
            btnCheckOut.Visible = false;

            LoadBookings(); // Initial load
        }
        private void BtnCheckOut_Click(object sender, EventArgs e)
        {
            if (dgvBookings.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a booking to check out.");
                return;
            }

            int bookingID = Convert.ToInt32(dgvBookings.SelectedRows[0].Cells["BookingID"].Value);

            try
            {
                conn.Open();

                // Get RoomID from Booking
                MySqlCommand getRoomCmd = new MySqlCommand("SELECT RoomID FROM Bookings WHERE BookingID = @bookingID", conn);
                getRoomCmd.Parameters.AddWithValue("@bookingID", bookingID);
                int roomID = Convert.ToInt32(getRoomCmd.ExecuteScalar());

                // Set Room to Cleaning
                MySqlCommand updateRoom = new MySqlCommand("UPDATE Rooms SET Status = 'Cleaning' WHERE RoomID = @roomID", conn);
                updateRoom.Parameters.AddWithValue("@roomID", roomID);
                updateRoom.ExecuteNonQuery();

                // Update Booking to Completed
                MySqlCommand updateBooking = new MySqlCommand("UPDATE Bookings SET Status = 'Completed' WHERE BookingID = @bookingID", conn);
                updateBooking.Parameters.AddWithValue("@bookingID", bookingID);
                updateBooking.ExecuteNonQuery();

                MessageBox.Show("Guest checked out. Room is now set to cleaning.");
                conn.Close();
                LoadBookings();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during checkout: " + ex.Message);
            }
            finally
            {
                conn.Close();
                btnCheckOut.Visible = false;
                btnClean.Visible = false;
            }
        }


        private void BtnSearch_Click(object sender, EventArgs e)
        {
            LoadBookings(txtSearch.Text.Trim());
        }

        private void LoadBookings(string search = "")
        {
            try
            {
                conn.Open();
                string query = @"SELECT 
                                    b.BookingID, 
                                    g.FullName, 
                                    r.RoomName, 
                                    r.Status AS RoomStatus, 
                                    b.Status AS BookingStatus 
                                FROM Bookings b
                                JOIN Guests g ON b.GuestID = g.GuestID
                                JOIN Rooms r ON b.RoomID = r.RoomID
                                WHERE b.Status IN ('Checked-in', 'Completed') 
                                AND (g.FullName LIKE @search OR b.BookingID LIKE @search)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@search", $"%{search}%");

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvBookings.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading bookings: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void DgvBookings_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string roomStatus = dgvBookings.Rows[e.RowIndex].Cells["RoomStatus"].Value.ToString();

                if (roomStatus == "Occupied")
                {
                    btnCheckOut.Visible = true;
                    btnClean.Visible = false;
                }
                else if (roomStatus == "Cleaning")
                {
                    btnCheckOut.Visible = false;
                    btnClean.Visible = true;
                }
                else
                {
                    btnCheckOut.Visible = false;
                    btnClean.Visible = false;
                }
            }
        }

        private void BtnClean_Click(object sender, EventArgs e)
        {
            if (dgvBookings.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a booking to clean.");
                return;
            }

            int bookingID = Convert.ToInt32(dgvBookings.SelectedRows[0].Cells["BookingID"].Value);

            try
            {
                conn.Open();

                // Get RoomID from Booking
                MySqlCommand getRoomCmd = new MySqlCommand("SELECT RoomID FROM Bookings WHERE BookingID = @bookingID", conn);
                getRoomCmd.Parameters.AddWithValue("@bookingID", bookingID);
                int roomID = Convert.ToInt32(getRoomCmd.ExecuteScalar());

                // Update Room Status to Available
                MySqlCommand updateRoom = new MySqlCommand("UPDATE Rooms SET Status = 'Available' WHERE RoomID = @roomID", conn);
                updateRoom.Parameters.AddWithValue("@roomID", roomID);
                updateRoom.ExecuteNonQuery();

                // Update Booking Status to Completed
                MySqlCommand updateBooking = new MySqlCommand("UPDATE Bookings SET Status = 'Completed' WHERE BookingID = @bookingID", conn);
                updateBooking.Parameters.AddWithValue("@bookingID", bookingID);
                updateBooking.ExecuteNonQuery();

                MessageBox.Show("Room cleaned and booking marked as completed.");
                conn.Close();
                LoadBookings();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during clean operation: " + ex.Message);
            }
            finally
            {
                conn.Close();
                btnClean.Visible = false;
                btnCheckOut.Visible = false;
            }
        }
    }
}
