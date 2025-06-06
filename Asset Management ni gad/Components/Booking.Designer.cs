namespace Asset_Management_ni_gad.Components
{
    partial class Booking
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel6 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            panel2 = new Panel();
            button4 = new Button();
            btnCreateAssignment = new Button();
            panel7 = new Panel();
            panel8 = new Panel();
            label1 = new Label();
            label9 = new Label();
            button5 = new Button();
            button7 = new Button();
            panel4 = new Panel();
            Employee = new Label();
            button3 = new Button();
            button2 = new Button();
            dgvEmployeeSearch = new DataGridView();
            txtEmployeeSearch = new TextBox();
            label3 = new Label();
            panel5 = new Panel();
            dateTimePicker3 = new DateTimePicker();
            label4 = new Label();
            panel3 = new Panel();
            button1 = new Button();
            AssetSearch = new TextBox();
            dgvAssetSearch = new DataGridView();
            label2 = new Label();
            dataPanel = new Panel();
            dgvRecentAssignment = new DataGridView();
            panel1 = new Panel();
            button6 = new Button();
            label7 = new Label();
            txtAssetSearch = new TextBox();
            mainPanel = new Panel();
            headerPanel.SuspendLayout();
            mainLayout.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel6.SuspendLayout();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
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
            lblTitle.Size = new Size(94, 26);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Booking";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // headerPanel
            // 
            headerPanel.Controls.Add(lblTitle);
            headerPanel.Dock = DockStyle.Fill;
            headerPanel.Location = new Point(3, 3);
            headerPanel.Name = "headerPanel";
            headerPanel.Padding = new Padding(10, 5, 10, 5);
            headerPanel.Size = new Size(1203, 40);
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
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 326F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 249F));
            mainLayout.Size = new Size(1209, 725);
            mainLayout.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 49);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 301F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(1203, 320);
            tableLayoutPanel2.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel6, 1, 1);
            tableLayoutPanel1.Controls.Add(panel2, 1, 2);
            tableLayoutPanel1.Controls.Add(panel7, 0, 2);
            tableLayoutPanel1.Controls.Add(panel4, 1, 0);
            tableLayoutPanel1.Controls.Add(panel5, 0, 1);
            tableLayoutPanel1.Controls.Add(panel3, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 195F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.Size = new Size(1197, 314);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.Controls.Add(dateTimePicker1);
            panel6.Controls.Add(label5);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(601, 198);
            panel6.Name = "panel6";
            panel6.Size = new Size(593, 52);
            panel6.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm tt";
            dateTimePicker1.Dock = DockStyle.Fill;
            dateTimePicker1.Font = new Font("Segoe UI", 10F);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(0, 18);
            dateTimePicker1.Margin = new Padding(0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.Size = new Size(593, 25);
            dateTimePicker1.TabIndex = 14;
            dateTimePicker1.Value = new DateTime(2025, 6, 6, 19, 36, 7, 816);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(217, 58, 102);
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(79, 18);
            label5.TabIndex = 13;
            label5.Text = "Check-Out";
            // 
            // panel2
            // 
            panel2.Controls.Add(button4);
            panel2.Controls.Add(btnCreateAssignment);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(601, 256);
            panel2.Name = "panel2";
            panel2.Size = new Size(593, 55);
            panel2.TabIndex = 2;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.BackColor = Color.FromArgb(217, 58, 102);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(400, 11);
            button4.Name = "button4";
            button4.Size = new Size(80, 32);
            button4.TabIndex = 7;
            button4.Text = "Check-In";
            button4.UseVisualStyleBackColor = false;
            // 
            // btnCreateAssignment
            // 
            btnCreateAssignment.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCreateAssignment.BackColor = Color.FromArgb(217, 58, 102);
            btnCreateAssignment.FlatAppearance.BorderSize = 0;
            btnCreateAssignment.FlatStyle = FlatStyle.Flat;
            btnCreateAssignment.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreateAssignment.ForeColor = Color.White;
            btnCreateAssignment.Location = new Point(486, 11);
            btnCreateAssignment.Name = "btnCreateAssignment";
            btnCreateAssignment.Size = new Size(91, 32);
            btnCreateAssignment.TabIndex = 6;
            btnCreateAssignment.Text = "Book Now";
            btnCreateAssignment.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            panel7.Controls.Add(panel8);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(3, 256);
            panel7.Name = "panel7";
            panel7.Size = new Size(592, 55);
            panel7.TabIndex = 5;
            // 
            // panel8
            // 
            panel8.Controls.Add(label1);
            panel8.Controls.Add(label9);
            panel8.Controls.Add(button5);
            panel8.Controls.Add(button7);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(592, 55);
            panel8.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Berlin Sans FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(217, 58, 102);
            label1.Location = new Point(234, 18);
            label1.Name = "label1";
            label1.Size = new Size(48, 21);
            label1.TabIndex = 15;
            label1.Text = "4329";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Berlin Sans FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(217, 58, 102);
            label9.Location = new Point(0, 17);
            label9.Name = "label9";
            label9.Size = new Size(228, 21);
            label9.TabIndex = 14;
            label9.Text = "Calculated amount to pay:";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button5.BackColor = Color.FromArgb(217, 58, 102);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(792, 11);
            button5.Name = "button5";
            button5.Size = new Size(80, 32);
            button5.TabIndex = 7;
            button5.Text = "Check-In";
            button5.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button7.BackColor = Color.FromArgb(217, 58, 102);
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.White;
            button7.Location = new Point(878, 11);
            button7.Name = "button7";
            button7.Size = new Size(91, 32);
            button7.TabIndex = 6;
            button7.Text = "Book Now";
            button7.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(Employee);
            panel4.Controls.Add(button3);
            panel4.Controls.Add(button2);
            panel4.Controls.Add(dgvEmployeeSearch);
            panel4.Controls.Add(txtEmployeeSearch);
            panel4.Controls.Add(label3);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(601, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(593, 189);
            panel4.TabIndex = 3;
            // 
            // Employee
            // 
            Employee.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Employee.AutoSize = true;
            Employee.Font = new Font("Berlin Sans FB", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            Employee.ForeColor = Color.FromArgb(217, 58, 102);
            Employee.Location = new Point(486, 26);
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
            button3.Location = new Point(1226, 20);
            button3.Name = "button3";
            button3.Size = new Size(96, 24);
            button3.TabIndex = 19;
            button3.Text = "Search";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(217, 58, 102);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(468, 23);
            button2.Name = "button2";
            button2.Size = new Size(96, 24);
            button2.TabIndex = 18;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = false;
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
            dgvEmployeeSearch.Size = new Size(593, 138);
            dgvEmployeeSearch.TabIndex = 17;
            // 
            // txtEmployeeSearch
            // 
            txtEmployeeSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmployeeSearch.Font = new Font("Berlin Sans FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmployeeSearch.Location = new Point(3, 24);
            txtEmployeeSearch.Name = "txtEmployeeSearch";
            txtEmployeeSearch.PlaceholderText = "Search Room...";
            txtEmployeeSearch.Size = new Size(459, 24);
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
            label3.Size = new Size(88, 18);
            label3.TabIndex = 13;
            label3.Text = "Select Room";
            // 
            // panel5
            // 
            panel5.Controls.Add(dateTimePicker3);
            panel5.Controls.Add(label4);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(3, 198);
            panel5.Name = "panel5";
            panel5.Size = new Size(592, 52);
            panel5.TabIndex = 2;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.CustomFormat = "MM/dd/yyyy hh:mm tt";
            dateTimePicker3.Dock = DockStyle.Fill;
            dateTimePicker3.Font = new Font("Segoe UI", 10F);
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.Location = new Point(0, 18);
            dateTimePicker3.Margin = new Padding(0);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.ShowUpDown = true;
            dateTimePicker3.Size = new Size(592, 25);
            dateTimePicker3.TabIndex = 3;
            dateTimePicker3.Value = new DateTime(2025, 6, 6, 19, 36, 7, 816);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(217, 58, 102);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(59, 18);
            label4.TabIndex = 13;
            label4.Text = "Checl-In";
            // 
            // panel3
            // 
            panel3.Controls.Add(button1);
            panel3.Controls.Add(AssetSearch);
            panel3.Controls.Add(dgvAssetSearch);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(592, 189);
            panel3.TabIndex = 0;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(217, 58, 102);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(463, 23);
            button1.Name = "button1";
            button1.Size = new Size(96, 24);
            button1.TabIndex = 19;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            // 
            // AssetSearch
            // 
            AssetSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AssetSearch.Font = new Font("Berlin Sans FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AssetSearch.Location = new Point(4, 24);
            AssetSearch.Name = "AssetSearch";
            AssetSearch.PlaceholderText = "Search Guest...";
            AssetSearch.Size = new Size(453, 24);
            AssetSearch.TabIndex = 3;
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
            dgvAssetSearch.Size = new Size(592, 138);
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
            label2.Size = new Size(86, 18);
            label2.TabIndex = 13;
            label2.Text = "Select Guest";
            // 
            // dataPanel
            // 
            dataPanel.Controls.Add(dgvRecentAssignment);
            dataPanel.Controls.Add(panel1);
            dataPanel.Dock = DockStyle.Fill;
            dataPanel.Location = new Point(3, 375);
            dataPanel.Name = "dataPanel";
            dataPanel.Padding = new Padding(10);
            dataPanel.Size = new Size(1203, 347);
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
            dgvRecentAssignment.Size = new Size(1183, 294);
            dgvRecentAssignment.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(button6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtAssetSearch);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(10, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(1183, 33);
            panel1.TabIndex = 3;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button6.BackColor = Color.FromArgb(217, 58, 102);
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.White;
            button6.Location = new Point(531, 3);
            button6.Name = "button6";
            button6.Size = new Size(114, 26);
            button6.TabIndex = 16;
            button6.Text = "Search";
            button6.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Left;
            label7.Font = new Font("Berlin Sans FB", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(217, 58, 102);
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(169, 26);
            label7.TabIndex = 2;
            label7.Text = "Recent Booking";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtAssetSearch
            // 
            txtAssetSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAssetSearch.Font = new Font("Berlin Sans FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAssetSearch.Location = new Point(208, 4);
            txtAssetSearch.Name = "txtAssetSearch";
            txtAssetSearch.PlaceholderText = "Search Booking";
            txtAssetSearch.Size = new Size(317, 24);
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
            mainPanel.Size = new Size(1229, 745);
            mainPanel.TabIndex = 1;
            // 
            // Booking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1229, 745);
            Controls.Add(mainPanel);
            Name = "Booking";
            Text = "AssetAssignment";
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            mainLayout.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel2.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
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
        private Panel panel4;
        private Button button3;
        private DataGridView dgvEmployeeSearch;
        private TextBox txtEmployeeSearch;
        private Label label3;
        private Panel panel5;
        private Label label4;
        private Panel panel3;
        private DataGridView dgvAssetSearch;
        private Label label2;
        private TextBox AssetSearch;
        private Label Employee;
        private Button button2;
        private Button button1;
        private Panel panel7;
        private Panel panel2;
        private Button button4;
        private Button btnCreateAssignment;
        private Panel dataPanel;
        private DataGridView dgvRecentAssignment;
        private Panel panel1;
        private Button button6;
        private Label label7;
        private TextBox txtAssetSearch;
        private DateTimePicker dateTimePicker3;
        private Panel panel6;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private Panel panel8;
        private Label label1;
        private Label label9;
        private Button button5;
        private Button button7;
    }
}