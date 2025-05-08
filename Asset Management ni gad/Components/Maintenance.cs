using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asset_Management_ni_gad
{
    public partial class Maintenance : Form
    {
        private DatabaseHelper dbHelper;
        private int selectedAssetId;
        public Maintenance()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper("localhost", "office_asset_manager", "root", "");
            LoadMaintenanceLogs();
        }

        public void LoadMaintenanceLogs()
        {
            string query = @"
        SELECT 
            m.maintenance_id AS 'Maintenance ID',
            a.asset_name AS 'Asset Name',
            m.issue_description AS 'Issue',
            m.maintenance_date AS 'Date',
            m.maintenance_status AS 'Status',
            m.cost AS 'Cost'
        FROM maintenance m
        INNER JOIN assets a ON m.asset_id = a.asset_id
        ORDER BY m.maintenance_date DESC";

            DataTable dt = dbHelper.ExecuteQuery(query);
            MaintenanceGrid.DataSource = dt;
        }

    }
}
