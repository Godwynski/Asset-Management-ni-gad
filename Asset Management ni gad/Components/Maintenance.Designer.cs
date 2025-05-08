namespace Asset_Management_ni_gad
{
    partial class Maintenance
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
            MainPanel = new TableLayoutPanel();
            panel2 = new Panel();
            AddAssetBtn = new Button();
            SearchBtn = new Button();
            SearchTextBox = new TextBox();
            MaintenanceGrid = new DataGridView();
            panel1.SuspendLayout();
            MainPanel.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MaintenanceGrid).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 211, 220);
            panel1.Controls.Add(MainPanel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1351, 658);
            panel1.TabIndex = 1;
            // 
            // MainPanel
            // 
            MainPanel.ColumnCount = 1;
            MainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            MainPanel.Controls.Add(panel2, 0, 0);
            MainPanel.Controls.Add(MaintenanceGrid, 0, 1);
            MainPanel.Dock = DockStyle.Top;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Padding = new Padding(20);
            MainPanel.RowCount = 2;
            MainPanel.RowStyles.Add(new RowStyle());
            MainPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 492F));
            MainPanel.Size = new Size(1351, 554);
            MainPanel.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(AddAssetBtn);
            panel2.Controls.Add(SearchBtn);
            panel2.Controls.Add(SearchTextBox);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(23, 23);
            panel2.Name = "panel2";
            panel2.Size = new Size(1305, 26);
            panel2.TabIndex = 2;
            // 
            // AddAssetBtn
            // 
            AddAssetBtn.Anchor = AnchorStyles.Right;
            AddAssetBtn.Location = new Point(2480, -36);
            AddAssetBtn.Name = "AddAssetBtn";
            AddAssetBtn.Size = new Size(75, 25);
            AddAssetBtn.TabIndex = 2;
            AddAssetBtn.Text = "Add Asset";
            AddAssetBtn.UseVisualStyleBackColor = true;
            // 
            // SearchBtn
            // 
            SearchBtn.Location = new Point(455, 0);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(75, 25);
            SearchBtn.TabIndex = 1;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = true;
            // 
            // SearchTextBox
            // 
            SearchTextBox.BackColor = Color.FromArgb(255, 246, 249);
            SearchTextBox.BorderStyle = BorderStyle.FixedSingle;
            SearchTextBox.Font = new Font("Segoe UI", 10F);
            SearchTextBox.ForeColor = Color.FromArgb(51, 51, 51);
            SearchTextBox.Location = new Point(0, 0);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(449, 25);
            SearchTextBox.TabIndex = 0;
            SearchTextBox.Tag = "Search...";
            // 
            // MaintenanceGrid
            // 
            MaintenanceGrid.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 211, 220);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(51, 51, 51);
            MaintenanceGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            MaintenanceGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            MaintenanceGrid.BackgroundColor = Color.FromArgb(255, 246, 249);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 79, 129);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            MaintenanceGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            MaintenanceGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(217, 58, 102);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            MaintenanceGrid.DefaultCellStyle = dataGridViewCellStyle3;
            MaintenanceGrid.Dock = DockStyle.Fill;
            MaintenanceGrid.EnableHeadersVisualStyles = false;
            MaintenanceGrid.GridColor = Color.FromArgb(255, 211, 220);
            MaintenanceGrid.Location = new Point(20, 72);
            MaintenanceGrid.Margin = new Padding(0, 20, 0, 0);
            MaintenanceGrid.Name = "MaintenanceGrid";
            MaintenanceGrid.ReadOnly = true;
            MaintenanceGrid.Size = new Size(1311, 472);
            MaintenanceGrid.TabIndex = 0;
            // 
            // Maintenance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1351, 658);
            Controls.Add(panel1);
            Name = "Maintenance";
            Text = "Maintenance";
            panel1.ResumeLayout(false);
            MainPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MaintenanceGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel MainPanel;
        private Panel panel2;
        private Button AddAssetBtn;
        private Button SearchBtn;
        private TextBox SearchTextBox;
        private DataGridView MaintenanceGrid;
    }
}