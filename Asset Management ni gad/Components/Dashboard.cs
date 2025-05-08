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
        private string connectionString = "Server=localhost;Database=office_asset_manager;Uid=root;Pwd=;"; // No password for root in XAMPP by default
        private DatabaseHelper dbHelper;
        private int selectedAssetId;
        public Dashboard()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper("localhost", "office_asset_manager", "root", "");
            LoadAssignments();
        }


        public void LoadAssignments()
        {
            string query = @"
        SELECT 
            aa.assignment_id AS 'Assignment ID',
            a.asset_name AS 'Asset Name',
            u.full_name AS 'Assigned To',
            aa.assigned_date AS 'Assigned Date',
            aa.return_date AS 'Return Date',
            aa.status AS 'Status'
        FROM asset_assignments aa
        INNER JOIN assets a ON aa.asset_id = a.asset_id
        INNER JOIN users u ON aa.user_id = u.user_id
        ORDER BY aa.assigned_date DESC";

            DataTable dt = dbHelper.ExecuteQuery(query);
            AssignmentsGrid.DataSource = dt;
        }

    }
}
