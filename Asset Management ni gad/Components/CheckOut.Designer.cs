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
            btnCheckOut = new Button();
            txtSearch = new TextBox();
            btnClean = new Button();
            btnSearch = new Button();
            dataPanel = new Panel();
            dgvBookings = new DataGridView();
            mainPanel.SuspendLayout();
            mainLayout.SuspendLayout();
            headerPanel.SuspendLayout();
            filterPanel.SuspendLayout();
            dataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookings).BeginInit();
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
            mainPanel.Size = new Size(938, 666);
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
            mainLayout.Size = new Size(918, 646);
            mainLayout.TabIndex = 0;
            // 
            // headerPanel
            // 
            headerPanel.Controls.Add(lblTitle);
            headerPanel.Dock = DockStyle.Fill;
            headerPanel.Location = new Point(3, 3);
            headerPanel.Name = "headerPanel";
            headerPanel.Padding = new Padding(10, 5, 10, 5);
            headerPanel.Size = new Size(912, 54);
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
            filterPanel.Controls.Add(btnCheckOut);
            filterPanel.Controls.Add(txtSearch);
            filterPanel.Controls.Add(btnClean);
            filterPanel.Controls.Add(btnSearch);
            filterPanel.Dock = DockStyle.Fill;
            filterPanel.Location = new Point(3, 63);
            filterPanel.Name = "filterPanel";
            filterPanel.Padding = new Padding(10, 5, 10, 5);
            filterPanel.Size = new Size(912, 44);
            filterPanel.TabIndex = 1;
            // 
            // btnCheckOut
            // 
            btnCheckOut.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCheckOut.BackColor = Color.FromArgb(217, 58, 102);
            btnCheckOut.FlatAppearance.BorderSize = 0;
            btnCheckOut.FlatStyle = FlatStyle.Flat;
            btnCheckOut.Font = new Font("Berlin Sans FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCheckOut.ForeColor = Color.White;
            btnCheckOut.Location = new Point(800, 8);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(88, 25);
            btnCheckOut.TabIndex = 3;
            btnCheckOut.Text = "Check-Out";
            btnCheckOut.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Font = new Font("Berlin Sans FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(10, 8);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search Check-In...";
            txtSearch.Size = new Size(635, 24);
            txtSearch.TabIndex = 0;
            // 
            // btnClean
            // 
            btnClean.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClean.BackColor = Color.FromArgb(217, 58, 102);
            btnClean.FlatAppearance.BorderSize = 0;
            btnClean.FlatStyle = FlatStyle.Flat;
            btnClean.Font = new Font("Berlin Sans FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClean.ForeColor = Color.White;
            btnClean.Location = new Point(725, 8);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(69, 25);
            btnClean.TabIndex = 2;
            btnClean.Text = "Clean";
            btnClean.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.BackColor = Color.FromArgb(217, 58, 102);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Berlin Sans FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(655, 8);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(64, 25);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // dataPanel
            // 
            dataPanel.Controls.Add(dgvBookings);
            dataPanel.Dock = DockStyle.Fill;
            dataPanel.Location = new Point(3, 113);
            dataPanel.Name = "dataPanel";
            dataPanel.Padding = new Padding(10);
            dataPanel.Size = new Size(912, 530);
            dataPanel.TabIndex = 2;
            // 
            // dgvBookings
            // 
            dgvBookings.AllowUserToAddRows = false;
            dgvBookings.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 228, 235);
            dgvBookings.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvBookings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBookings.BackgroundColor = Color.FromArgb(255, 246, 249);
            dgvBookings.BorderStyle = BorderStyle.None;
            dgvBookings.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvBookings.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(217, 58, 102);
            dataGridViewCellStyle2.Font = new Font("Berlin Sans FB", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(217, 58, 102);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvBookings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvBookings.ColumnHeadersHeight = 40;
            dgvBookings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 246, 249);
            dataGridViewCellStyle3.Font = new Font("Berlin Sans FB", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.Padding = new Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 211, 220);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvBookings.DefaultCellStyle = dataGridViewCellStyle3;
            dgvBookings.Dock = DockStyle.Fill;
            dgvBookings.EnableHeadersVisualStyles = false;
            dgvBookings.GridColor = Color.FromArgb(255, 211, 220);
            dgvBookings.Location = new Point(10, 10);
            dgvBookings.Name = "dgvBookings";
            dgvBookings.ReadOnly = true;
            dgvBookings.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvBookings.RowHeadersVisible = false;
            dgvBookings.RowTemplate.Height = 35;
            dgvBookings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBookings.Size = new Size(892, 510);
            dgvBookings.TabIndex = 1;
            // 
            // CheckOut
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 666);
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
            ((System.ComponentModel.ISupportInitialize)dgvBookings).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel filterPanel;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel dataPanel;
        private System.Windows.Forms.DataGridView dgvBookings;
        private Button btnCheckOut;
    }
}