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
        private DatabaseHelper dbHelper;
        private DataTable maintenanceData;
        private DataTable assetsData;
        private int currentMaintenanceId = -1;
        public Maintenance()
        {
            InitializeComponent();
            InitializeDatabase();
            LoadAssets();
            LoadMaintenanceData();
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

        private void LoadAssets()
        {
            try
            {
                string query = "SELECT asset_id, asset_name FROM assets ORDER BY asset_name";
                assetsData = dbHelper.ExecuteQuery(query);

                cmbAsset.DataSource = assetsData;
                cmbAsset.DisplayMember = "asset_name";
                cmbAsset.ValueMember = "asset_id";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading assets: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadMaintenanceData()
        {
            try
            {
                string query = @"
                    SELECT 
                        m.maintenance_id,
                        a.asset_name,
                        m.issue_description,
                        m.maintenance_date,
                        m.maintenance_status,
                        m.cost
                    FROM maintenance m
                    JOIN assets a ON m.asset_id = a.asset_id
                    ORDER BY m.maintenance_date DESC";

                maintenanceData = dbHelper.ExecuteQuery(query);
                dgvMaintenance.DataSource = maintenanceData;

                // Clear selection
                dgvMaintenance.ClearSelection();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading maintenance data: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupEventHandlers()
        {
            // Button events
            btnSave.Click += BtnSave_Click;
            btnCancel.Click += BtnCancel_Click;
            btnClose.Click += BtnClose_Click;
            btnSearch.Click += BtnSearch_Click;
            btnReset.Click += BtnReset_Click;

            // DataGridView events
            dgvMaintenance.SelectionChanged += DgvMaintenance_SelectionChanged;
            dgvMaintenance.CellDoubleClick += DgvMaintenance_CellDoubleClick;

            // Filter events
            cmbStatusFilter.SelectedIndexChanged += Filter_Changed;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                try
                {
                    if (currentMaintenanceId == -1)
                    {
                        // Add new record
                        string query = @"
                            INSERT INTO maintenance 
                            (asset_id, issue_description, maintenance_date, maintenance_status, cost)
                            VALUES (@assetId, @description, @date, @status, @cost)";

                        MySqlParameter[] parameters = {
                            new MySqlParameter("@assetId", cmbAsset.SelectedValue),
                            new MySqlParameter("@description", txtIssueDescription.Text),
                            new MySqlParameter("@date", dtpMaintenanceDate.Value.Date),
                            new MySqlParameter("@status", cmbStatus.SelectedItem.ToString()),
                            new MySqlParameter("@cost", decimal.Parse(txtCost.Text))
                        };

                        int rowsAffected = ExecuteParameterizedNonQuery(query, parameters);

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Maintenance record added successfully!", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadMaintenanceData();
                        }
                    }
                    else
                    {
                        // Update existing record
                        string query = @"
                            UPDATE maintenance 
                            SET 
                                asset_id = @assetId,
                                issue_description = @description,
                                maintenance_date = @date,
                                maintenance_status = @status,
                                cost = @cost
                            WHERE maintenance_id = @id";

                        MySqlParameter[] parameters = {
                            new MySqlParameter("@assetId", cmbAsset.SelectedValue),
                            new MySqlParameter("@description", txtIssueDescription.Text),
                            new MySqlParameter("@date", dtpMaintenanceDate.Value.Date),
                            new MySqlParameter("@status", cmbStatus.SelectedItem.ToString()),
                            new MySqlParameter("@cost", decimal.Parse(txtCost.Text)),
                            new MySqlParameter("@id", currentMaintenanceId)
                        };

                        int rowsAffected = ExecuteParameterizedNonQuery(query, parameters);

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Maintenance record updated successfully!", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadMaintenanceData();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving maintenance record: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = txtSearch.Text.Trim();
                string statusFilter = cmbStatusFilter.SelectedItem?.ToString();

                string query = @"
                    SELECT 
                        m.maintenance_id,
                        a.asset_name,
                        m.issue_description,
                        m.maintenance_date,
                        m.maintenance_status,
                        m.cost
                    FROM maintenance m
                    JOIN assets a ON m.asset_id = a.asset_id
                    WHERE (a.asset_name LIKE @searchTerm OR m.issue_description LIKE @searchTerm)";

                if (!string.IsNullOrEmpty(statusFilter) && statusFilter != "All Statuses")
                {
                    query += " AND m.maintenance_status = @status";
                }

                query += " ORDER BY m.maintenance_date DESC";

                MySqlParameter[] parameters = {
                    new MySqlParameter("@searchTerm", $"%{searchTerm}%"),
                    new MySqlParameter("@status", statusFilter)
                };

                maintenanceData = ExecuteParameterizedQuery(query, parameters);
                dgvMaintenance.DataSource = maintenanceData;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching maintenance records: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cmbStatusFilter.SelectedIndex = 0;
            LoadMaintenanceData();
        }

        private void DgvMaintenance_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMaintenance.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvMaintenance.SelectedRows[0];
                currentMaintenanceId = Convert.ToInt32(row.Cells["maintenance_id"].Value);

                // Find the asset in the combo box
                string assetName = row.Cells["asset_name"].Value.ToString();
                foreach (DataRowView item in cmbAsset.Items)
                {
                    if (item["asset_name"].ToString() == assetName)
                    {
                        cmbAsset.SelectedItem = item;
                        break;
                    }
                }

                txtIssueDescription.Text = row.Cells["issue_description"].Value.ToString();
                dtpMaintenanceDate.Value = Convert.ToDateTime(row.Cells["maintenance_date"].Value);
                cmbStatus.SelectedItem = row.Cells["maintenance_status"].Value.ToString();
                txtCost.Text = row.Cells["cost"].Value.ToString();

                lblRecordTitle.Text = "Edit Record";
                btnSave.Text = "Update Record";
            }
        }

        private void DgvMaintenance_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMaintenance.Rows[e.RowIndex];
                string details = $"Asset: {row.Cells["asset_name"].Value}\n" +
                               $"Date: {Convert.ToDateTime(row.Cells["maintenance_date"].Value).ToShortDateString()}\n" +
                               $"Status: {row.Cells["maintenance_status"].Value}\n" +
                               $"Cost: {decimal.Parse(row.Cells["cost"].Value.ToString()):C}\n\n" +
                               $"Issue Description:\n{row.Cells["issue_description"].Value}";

                MessageBox.Show(details, "Maintenance Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Filter_Changed(object sender, EventArgs e)
        {
            BtnSearch_Click(sender, e);
        }

        private bool ValidateForm()
        {
            if (cmbAsset.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an asset", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtIssueDescription.Text))
            {
                MessageBox.Show("Please enter an issue description", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a status", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtCost.Text, out decimal cost) || cost < 0)
            {
                MessageBox.Show("Please enter a valid cost amount", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ClearForm()
        {
            currentMaintenanceId = -1;
            cmbAsset.SelectedIndex = 0;
            txtIssueDescription.Clear();
            dtpMaintenanceDate.Value = DateTime.Now;
            cmbStatus.SelectedIndex = 0;
            txtCost.Text = "0.00";

            lblRecordTitle.Text = "New Record";
            btnSave.Text = "Save Record";
            dgvMaintenance.ClearSelection();
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
    }
}
