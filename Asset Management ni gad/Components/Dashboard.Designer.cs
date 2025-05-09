namespace Asset_Management_ni_gad
{
    partial class Dashboard
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            AssignmentsGrid = new DataGridView();
            TotalAssigned = new Label();
            AssignedLabel = new Label();
            panel2 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            TotalAssets = new Label();
            TotalAssetlabel = new Label();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            MainPanel = new Panel();
            tableLayoutPanel7 = new TableLayoutPanel();
            tableLayoutPanel8 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            panel4 = new Panel();
            TotalUnderMaintenance = new Label();
            label8 = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            panel5 = new Panel();
            TotalEmployee = new Label();
            label10 = new Label();
            tableLayoutPanel6 = new TableLayoutPanel();
            panel6 = new Panel();
            TotalPastDue = new Label();
            label12 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel3 = new Panel();
            TotalAvailable = new Label();
            label6 = new Label();
            panel8 = new Panel();
            ((System.ComponentModel.ISupportInitialize)AssignmentsGrid).BeginInit();
            panel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            MainPanel.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            panel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            panel6.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel3.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // AssignmentsGrid
            // 
            AssignmentsGrid.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 211, 220);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(51, 51, 51);
            AssignmentsGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            AssignmentsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AssignmentsGrid.BackgroundColor = Color.FromArgb(255, 246, 249);
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(255, 79, 129);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            AssignmentsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            AssignmentsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(217, 58, 102);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            AssignmentsGrid.DefaultCellStyle = dataGridViewCellStyle6;
            AssignmentsGrid.Dock = DockStyle.Fill;
            AssignmentsGrid.EnableHeadersVisualStyles = false;
            AssignmentsGrid.GridColor = Color.FromArgb(255, 211, 220);
            AssignmentsGrid.Location = new Point(30, 10);
            AssignmentsGrid.Margin = new Padding(30, 10, 30, 30);
            AssignmentsGrid.Name = "AssignmentsGrid";
            AssignmentsGrid.ReadOnly = true;
            AssignmentsGrid.Size = new Size(1209, 434);
            AssignmentsGrid.TabIndex = 1;
            // 
            // TotalAssigned
            // 
            TotalAssigned.AutoSize = true;
            TotalAssigned.Font = new Font("Berlin Sans FB", 12F);
            TotalAssigned.ForeColor = Color.FromArgb(217, 58, 102);
            TotalAssigned.Location = new Point(17, 48);
            TotalAssigned.Name = "TotalAssigned";
            TotalAssigned.Size = new Size(36, 18);
            TotalAssigned.TabIndex = 8;
            TotalAssigned.Text = "200";
            // 
            // AssignedLabel
            // 
            AssignedLabel.AutoSize = true;
            AssignedLabel.Font = new Font("Berlin Sans FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AssignedLabel.ForeColor = Color.FromArgb(217, 58, 102);
            AssignedLabel.Location = new Point(17, 13);
            AssignedLabel.Name = "AssignedLabel";
            AssignedLabel.Size = new Size(79, 21);
            AssignedLabel.TabIndex = 7;
            AssignedLabel.Text = "Assigned";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 211, 220);
            panel2.Controls.Add(TotalAssigned);
            panel2.Controls.Add(AssignedLabel);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(1, 1);
            panel2.Margin = new Padding(1);
            panel2.Name = "panel2";
            panel2.Size = new Size(400, 73);
            panel2.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.FromArgb(217, 58, 102);
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(panel2, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(433, 10);
            tableLayoutPanel2.Margin = new Padding(10);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(402, 75);
            tableLayoutPanel2.TabIndex = 11;
            // 
            // TotalAssets
            // 
            TotalAssets.AutoSize = true;
            TotalAssets.Font = new Font("Berlin Sans FB", 12F);
            TotalAssets.ForeColor = Color.FromArgb(217, 58, 102);
            TotalAssets.Location = new Point(17, 48);
            TotalAssets.Name = "TotalAssets";
            TotalAssets.Size = new Size(36, 18);
            TotalAssets.TabIndex = 8;
            TotalAssets.Text = "200";
            // 
            // TotalAssetlabel
            // 
            TotalAssetlabel.AutoSize = true;
            TotalAssetlabel.Font = new Font("Berlin Sans FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TotalAssetlabel.ForeColor = Color.FromArgb(217, 58, 102);
            TotalAssetlabel.Location = new Point(17, 13);
            TotalAssetlabel.Name = "TotalAssetlabel";
            TotalAssetlabel.Size = new Size(104, 21);
            TotalAssetlabel.TabIndex = 7;
            TotalAssetlabel.Text = "Total Assets";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 211, 220);
            panel1.Controls.Add(TotalAssets);
            panel1.Controls.Add(TotalAssetlabel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(1, 1);
            panel1.Margin = new Padding(1);
            panel1.Name = "panel1";
            panel1.Size = new Size(401, 73);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(217, 58, 102);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(10, 10);
            tableLayoutPanel1.Margin = new Padding(10);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(403, 75);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // MainPanel
            // 
            MainPanel.Controls.Add(tableLayoutPanel7);
            MainPanel.Controls.Add(tableLayoutPanel8);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1269, 665);
            MainPanel.TabIndex = 3;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel7.Controls.Add(AssignmentsGrid, 0, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(0, 191);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel7.Size = new Size(1269, 474);
            tableLayoutPanel7.TabIndex = 2;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 3;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666718F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel8.Controls.Add(tableLayoutPanel4, 2, 1);
            tableLayoutPanel8.Controls.Add(tableLayoutPanel5, 1, 1);
            tableLayoutPanel8.Controls.Add(tableLayoutPanel6, 0, 1);
            tableLayoutPanel8.Controls.Add(tableLayoutPanel3, 2, 0);
            tableLayoutPanel8.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel8.Controls.Add(tableLayoutPanel1, 0, 0);
            tableLayoutPanel8.Dock = DockStyle.Top;
            tableLayoutPanel8.Location = new Point(0, 0);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 2;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Size = new Size(1269, 191);
            tableLayoutPanel8.TabIndex = 17;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = Color.FromArgb(217, 58, 102);
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(panel4, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(855, 105);
            tableLayoutPanel4.Margin = new Padding(10);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(404, 76);
            tableLayoutPanel4.TabIndex = 22;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(255, 211, 220);
            panel4.Controls.Add(TotalUnderMaintenance);
            panel4.Controls.Add(label8);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(1, 1);
            panel4.Margin = new Padding(1);
            panel4.Name = "panel4";
            panel4.Size = new Size(402, 74);
            panel4.TabIndex = 0;
            // 
            // TotalUnderMaintenance
            // 
            TotalUnderMaintenance.AutoSize = true;
            TotalUnderMaintenance.Font = new Font("Berlin Sans FB", 12F);
            TotalUnderMaintenance.ForeColor = Color.FromArgb(217, 58, 102);
            TotalUnderMaintenance.Location = new Point(17, 48);
            TotalUnderMaintenance.Name = "TotalUnderMaintenance";
            TotalUnderMaintenance.Size = new Size(36, 18);
            TotalUnderMaintenance.TabIndex = 8;
            TotalUnderMaintenance.Text = "200";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Berlin Sans FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(217, 58, 102);
            label8.Location = new Point(17, 13);
            label8.Name = "label8";
            label8.Size = new Size(168, 21);
            label8.TabIndex = 7;
            label8.Text = "Under Maintenance";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.BackColor = Color.FromArgb(217, 58, 102);
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(panel5, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(433, 105);
            tableLayoutPanel5.Margin = new Padding(10);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(402, 76);
            tableLayoutPanel5.TabIndex = 21;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(255, 211, 220);
            panel5.Controls.Add(TotalEmployee);
            panel5.Controls.Add(label10);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(1, 1);
            panel5.Margin = new Padding(1);
            panel5.Name = "panel5";
            panel5.Size = new Size(400, 74);
            panel5.TabIndex = 0;
            // 
            // TotalEmployee
            // 
            TotalEmployee.AutoSize = true;
            TotalEmployee.Font = new Font("Berlin Sans FB", 12F);
            TotalEmployee.ForeColor = Color.FromArgb(217, 58, 102);
            TotalEmployee.Location = new Point(17, 48);
            TotalEmployee.Name = "TotalEmployee";
            TotalEmployee.Size = new Size(36, 18);
            TotalEmployee.TabIndex = 8;
            TotalEmployee.Text = "200";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Berlin Sans FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(217, 58, 102);
            label10.Location = new Point(17, 13);
            label10.Name = "label10";
            label10.Size = new Size(88, 21);
            label10.TabIndex = 7;
            label10.Text = "Employee";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.BackColor = Color.FromArgb(217, 58, 102);
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(panel6, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(10, 105);
            tableLayoutPanel6.Margin = new Padding(10);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(403, 76);
            tableLayoutPanel6.TabIndex = 20;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(255, 211, 220);
            panel6.Controls.Add(TotalPastDue);
            panel6.Controls.Add(label12);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(1, 1);
            panel6.Margin = new Padding(1);
            panel6.Name = "panel6";
            panel6.Size = new Size(401, 74);
            panel6.TabIndex = 0;
            // 
            // TotalPastDue
            // 
            TotalPastDue.AutoSize = true;
            TotalPastDue.Font = new Font("Berlin Sans FB", 12F);
            TotalPastDue.ForeColor = Color.FromArgb(217, 58, 102);
            TotalPastDue.Location = new Point(17, 48);
            TotalPastDue.Name = "TotalPastDue";
            TotalPastDue.Size = new Size(36, 18);
            TotalPastDue.TabIndex = 8;
            TotalPastDue.Text = "200";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Berlin Sans FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(217, 58, 102);
            label12.Location = new Point(17, 13);
            label12.Name = "label12";
            label12.Size = new Size(83, 21);
            label12.TabIndex = 7;
            label12.Text = "Past Due";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.FromArgb(217, 58, 102);
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(panel3, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(855, 10);
            tableLayoutPanel3.Margin = new Padding(10);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(404, 75);
            tableLayoutPanel3.TabIndex = 17;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 211, 220);
            panel3.Controls.Add(TotalAvailable);
            panel3.Controls.Add(label6);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(1, 1);
            panel3.Margin = new Padding(1);
            panel3.Name = "panel3";
            panel3.Size = new Size(402, 73);
            panel3.TabIndex = 0;
            // 
            // TotalAvailable
            // 
            TotalAvailable.AutoSize = true;
            TotalAvailable.Font = new Font("Berlin Sans FB", 12F);
            TotalAvailable.ForeColor = Color.FromArgb(217, 58, 102);
            TotalAvailable.Location = new Point(17, 48);
            TotalAvailable.Name = "TotalAvailable";
            TotalAvailable.Size = new Size(36, 18);
            TotalAvailable.TabIndex = 8;
            TotalAvailable.Text = "200";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Berlin Sans FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(217, 58, 102);
            label6.Location = new Point(17, 13);
            label6.Name = "label6";
            label6.Size = new Size(88, 21);
            label6.TabIndex = 7;
            label6.Text = "Available";
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(255, 211, 220);
            panel8.Controls.Add(MainPanel);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(1269, 665);
            panel8.TabIndex = 5;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(255, 246, 249);
            ClientSize = new Size(1269, 665);
            Controls.Add(panel8);
            Name = "Dashboard";
            Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)AssignmentsGrid).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            MainPanel.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel8.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView AssignmentsGrid;
        private Label TotalAssigned;
        private Label AssignedLabel;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel2;
        private Label TotalAssets;
        private Label TotalAssetlabel;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel MainPanel;
        private Panel panel8;
        private TableLayoutPanel tableLayoutPanel7;
        private TableLayoutPanel tableLayoutPanel8;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panel4;
        private Label TotalUnderMaintenance;
        private Label label8;
        private TableLayoutPanel tableLayoutPanel5;
        private Panel panel5;
        private Label TotalEmployee;
        private Label label10;
        private TableLayoutPanel tableLayoutPanel6;
        private Panel panel6;
        private Label TotalPastDue;
        private Label label12;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel3;
        private Label TotalAvailable;
        private Label label6;
    }
}