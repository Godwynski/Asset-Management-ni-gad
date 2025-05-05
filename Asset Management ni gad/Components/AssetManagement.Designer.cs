namespace Asset_Management_ni_gad.Components
{
    partial class AssetManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            AssetsGrid = new DataGridView();
            flowLayoutPanel1 = new FlowLayoutPanel();
            SearchTextBox = new TextBox();
            SearchBtn = new Button();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            mySqlConnection1 = new MySql.Data.MySqlClient.MySqlConnection();
            mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AssetsGrid).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 211, 220);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(970, 605);
            panel1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(AssetsGrid, 0, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(20);
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 402F));
            tableLayoutPanel1.Size = new Size(970, 486);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // AssetsGrid
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 211, 220);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(51, 51, 51);
            AssetsGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            AssetsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AssetsGrid.BackgroundColor = Color.FromArgb(255, 246, 249);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 79, 129);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            AssetsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            AssetsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(217, 58, 102);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            AssetsGrid.DefaultCellStyle = dataGridViewCellStyle3;
            AssetsGrid.Dock = DockStyle.Fill;
            AssetsGrid.EnableHeadersVisualStyles = false;
            AssetsGrid.GridColor = Color.FromArgb(255, 211, 220);
            AssetsGrid.Location = new Point(20, 84);
            AssetsGrid.Margin = new Padding(0, 20, 0, 0);
            AssetsGrid.Name = "AssetsGrid";
            AssetsGrid.Size = new Size(930, 382);
            AssetsGrid.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(SearchTextBox);
            flowLayoutPanel1.Controls.Add(SearchBtn);
            flowLayoutPanel1.Location = new Point(23, 23);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(924, 37);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // SearchTextBox
            // 
            SearchTextBox.BackColor = Color.FromArgb(255, 246, 249);
            SearchTextBox.BorderStyle = BorderStyle.FixedSingle;
            SearchTextBox.Font = new Font("Segoe UI", 10F);
            SearchTextBox.ForeColor = Color.FromArgb(51, 51, 51);
            SearchTextBox.Location = new Point(3, 3);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(301, 25);
            SearchTextBox.TabIndex = 0;
            SearchTextBox.Tag = "Search...";
            // 
            // SearchBtn
            // 
            SearchBtn.Location = new Point(310, 3);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(75, 25);
            SearchBtn.TabIndex = 1;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = true;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.CommandText = "SELECT asset_name, category, purchase_date, value, status FROM assets";
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // mySqlConnection1
            // 
            mySqlConnection1.ConnectionString = "server=localhost;database=office_asset_manager;user id=root";
            // 
            // mySqlDataAdapter1
            // 
            mySqlDataAdapter1.DeleteCommand = null;
            mySqlDataAdapter1.InsertCommand = null;
            mySqlDataAdapter1.SelectCommand = mySqlCommand1;
            mySqlDataAdapter1.UpdateCommand = null;
            // 
            // AssetManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 605);
            Controls.Add(panel1);
            Name = "AssetManagement";
            Text = "AssetManagement";
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AssetsGrid).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private MySql.Data.MySqlClient.MySqlConnection mySqlConnection1;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private DataGridView AssetsGrid;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox SearchTextBox;
        private Button SearchBtn;
    }
}