using System.Data;
using MySql.Data.MySqlClient;

namespace Asset_Management_ni_gad.Components
{
    public partial class Booking : Form
    {
        private DatabaseHelper dbHelper;
        private int selectedAssetId = -1;
        private int selectedUserId = -1;

        public Booking()
        {
            InitializeComponent();

            dbHelper = new DatabaseHelper("localhost", "office_asset_manager", "root", "");

            this.Load += AssignReturn_Load;
            AssetSearch.TextChanged += TxtAssetSearch_TextChanged;
            txtEmployeeSearch.TextChanged += TxtEmployeeSearch_TextChanged;
            dgvAssetSearch.CellClick += DgvAssetSearch_CellClick;
            dgvEmployeeSearch.CellClick += DgvEmployeeSearch_CellClick;
        }

        private void AssignReturn_Load(object sender, EventArgs e)
        {
            LoadAssignedAssets(dgvRecentAssignment);
        }

        public bool AssignAsset(int assetId, int userId, DateTime assignedDate, DateTime returnDate)
        {
            string insertQuery = @"
                INSERT INTO asset_assignments (asset_id, user_id, assigned_date, return_date, status) 
                VALUES (@asset_id, @user_id, @assigned_date, @return_date, 'Assigned');
            ";

            string updateQuery = "UPDATE assets SET status = 'Assigned' WHERE asset_id = @asset_id;";

            MySqlParameter[] parameters = new MySqlParameter[] {
                new MySqlParameter("@asset_id", assetId),
                new MySqlParameter("@user_id", userId),
                new MySqlParameter("@assigned_date", assignedDate),
                new MySqlParameter("@return_date", returnDate)
            };

            try
            {
                dbHelper.OpenConnection();

                using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, dbHelper.GetConnection()))
                {
                    insertCmd.Parameters.AddRange(parameters);
                    insertCmd.ExecuteNonQuery();
                }

                using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, dbHelper.GetConnection()))
                {
                    updateCmd.Parameters.AddWithValue("@asset_id", assetId);
                    updateCmd.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
            finally
            {
                dbHelper.CloseConnection();
            }
        }

        public void LoadAssignedAssets(DataGridView dgv)
        {
            string query = @"
                SELECT 
                    aa.assignment_id AS 'Assignment ID',
                    a.asset_name AS 'Asset',
                    u.full_name AS 'Assigned To',
                    aa.assigned_date AS 'Assignment Date',
                    aa.return_date AS 'Expected Return',
                    aa.status AS 'Status'
                FROM asset_assignments aa
                JOIN assets a ON aa.asset_id = a.asset_id
                JOIN users u ON aa.user_id = u.user_id
                ORDER BY aa.assigned_date DESC;
            ";

            DataTable dt = dbHelper.ExecuteQuery(query);
            dgv.DataSource = dt;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void TxtAssetSearch_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT asset_id, asset_name FROM assets WHERE asset_name LIKE @search";
            MySqlParameter[] param = { new MySqlParameter("@search", "%" + AssetSearch.Text + "%") };
            dgvAssetSearch.DataSource = dbHelper.ExecuteParameterizedQuery(query, param);
        }

        private void TxtEmployeeSearch_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT user_id, full_name FROM users WHERE full_name LIKE @search AND role = 'Employee'";
            MySqlParameter[] param = { new MySqlParameter("@search", "%" + txtEmployeeSearch.Text + "%") };
            dgvEmployeeSearch.DataSource = dbHelper.ExecuteParameterizedQuery(query, param);
        }

        private void DgvAssetSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvAssetSearch.Rows[e.RowIndex];
                selectedAssetId = Convert.ToInt32(row.Cells["asset_id"].Value);
                string assetName = row.Cells["asset_name"].Value.ToString();

                Asset.Text = assetName; // Label instead of ComboBox
            }
        }


        private void DgvEmployeeSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEmployeeSearch.Rows[e.RowIndex];
                selectedUserId = Convert.ToInt32(row.Cells["user_id"].Value);
                string fullName = row.Cells["full_name"].Value.ToString();

                Employee.Text = fullName; // Label instead of ComboBox
            }
        }


        public void LoadAssetSearch(DataGridView dgv, string searchQuery)
        {
            // The SQL query for searching assets by asset name or category
            string query = @"
                SELECT 
                    a.asset_id AS 'Asset ID',
                    a.asset_name AS 'Asset',
                    a.category AS 'Category',
                    a.purchase_date AS 'Purchase Date',
                    a.status AS 'Status'
                FROM assets a
                WHERE a.asset_name LIKE @searchQuery OR a.category LIKE @searchQuery
                ORDER BY a.asset_name;
            ";

            // Parameters for the SQL query
            MySqlParameter[] parameters = new MySqlParameter[] {
                new MySqlParameter("@searchQuery", "%" + searchQuery + "%") // Use wildcard for LIKE query
            };

            // Execute the query and get the results in a DataTable
            DataTable dt = dbHelper.ExecuteParameterizedQuery(query, parameters);

            // Bind the data to the DataGridView
            dgv.DataSource = dt;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void txtAssetSearch_TextChanged(object sender, EventArgs e)
        {
            LoadAssetSearch(dgvRecentAssignment, txtAssetSearch.Text);
        }

        private void btnCreateAssignment_Click(object sender, EventArgs e)
        {
            if (selectedAssetId == -1 || selectedUserId == -1)
            {
                MessageBox.Show("Please select both asset and employee.");
                return;
            }

            DateTime assignDate = dtpAssignDate.Value;
            DateTime returnDate = dtpReturnDate.Value;

            if (AssignAsset(selectedAssetId, selectedUserId, assignDate, returnDate))
            {
                MessageBox.Show("Asset successfully assigned.");
                LoadAssignedAssets(dgvRecentAssignment);
            }
        }


    }
}
