namespace Asset_Management_ni_gad
{
    partial class CheckOut
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            mainPanel = new Panel();
            mainLayout = new TableLayoutPanel();
            headerPanel = new Panel();
            lblTitle = new Label();
            filterPanel = new Panel();
            txtSearch = new TextBox();
            btnRefresh = new Button();
            btnSearch = new Button();
            dataPanel = new Panel();
            dgvAssignedAssets = new DataGridView();
            mainPanel.SuspendLayout();
            mainLayout.SuspendLayout();
            headerPanel.SuspendLayout();
            filterPanel.SuspendLayout();
            dataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAssignedAssets).BeginInit();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(255, 211, 220);
            mainPanel.Controls.Add(mainLayout);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new Padding(10);
            mainPanel.Size = new Size(1211, 666);
            mainPanel.TabIndex = 0;
            // 
            // mainLayout
            // 
            mainLayout.ColumnCount = 1;
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainLayout.Controls.Add(headerPanel, 0, 0);
            mainLayout.Controls.Add(filterPanel, 0, 1);
            mainLayout.Controls.Add(dataPanel, 0, 2);
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.Location = new Point(10, 10);
            mainLayout.Name = "mainLayout";
            mainLayout.RowCount = 3;
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            mainLayout.Size = new Size(1191, 646);
            mainLayout.TabIndex = 0;
            // 
            // headerPanel
            // 
            headerPanel.Controls.Add(lblTitle);
            headerPanel.Dock = DockStyle.Fill;
            headerPanel.Location = new Point(3, 3);
            headerPanel.Name = "headerPanel";
            headerPanel.Padding = new Padding(10, 5, 10, 5);
            headerPanel.Size = new Size(1185, 54);
            headerPanel.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Dock = DockStyle.Left;
            lblTitle.Font = new Font("Berlin Sans FB", 18F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(217, 58, 102);
            lblTitle.Location = new Point(10, 5);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(99, 26);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Cleaning";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // filterPanel
            // 
            filterPanel.Controls.Add(txtSearch);
            filterPanel.Controls.Add(btnRefresh);
            filterPanel.Controls.Add(btnSearch);
            filterPanel.Dock = DockStyle.Fill;
            filterPanel.Location = new Point(3, 63);
            filterPanel.Name = "filterPanel";
            filterPanel.Padding = new Padding(10, 5, 10, 5);
            filterPanel.Size = new Size(1185, 44);
            filterPanel.TabIndex = 1;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Font = new Font("Berlin Sans FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(10, 8);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search Check-In...";
            txtSearch.Size = new Size(908, 24);
            txtSearch.TabIndex = 0;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.BackColor = Color.FromArgb(217, 58, 102);
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Berlin Sans FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(1046, 7);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(100, 25);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.BackColor = Color.FromArgb(217, 58, 102);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Berlin Sans FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(928, 8);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 25);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // dataPanel
            // 
            dataPanel.Controls.Add(dgvAssignedAssets);
            dataPanel.Dock = DockStyle.Fill;
            dataPanel.Location = new Point(3, 113);
            dataPanel.Name = "dataPanel";
            dataPanel.Padding = new Padding(10);
            dataPanel.Size = new Size(1185, 530);
            dataPanel.TabIndex = 2;
            // 
            // dgvAssignedAssets
            // 
            dgvAssignedAssets.AllowUserToAddRows = false;
            dgvAssignedAssets.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 228, 235);
            dgvAssignedAssets.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvAssignedAssets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAssignedAssets.BackgroundColor = Color.FromArgb(255, 246, 249);
            dgvAssignedAssets.BorderStyle = BorderStyle.None;
            dgvAssignedAssets.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAssignedAssets.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(217, 58, 102);
            dataGridViewCellStyle2.Font = new Font("Berlin Sans FB", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(217, 58, 102);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvAssignedAssets.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvAssignedAssets.ColumnHeadersHeight = 40;
            dgvAssignedAssets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 246, 249);
            dataGridViewCellStyle3.Font = new Font("Berlin Sans FB", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.Padding = new Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 211, 220);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvAssignedAssets.DefaultCellStyle = dataGridViewCellStyle3;
            dgvAssignedAssets.Dock = DockStyle.Fill;
            dgvAssignedAssets.EnableHeadersVisualStyles = false;
            dgvAssignedAssets.GridColor = Color.FromArgb(255, 211, 220);
            dgvAssignedAssets.Location = new Point(10, 10);
            dgvAssignedAssets.Name = "dgvAssignedAssets";
            dgvAssignedAssets.ReadOnly = true;
            dgvAssignedAssets.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvAssignedAssets.RowHeadersVisible = false;
            dgvAssignedAssets.RowTemplate.Height = 35;
            dgvAssignedAssets.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAssignedAssets.Size = new Size(1165, 510);
            dgvAssignedAssets.TabIndex = 1;
            // 
            // CheckOut
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1211, 666);
            Controls.Add(mainPanel);
            Font = new Font("Berlin Sans FB", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "CheckOut";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Asset Return Management";
            mainPanel.ResumeLayout(false);
            mainLayout.ResumeLayout(false);
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            filterPanel.ResumeLayout(false);
            filterPanel.PerformLayout();
            dataPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAssignedAssets).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel filterPanel;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel dataPanel;
        private System.Windows.Forms.DataGridView dgvAssignedAssets;
    }
}