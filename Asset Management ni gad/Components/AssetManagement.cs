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

namespace Asset_Management_ni_gad.Components
{
    public partial class AssetManagement : Form
    {
        private DatabaseHelper dbHelper;

        public AssetManagement()
        {
            InitializeComponent();
            LoadAssets();
        }

        public void LoadAssets()
        {
            dbHelper = new DatabaseHelper("localhost", "office_asset_manager", "root", "");
            string query = "SELECT * FROM assets";
            DataTable dt = dbHelper.ExecuteQuery(query);
            AssetsGrid.DataSource = dt;
        }
    }
}
