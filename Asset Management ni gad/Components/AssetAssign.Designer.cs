namespace Asset_Management_ni_gad.Components
{
    partial class AssetAssign
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            lblTitle = new Label();
            headerPanel = new Panel();
            mainLayout = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnCreateAssignment = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel6 = new Panel();
            dtpReturnDate = new DateTimePicker();
            label5 = new Label();
            panel4 = new Panel();
            Employee = new Label();
            button3 = new Button();
            dgvEmployeeSearch = new DataGridView();
            txtEmployeeSearch = new TextBox();
            label3 = new Label();
            panel5 = new Panel();
            dtpAssignDate = new DateTimePicker();
            label4 = new Label();
            panel3 = new Panel();
            Asset = new Label();
            AssetSearch = new TextBox();
            button2 = new Button();
            dgvAssetSearch = new DataGridView();
            label2 = new Label();
            dataPanel = new Panel();
            dgvRecentAssignment = new DataGridView();
            panel1 = new Panel();
            label7 = new Label();
            txtAssetSearch = new TextBox();
            mainPanel = new Panel();
            headerPanel.SuspendLayout();
            mainLayout.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployeeSearch).BeginInit();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAssetSearch).BeginInit();
            dataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentAssignment).BeginInit();
            panel1.SuspendLayout();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Dock = DockStyle.Left;
            lblTitle.Font = new Font("Berlin Sans FB", 18F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(217, 58, 102);
            lblTitle.Location = new Point(10, 5);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(132, 26);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Assign Asset";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // headerPanel
            // 
            headerPanel.Controls.Add(lblTitle);
            headerPanel.Dock = DockStyle.Fill;
            headerPanel.Location = new Point(3, 3);
            headerPanel.Name = "headerPanel";
            headerPanel.Padding = new Padding(10, 5, 10, 5);
            headerPanel.Size = new Size(956, 40);
            headerPanel.TabIndex = 0;
            // 
            // mainLayout
            // 
            mainLayout.ColumnCount = 1;
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainLayout.Controls.Add(tableLayoutPanel2, 0, 1);
            mainLayout.Controls.Add(headerPanel, 0, 0);
            mainLayout.Controls.Add(dataPanel, 0, 2);
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.Location = new Point(10, 10);
            mainLayout.Name = "mainLayout";
            mainLayout.RowCount = 3;
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 302F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 273F));
            mainLayout.Size = new Size(962, 909);
            mainLayout.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(btnCreateAssignment, 0, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 49);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 258F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(956, 296);
            tableLayoutPanel2.TabIndex = 6;
            // 
            // btnCreateAssignment
            // 
            btnCreateAssignment.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCreateAssignment.BackColor = Color.FromArgb(217, 58, 102);
            btnCreateAssignment.FlatAppearance.BorderSize = 0;
            btnCreateAssignment.FlatStyle = FlatStyle.Flat;
            btnCreateAssignment.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreateAssignment.ForeColor = Color.White;
            btnCreateAssignment.Location = new Point(803, 261);
            btnCreateAssignment.Name = "btnCreateAssignment";
            btnCreateAssignment.Size = new Size(150, 32);
            btnCreateAssignment.TabIndex = 5;
            btnCreateAssignment.Text = "Assign";
            btnCreateAssignment.UseVisualStyleBackColor = false;
            btnCreateAssignment.Click += btnCreateAssignment_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel6, 1, 1);
            tableLayoutPanel1.Controls.Add(panel4, 1, 0);
            tableLayoutPanel1.Controls.Add(panel5, 0, 1);
            tableLayoutPanel1.Controls.Add(panel3, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 195F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(950, 252);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.Controls.Add(dtpReturnDate);
            panel6.Controls.Add(label5);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(478, 198);
            panel6.Name = "panel6";
            panel6.Size = new Size(469, 51);
            panel6.TabIndex = 4;
            // 
            // dtpReturnDate
            // 
            dtpReturnDate.Dock = DockStyle.Fill;
            dtpReturnDate.Location = new Point(0, 18);
            dtpReturnDate.Name = "dtpReturnDate";
            dtpReturnDate.Size = new Size(469, 23);
            dtpReturnDate.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(217, 58, 102);
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(117, 18);
            label5.TabIndex = 13;
            label5.Text = "Expected Return";
            // 
            // panel4
            // 
            panel4.Controls.Add(Employee);
            panel4.Controls.Add(button3);
            panel4.Controls.Add(dgvEmployeeSearch);
            panel4.Controls.Add(txtEmployeeSearch);
            panel4.Controls.Add(label3);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(478, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(469, 189);
            panel4.TabIndex = 3;
            // 
            // Employee
            // 
            Employee.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Employee.AutoSize = true;
            Employee.Font = new Font("Berlin Sans FB", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            Employee.ForeColor = Color.FromArgb(217, 58, 102);
            Employee.Location = new Point(362, 26);
            Employee.Name = "Employee";
            Employee.Size = new Size(0, 18);
            Employee.TabIndex = 20;
            Employee.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.BackColor = Color.FromArgb(217, 58, 102);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(1102, 20);
            button3.Name = "button3";
            button3.Size = new Size(96, 24);
            button3.TabIndex = 19;
            button3.Text = "Search";
            button3.UseVisualStyleBackColor = false;
            // 
            // dgvEmployeeSearch
            // 
            dgvEmployeeSearch.AllowUserToAddRows = false;
            dgvEmployeeSearch.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 228, 235);
            dgvEmployeeSearch.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvEmployeeSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployeeSearch.BackgroundColor = Color.FromArgb(255, 246, 249);
            dgvEmployeeSearch.BorderStyle = BorderStyle.None;
            dgvEmployeeSearch.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvEmployeeSearch.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(217, 58, 102);
            dataGridViewCellStyle2.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(217, 58, 102);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvEmployeeSearch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvEmployeeSearch.ColumnHeadersHeight = 40;
            dgvEmployeeSearch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 246, 249);
            dataGridViewCellStyle3.Font = new Font("Berlin Sans FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.Padding = new Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 211, 220);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvEmployeeSearch.DefaultCellStyle = dataGridViewCellStyle3;
            dgvEmployeeSearch.Dock = DockStyle.Bottom;
            dgvEmployeeSearch.EnableHeadersVisualStyles = false;
            dgvEmployeeSearch.GridColor = Color.FromArgb(255, 211, 220);
            dgvEmployeeSearch.Location = new Point(0, 51);
            dgvEmployeeSearch.Name = "dgvEmployeeSearch";
            dgvEmployeeSearch.ReadOnly = true;
            dgvEmployeeSearch.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvEmployeeSearch.RowHeadersVisible = false;
            dgvEmployeeSearch.RowTemplate.Height = 35;
            dgvEmployeeSearch.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployeeSearch.Size = new Size(469, 138);
            dgvEmployeeSearch.TabIndex = 17;
            // 
            // txtEmployeeSearch
            // 
            txtEmployeeSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmployeeSearch.Font = new Font("Berlin Sans FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmployeeSearch.Location = new Point(3, 24);
            txtEmployeeSearch.Name = "txtEmployeeSearch";
            txtEmployeeSearch.PlaceholderText = "Search Employee...";
            txtEmployeeSearch.Size = new Size(335, 24);
            txtEmployeeSearch.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(217, 58, 102);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(115, 18);
            label3.TabIndex = 13;
            label3.Text = "Select Employee";
            // 
            // panel5
            // 
            panel5.Controls.Add(dtpAssignDate);
            panel5.Controls.Add(label4);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(3, 198);
            panel5.Name = "panel5";
            panel5.Size = new Size(469, 51);
            panel5.TabIndex = 2;
            // 
            // dtpAssignDate
            // 
            dtpAssignDate.Dock = DockStyle.Fill;
            dtpAssignDate.Location = new Point(0, 18);
            dtpAssignDate.Name = "dtpAssignDate";
            dtpAssignDate.Size = new Size(469, 23);
            dtpAssignDate.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(217, 58, 102);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(119, 18);
            label4.TabIndex = 13;
            label4.Text = "Assignment Date";
            // 
            // panel3
            // 
            panel3.Controls.Add(Asset);
            panel3.Controls.Add(AssetSearch);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(dgvAssetSearch);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(469, 189);
            panel3.TabIndex = 0;
            // 
            // Asset
            // 
            Asset.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Asset.AutoSize = true;
            Asset.Font = new Font("Berlin Sans FB", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            Asset.ForeColor = Color.FromArgb(217, 58, 102);
            Asset.Location = new Point(361, 24);
            Asset.Name = "Asset";
            Asset.Size = new Size(0, 18);
            Asset.TabIndex = 19;
            Asset.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AssetSearch
            // 
            AssetSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AssetSearch.Font = new Font("Berlin Sans FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AssetSearch.Location = new Point(4, 24);
            AssetSearch.Name = "AssetSearch";
            AssetSearch.PlaceholderText = "Asset Search...";
            AssetSearch.Size = new Size(330, 24);
            AssetSearch.TabIndex = 3;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(217, 58, 102);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(1102, 24);
            button2.Name = "button2";
            button2.Size = new Size(96, 24);
            button2.TabIndex = 18;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = false;
            // 
            // dgvAssetSearch
            // 
            dgvAssetSearch.AllowUserToAddRows = false;
            dgvAssetSearch.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 228, 235);
            dgvAssetSearch.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvAssetSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAssetSearch.BackgroundColor = Color.FromArgb(255, 246, 249);
            dgvAssetSearch.BorderStyle = BorderStyle.None;
            dgvAssetSearch.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAssetSearch.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(217, 58, 102);
            dataGridViewCellStyle5.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.Padding = new Padding(5);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(217, 58, 102);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvAssetSearch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvAssetSearch.ColumnHeadersHeight = 40;
            dgvAssetSearch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(255, 246, 249);
            dataGridViewCellStyle6.Font = new Font("Berlin Sans FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle6.Padding = new Padding(5);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(255, 211, 220);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvAssetSearch.DefaultCellStyle = dataGridViewCellStyle6;
            dgvAssetSearch.Dock = DockStyle.Bottom;
            dgvAssetSearch.EnableHeadersVisualStyles = false;
            dgvAssetSearch.GridColor = Color.FromArgb(255, 211, 220);
            dgvAssetSearch.Location = new Point(0, 51);
            dgvAssetSearch.Name = "dgvAssetSearch";
            dgvAssetSearch.ReadOnly = true;
            dgvAssetSearch.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvAssetSearch.RowHeadersVisible = false;
            dgvAssetSearch.RowTemplate.Height = 35;
            dgvAssetSearch.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAssetSearch.Size = new Size(469, 138);
            dgvAssetSearch.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(217, 58, 102);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(83, 18);
            label2.TabIndex = 13;
            label2.Text = "Select Asset";
            // 
            // dataPanel
            // 
            dataPanel.Controls.Add(dgvRecentAssignment);
            dataPanel.Controls.Add(panel1);
            dataPanel.Dock = DockStyle.Fill;
            dataPanel.Location = new Point(3, 351);
            dataPanel.Name = "dataPanel";
            dataPanel.Padding = new Padding(10);
            dataPanel.Size = new Size(956, 555);
            dataPanel.TabIndex = 2;
            // 
            // dgvRecentAssignment
            // 
            dgvRecentAssignment.AllowUserToAddRows = false;
            dgvRecentAssignment.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(255, 228, 235);
            dgvRecentAssignment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dgvRecentAssignment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecentAssignment.BackgroundColor = Color.FromArgb(255, 246, 249);
            dgvRecentAssignment.BorderStyle = BorderStyle.None;
            dgvRecentAssignment.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvRecentAssignment.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(217, 58, 102);
            dataGridViewCellStyle8.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.Padding = new Padding(5);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(217, 58, 102);
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgvRecentAssignment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgvRecentAssignment.ColumnHeadersHeight = 40;
            dgvRecentAssignment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(255, 246, 249);
            dataGridViewCellStyle9.Font = new Font("Berlin Sans FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle9.Padding = new Padding(5);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(255, 211, 220);
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dgvRecentAssignment.DefaultCellStyle = dataGridViewCellStyle9;
            dgvRecentAssignment.Dock = DockStyle.Fill;
            dgvRecentAssignment.EnableHeadersVisualStyles = false;
            dgvRecentAssignment.GridColor = Color.FromArgb(255, 211, 220);
            dgvRecentAssignment.Location = new Point(10, 43);
            dgvRecentAssignment.Name = "dgvRecentAssignment";
            dgvRecentAssignment.ReadOnly = true;
            dgvRecentAssignment.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvRecentAssignment.RowHeadersVisible = false;
            dgvRecentAssignment.RowTemplate.Height = 35;
            dgvRecentAssignment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecentAssignment.Size = new Size(936, 502);
            dgvRecentAssignment.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtAssetSearch);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(10, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(936, 33);
            panel1.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Left;
            label7.Font = new Font("Berlin Sans FB", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(217, 58, 102);
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(202, 26);
            label7.TabIndex = 2;
            label7.Text = "Recent Assignment";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtAssetSearch
            // 
            txtAssetSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAssetSearch.Font = new Font("Berlin Sans FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAssetSearch.Location = new Point(208, 4);
            txtAssetSearch.Name = "txtAssetSearch";
            txtAssetSearch.PlaceholderText = "Search Asset";
            txtAssetSearch.Size = new Size(203, 24);
            txtAssetSearch.TabIndex = 15;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(255, 211, 220);
            mainPanel.Controls.Add(mainLayout);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new Padding(10);
            mainPanel.Size = new Size(982, 929);
            mainPanel.TabIndex = 1;
            // 
            // AssetAssign
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 929);
            Controls.Add(mainPanel);
            Name = "AssetAssign";
            Text = "AssetAssignment";
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            mainLayout.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployeeSearch).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAssetSearch).EndInit();
            dataPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRecentAssignment).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            mainPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label lblTitle;
        private Panel headerPanel;
        private TableLayoutPanel mainLayout;
        private Panel mainPanel;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel6;
        private DateTimePicker dtpReturnDate;
        private Label label5;
        private Panel panel4;
        private Button button3;
        private DataGridView dgvEmployeeSearch;
        private TextBox txtEmployeeSearch;
        private Label label3;
        private Panel panel5;
        private DateTimePicker dtpAssignDate;
        private Label label4;
        private Panel panel3;
        private Button button2;
        private TextBox txtAssetSearch;
        private DataGridView dgvAssetSearch;
        private Label label2;
        private Panel dataPanel;
        private DataGridView dgvRecentAssignment;
        private Panel panel1;
        private TextBox AssetSearch;
        private Label label7;
        private Button btnCreateAssignment;
        private Label Employee;
        private Label Asset;
    }
}