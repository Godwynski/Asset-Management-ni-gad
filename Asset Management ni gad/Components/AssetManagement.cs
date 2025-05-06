using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
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
            AssetsGrid.CellContentClick += new DataGridViewCellEventHandler(AssetsGrid_CellContentClick);

        }
        public void LoadAssets()
        {
            dbHelper = new DatabaseHelper("localhost", "office_asset_manager", "root", "");
            string query = "SELECT * FROM assets";
            DataTable dt = dbHelper.ExecuteQuery(query);
            AssetsGrid.DataSource = dt;

            AssetsGrid.Columns["asset_id"].HeaderText = "ID";
            AssetsGrid.Columns["asset_name"].HeaderText = "Name";
            AssetsGrid.Columns["category"].HeaderText = "Category";
            AssetsGrid.Columns["purchase_date"].HeaderText = "Purchase Date";
            AssetsGrid.Columns["status"].HeaderText = "Status";
            AssetsGrid.Columns["value"].HeaderText = "Price";
            AssetsGrid.Columns["notes"].HeaderText = "Notes";

            // Add Action Column with Edit and Delete buttons
            if (!AssetsGrid.Columns.Contains("Actions"))
            {
                // Edit Button
                DataGridViewButtonColumn editButtonCol = new DataGridViewButtonColumn();
                editButtonCol.Name = "Edit";
                editButtonCol.HeaderText = "Edit";
                editButtonCol.Text = "Edit";
                editButtonCol.UseColumnTextForButtonValue = true;
                AssetsGrid.Columns.Add(editButtonCol);

                // Delete Button
                DataGridViewButtonColumn deleteButtonCol = new DataGridViewButtonColumn();
                deleteButtonCol.Name = "Delete";
                deleteButtonCol.HeaderText = "Delete";
                deleteButtonCol.Text = "Delete";
                deleteButtonCol.UseColumnTextForButtonValue = true;
                AssetsGrid.Columns.Add(deleteButtonCol);
            }
        }
        private void AssetsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int assetId = Convert.ToInt32(AssetsGrid.Rows[e.RowIndex].Cells["asset_id"].Value);

                // Check which button is clicked
                if (AssetsGrid.Columns[e.ColumnIndex].Name == "Edit")
                {
                    MessageBox.Show("Hi Guys haha test edit");
                }
                else if (AssetsGrid.Columns[e.ColumnIndex].Name == "Delete")
                {
                    MessageBox.Show("Hi Guys haha");
                }
            }
        }

    }
}
