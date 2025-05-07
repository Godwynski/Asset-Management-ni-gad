using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Asset_Management_ni_gad.Components
{
    public partial class AssetManagement : Form
    {
        private DatabaseHelper dbHelper;
        private int selectedAssetId;

        public AssetManagement()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper("localhost", "office_asset_manager", "root", "");
            LoadAssets();
            AssetsGrid.CellContentClick += AssetsGrid_CellContentClick;
            HideAllPanels();
            DesigningFunctions.CenterPanel(DeleteAssetPanel, ParentPanel);
            DesigningFunctions.CenterPanel(EditAssetPanel, ParentPanel);
            DesigningFunctions.CenterPanel(AddAssetPanel, ParentPanel);
            DesigningFunctions.CenterPanel(ParentPanel, DeleteAssetPanel);
            ParentPanel.Dock = DockStyle.Fill;
            PopulateStatusComboBox();
        }

        private void PopulateStatusComboBox()
        {
            string[] statuses = { "Available", "Assigned", "Under Maintenance" };
            EditStatusComboBox.Items.AddRange(statuses);
            AddStatus.Items.AddRange(statuses);
            EditStatusComboBox.SelectedIndex = 0;
            AddStatus.SelectedIndex = 0;
        }

        public void LoadAssets()
        {
            string query = "SELECT * FROM assets";
            DataTable dt = dbHelper.ExecuteQuery(query);
            AssetsGrid.DataSource = dt;

            if (dt.Columns.Contains("asset_id"))
            {
                AssetsGrid.Columns["asset_id"].HeaderText = "ID";
                AssetsGrid.Columns["asset_name"].HeaderText = "Name";
                AssetsGrid.Columns["category"].HeaderText = "Category";
                AssetsGrid.Columns["purchase_date"].HeaderText = "Purchase Date";
                AssetsGrid.Columns["status"].HeaderText = "Status";
                AssetsGrid.Columns["value"].HeaderText = "Price";
                AssetsGrid.Columns["notes"].HeaderText = "Notes";
            }

            if (!AssetsGrid.Columns.Contains("Edit"))
            {
                var editButtonCol = new DataGridViewButtonColumn
                {
                    Name = "Edit",
                    HeaderText = "Edit",
                    Text = "Edit",
                    UseColumnTextForButtonValue = true
                };
                AssetsGrid.Columns.Add(editButtonCol);
            }

            if (!AssetsGrid.Columns.Contains("Delete"))
            {
                var deleteButtonCol = new DataGridViewButtonColumn
                {
                    Name = "Delete",
                    HeaderText = "Delete",
                    Text = "Delete",
                    UseColumnTextForButtonValue = true
                };
                AssetsGrid.Columns.Add(deleteButtonCol);
            }
        }

        private void AssetsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            selectedAssetId = Convert.ToInt32(AssetsGrid.Rows[e.RowIndex].Cells["asset_id"].Value);

            if (AssetsGrid.Columns[e.ColumnIndex].Name == "Edit")
            {
                HideAllPanels();
                EditAssetPanel.Visible = true;

                EditAssetName.Text = AssetsGrid.Rows[e.RowIndex].Cells["asset_name"].Value.ToString();
                EditCategoryz.Text = AssetsGrid.Rows[e.RowIndex].Cells["category"].Value.ToString();
                EditPrice.Text = AssetsGrid.Rows[e.RowIndex].Cells["value"].Value.ToString();
                EditNotes.Text = AssetsGrid.Rows[e.RowIndex].Cells["notes"].Value.ToString();
                EditStatusComboBox.SelectedItem = AssetsGrid.Rows[e.RowIndex].Cells["status"].Value.ToString();
            }
            else if (AssetsGrid.Columns[e.ColumnIndex].Name == "Delete")
            {
                selectedAssetId = Convert.ToInt32(AssetsGrid.Rows[e.RowIndex].Cells["asset_id"].Value);
                HideAllPanels();
                DeleteAssetPanel.Visible = true;
                Console.WriteLine("Selected for delete: " + selectedAssetId);

            }
        }

        private void UpdateAssetBtn_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(EditPrice.Text.Trim(), out decimal value))
            {
                MessageBox.Show("Invalid price");
                return;
            }

            string name = EditAssetName.Text.Trim();
            string category = EditCategoryz.Text.Trim();
            string status = EditStatusComboBox.SelectedItem?.ToString() ?? "";
            string notes = EditNotes.Text.Trim();

            string query = $"UPDATE assets SET asset_name = '{name}', category = '{category}', value = {value}, status = '{status}', notes = '{notes}' " +
                           $"WHERE asset_id = {selectedAssetId}";

            int result = dbHelper.ExecuteNonQuery(query);
            if (result > 0)
            {
                MessageBox.Show("Asset updated!");
                LoadAssets();
                EditAssetPanel.Visible = false;
            }
        }

        private void AddAssetBtn_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            AddAssetPanel.Visible = true;
        }

        private void AddSubmitBtn_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(AddPrice.Text.Trim(), out decimal value))
            {
                MessageBox.Show("Invalid price");
                return;
            }

            string name = AddName.Text.Trim();
            string category = AddCategory.Text.Trim();
            string status = AddStatus.SelectedItem?.ToString() ?? "";
            string notes = AddNotes.Text.Trim();

            string query = $"INSERT INTO assets (asset_name, category, value, status, notes, purchase_date) " +
                           $"VALUES ('{name}', '{category}', {value}, '{status}', '{notes}', NOW())";

            int result = dbHelper.ExecuteNonQuery(query);
            if (result > 0)
            {
                MessageBox.Show("Asset added!");
                LoadAssets();
                AddAssetPanel.Visible = false;
            }
        }

        private void HideAllPanels()
        {
            EditAssetPanel.Visible = false;
            DeleteAssetPanel.Visible = false;
            AddAssetPanel.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e) => HideAllPanels();
        private void button2_Click(object sender, EventArgs e) => HideAllPanels();
        private void button8_Click(object sender, EventArgs e) => HideAllPanels();
        private void button3_Click(object sender, EventArgs e) => HideAllPanels();

        private void Resize(object sender, EventArgs e)
        {
            DesigningFunctions.CenterPanel(DeleteAssetPanel, ParentPanel);
            DesigningFunctions.CenterPanel(EditAssetPanel, ParentPanel);
            DesigningFunctions.CenterPanel(AddAssetPanel, ParentPanel);
        }
        private void SearchBtn_Click_1(object sender, EventArgs e)
        {
            string searchTerm = SearchTextBox.Text.Trim();
            string query = $"SELECT * FROM assets WHERE asset_name LIKE '%{searchTerm}%' OR category LIKE '%{searchTerm}%'";
            DataTable dt = dbHelper.ExecuteQuery(query);
            AssetsGrid.DataSource = dt;
        }
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            SearchTextBox.Clear();
            LoadAssets();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            string query = $"DELETE FROM assets WHERE asset_id = {selectedAssetId};";
            int result = dbHelper.ExecuteNonQuery(query);
            LoadAssets();
            DeleteAssetPanel.Visible = false;
        }

        private void CancelDeleteBtn_Click(object sender, EventArgs e)
        {
            DeleteAssetPanel.Visible = false;
        }
    }
}
