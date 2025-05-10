using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Asset_Management_ni_gad
{
    public partial class AssetReturn : Form
    {
        private DatabaseHelper dbHelper;
        private DataTable assignedAssetsData;
        private int currentAssetId = -1;
        private int currentAssignmentId = -1;

        public AssetReturn()
        {
            InitializeComponent();
            InitializeDatabase();
            LoadAssignedAssets();
            SetupEventHandlers();
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

        private void LoadAssignedAssets()
        {
            try
            {
                string query = @"
                    SELECT aa.assignment_id, a.asset_id, a.asset_name, 
                           CONCAT(u.full_name, ' (', u.username, ')') AS full_name, 
                           aa.assigned_date
                    FROM asset_assignments aa
                    JOIN assets a ON aa.asset_id = a.asset_id
                    JOIN users u ON aa.user_id = u.user_id
                    WHERE aa.status = 'Assigned'
                    ORDER BY aa.assigned_date DESC";

                assignedAssetsData = dbHelper.ExecuteQuery(query);
                dgvAssignedAssets.DataSource = assignedAssetsData;

                // Clear selection
                dgvAssignedAssets.ClearSelection();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading assigned assets: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupEventHandlers()
        {
            // Button events
            btnConfirmReturn.Click += BtnConfirmReturn_Click;
            btnCancel.Click += BtnCancel_Click;
            btnSearch.Click += BtnSearch_Click;
            btnRefresh.Click += BtnRefresh_Click;

            // DataGridView events
            dgvAssignedAssets.CellClick += DgvAssignedAssets_CellClick;

            // Radio button events
            radUnderMaintenance.CheckedChanged += radUnderMaintenance_CheckedChanged;
        }

        private void DgvAssignedAssets_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvAssignedAssets.Columns["actionColumn"].Index)
            {
                DataGridViewRow row = dgvAssignedAssets.Rows[e.RowIndex];
                currentAssetId = Convert.ToInt32(row.Cells["assetIdColumn"].Value);
                currentAssignmentId = Convert.ToInt32(row.Cells["assignment_id"].Value);

                // Highlight the selected row
                dgvAssignedAssets.ClearSelection();
                row.Selected = true;

                // Enable the status panel
                grpStatus.Enabled = true;
            }
        }

        private void radUnderMaintenance_CheckedChanged(object sender, EventArgs e)
        {
            // Enable maintenance details only if Under Maintenance is selected
            grpMaintenance.Enabled = radUnderMaintenance.Checked;
            //grpMaintenance.Enabled = radAvailable.Checked;
            //grpMaintenance.Enabled = radRetired.Checked;

        }

        private void BtnConfirmReturn_Click(object sender, EventArgs e)
        {
            if (currentAssetId == -1 || currentAssignmentId == -1)
            {
                MessageBox.Show("Please select an asset to return", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string assetStatus = "";
                if (radAvailable.Checked) assetStatus = "Available";
                else if (radUnderMaintenance.Checked) assetStatus = "Under Maintenance";
                else if (radRetired.Checked) assetStatus = "Retired";

                // Start transaction
                dbHelper.OpenConnection();
                using (MySqlTransaction transaction = dbHelper.GetConnection().BeginTransaction())
                {
                    try
                    {
                        // 1. Update the assignment record
                        string updateAssignment = @"
                            UPDATE asset_assignments 
                            SET status = 'Returned', return_date = CURDATE()
                            WHERE assignment_id = @assignmentId";

                        MySqlCommand cmd1 = new MySqlCommand(updateAssignment, dbHelper.GetConnection(), transaction);
                        cmd1.Parameters.AddWithValue("@assignmentId", currentAssignmentId);
                        cmd1.ExecuteNonQuery();

                        // 2. Update the asset status
                        string updateAsset = @"
                            UPDATE assets 
                            SET status = @status
                            WHERE asset_id = @assetId";

                        MySqlCommand cmd2 = new MySqlCommand(updateAsset, dbHelper.GetConnection(), transaction);
                        cmd2.Parameters.AddWithValue("@status", assetStatus);
                        cmd2.Parameters.AddWithValue("@assetId", currentAssetId);
                        cmd2.ExecuteNonQuery();

                        // 3. If under maintenance, add to maintenance table
                        if (radUnderMaintenance.Checked && !string.IsNullOrWhiteSpace(txtIssueDescription.Text))
                        {
                            string insertMaintenance = @"
                                INSERT INTO maintenance 
                                (asset_id, issue_description, maintenance_date, maintenance_status, cost)
                                VALUES (@assetId, @description, CURDATE(), 'Pending', @cost)";

                            MySqlCommand cmd3 = new MySqlCommand(insertMaintenance, dbHelper.GetConnection(), transaction);
                            cmd3.Parameters.AddWithValue("@assetId", currentAssetId);
                            cmd3.Parameters.AddWithValue("@description", txtIssueDescription.Text);

                            decimal cost = 0;
                            if (decimal.TryParse(txtMaintenanceCost.Text, out cost))
                                cmd3.Parameters.AddWithValue("@cost", cost);
                            else
                                cmd3.Parameters.AddWithValue("@cost", DBNull.Value);

                            cmd3.ExecuteNonQuery();
                        }

                        // Commit transaction
                        transaction.Commit();

                        MessageBox.Show("Asset returned successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Refresh the data
                        LoadAssignedAssets();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error returning asset: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbHelper.CloseConnection();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = txtSearch.Text.Trim();
                string query = @"
                    SELECT aa.assignment_id, a.asset_id, a.asset_name, 
                           CONCAT(u.full_name, ' (', u.username, ')') AS full_name, 
                           aa.assigned_date
                    FROM asset_assignments aa
                    JOIN assets a ON aa.asset_id = a.asset_id
                    JOIN users u ON aa.user_id = u.user_id
                    WHERE aa.status = 'Assigned'
                    AND (a.asset_name LIKE @searchTerm OR u.username LIKE @searchTerm OR u.full_name LIKE @searchTerm)
                    ORDER BY aa.assigned_date DESC";

                MySqlParameter[] parameters = {
                    new MySqlParameter("@searchTerm", $"%{searchTerm}%")
                };

                assignedAssetsData = ExecuteParameterizedQuery(query, parameters);
                dgvAssignedAssets.DataSource = assignedAssetsData;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching assigned assets: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadAssignedAssets();
        }

        private void ClearForm()
        {
            currentAssetId = -1;
            currentAssignmentId = -1;

            // Reset form controls
            radAvailable.Checked = true;
            txtIssueDescription.Clear();
            txtMaintenanceCost.Clear();
            grpMaintenance.Enabled = false;
            grpStatus.Enabled = false;

            // Clear selection in grid
            dgvAssignedAssets.ClearSelection();
        }

        // Helper methods for database operations
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

    }
}
