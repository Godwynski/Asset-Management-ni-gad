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
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot;

namespace Asset_Management_ni_gad
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper("localhost", "office_asset_manager", "root", "");
            LoadDashboardData();
        }

        private DatabaseHelper dbHelper;

        private void LoadDashboardData()
        {
            try
            {
                // Load statistics
                LoadStatistics();

                // Load recent activity
                LoadRecentActivity();

                // Load total asset value
                LoadTotalAssetValue();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard data: " + ex.Message);
            }
        }

        private void LoadStatistics()
        {
            // Total Assets
            string totalAssetsQuery = "SELECT COUNT(*) FROM assets";
            lblTotalAssetsValue.Text = dbHelper.ExecuteQuery(totalAssetsQuery).Rows[0][0].ToString();

            // Assigned Assets
            string assignedAssetsQuery = "SELECT COUNT(*) FROM assets WHERE status = 'Assigned'";
            lblAssignedAssetsValue.Text = dbHelper.ExecuteQuery(assignedAssetsQuery).Rows[0][0].ToString();

            // Under Maintenance
            string underMaintenanceQuery = "SELECT COUNT(*) FROM assets WHERE status = 'Under Maintenance'";
            lblUnderMaintenanceValue.Text = dbHelper.ExecuteQuery(underMaintenanceQuery).Rows[0][0].ToString();

            // Retired Assets
            string retiredAssetsQuery = "SELECT COUNT(*) FROM assets WHERE status = 'Retired'";
            lblRetiredAssetsValue.Text = dbHelper.ExecuteQuery(retiredAssetsQuery).Rows[0][0].ToString();

            // Total Users
            string totalUsersQuery = "SELECT COUNT(*) FROM users";
            lblTotalUsersValue.Text = dbHelper.ExecuteQuery(totalUsersQuery).Rows[0][0].ToString();

            // Available Assets
            string availableAssetsQuery = "SELECT COUNT(*) FROM assets WHERE status = 'Available'";
            lblAvailableAssetsValue.Text = dbHelper.ExecuteQuery(availableAssetsQuery).Rows[0][0].ToString();

            // Pending Maintenance
            string pendingMaintenanceQuery = "SELECT COUNT(*) FROM maintenance WHERE maintenance_status = 'Pending'";
            lblPendingMaintenanceValue.Text = dbHelper.ExecuteQuery(pendingMaintenanceQuery).Rows[0][0].ToString();

            // Active Assignments
            string activeAssignmentsQuery = "SELECT COUNT(*) FROM asset_assignments WHERE status = 'Assigned'";
            lblActiveAssignmentsValue.Text = dbHelper.ExecuteQuery(activeAssignmentsQuery).Rows[0][0].ToString();
        }

        private void LoadRecentActivity()
        {
            string recentActivityQuery = @"
                SELECT 
                    a.asset_name AS 'Asset',
                    CASE 
                        WHEN aa.status = 'Assigned' THEN CONCAT('Assigned to ', u.full_name)
                        WHEN aa.status = 'Returned' THEN CONCAT('Returned by ', u.full_name)
                    END AS 'Activity',
                    aa.assigned_date AS 'Date',
                    aa.status AS 'Status'
                FROM asset_assignments aa
                JOIN assets a ON aa.asset_id = a.asset_id
                JOIN users u ON aa.user_id = u.user_id
                ORDER BY aa.assigned_date DESC
                LIMIT 10";

            DataTable dt = dbHelper.ExecuteQuery(recentActivityQuery);
            dataGridViewRecentActivity.DataSource = dt;

            // Format the DataGridView
            if (dataGridViewRecentActivity.Columns.Contains("Date"))
            {
                dataGridViewRecentActivity.Columns["Date"].DefaultCellStyle.Format = "MM/dd/yyyy";
            }
            dataGridViewRecentActivity.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadTotalAssetValue()
        {
            string totalValueQuery = "SELECT SUM(value) FROM assets WHERE status != 'Retired'";
            DataTable dt = dbHelper.ExecuteQuery(totalValueQuery);

            if (dt.Rows.Count > 0 && dt.Rows[0][0] != DBNull.Value)
            {
                decimal totalValue = Convert.ToDecimal(dt.Rows[0][0]);
                lblTotalAssetValue.Text = totalValue.ToString("C");
            }
            else
            {
                lblTotalAssetValue.Text = "$0.00";
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDashboardData();
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Clean up resources
            if (dbHelper != null)
            {
                dbHelper.CloseConnection();
            }
        }
    }
}
