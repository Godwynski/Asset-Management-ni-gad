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
            dtpCheckOut = new DateTimePicker();
            label5 = new Label();
            panel2 = new Panel();
            btnCheckIn = new Button();
            btnCreateAssignment = new Button();
            panel7 = new Panel();
            panel8 = new Panel();
            lblAmount = new Label();
            label9 = new Label();
            button5 = new Button();
            button7 = new Button();
            panel4 = new Panel();
            Employee = new Label();
            button3 = new Button();
            btnSearchRoom = new Button();
            dgvRooms = new DataGridView();
            txtSearchRoom = new TextBox();
            label3 = new Label();
            panel5 = new Panel();
            dtpCheckIn = new DateTimePicker();
            label4 = new Label();
            panel3 = new Panel();
            btnSearchGuest = new Button();
            txtSearchGuest = new TextBox();
            dgvGuests = new DataGridView();
            label2 = new Label();
            dataPanel = new Panel();
            dgvRecentLogs = new DataGridView();
            panel1 = new Panel();
            btnSearchRecent = new Button();
            label7 = new Label();
            txtSearchRecent = new TextBox();
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
            ((System.ComponentModel.ISupportInitialize)dgvRooms).BeginInit();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGuests).BeginInit();
            dataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentLogs).BeginInit();
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
            panel6.Controls.Add(dtpCheckOut);
            panel6.Controls.Add(label5);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(601, 198);
            panel6.Name = "panel6";
            panel6.Size = new Size(593, 52);
            panel6.TabIndex = 6;
            // 
            // dtpCheckOut
            // 
            dtpCheckOut.CustomFormat = "MM/dd/yyyy hh:mm tt";
            dtpCheckOut.Dock = DockStyle.Fill;
            dtpCheckOut.Font = new Font("Segoe UI", 10F);
            dtpCheckOut.Format = DateTimePickerFormat.Custom;
            dtpCheckOut.Location = new Point(0, 18);
            dtpCheckOut.Margin = new Padding(0);
            dtpCheckOut.Name = "dtpCheckOut";
            dtpCheckOut.ShowUpDown = true;
            dtpCheckOut.Size = new Size(593, 25);
            dtpCheckOut.TabIndex = 14;
            dtpCheckOut.Value = new DateTime(2025, 6, 6, 19, 36, 7, 816);
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
            panel2.Controls.Add(btnCheckIn);
            panel2.Controls.Add(btnCreateAssignment);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(601, 256);
            panel2.Name = "panel2";
            panel2.Size = new Size(593, 55);
            panel2.TabIndex = 2;
            // 
            // btnCheckIn
            // 
            btnCheckIn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCheckIn.BackColor = Color.FromArgb(217, 58, 102);
            btnCheckIn.FlatAppearance.BorderSize = 0;
            btnCheckIn.FlatStyle = FlatStyle.Flat;
            btnCheckIn.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCheckIn.ForeColor = Color.White;
            btnCheckIn.Location = new Point(382, 11);
            btnCheckIn.Name = "btnCheckIn";
            btnCheckIn.Size = new Size(80, 32);
            btnCheckIn.TabIndex = 7;
            btnCheckIn.Text = "Check-In";
            btnCheckIn.UseVisualStyleBackColor = false;
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
            panel8.Controls.Add(lblAmount);
            panel8.Controls.Add(label9);
            panel8.Controls.Add(button5);
            panel8.Controls.Add(button7);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(592, 55);
            panel8.TabIndex = 3;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("Berlin Sans FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAmount.ForeColor = Color.FromArgb(217, 58, 102);
            lblAmount.Location = new Point(234, 18);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(48, 21);
            lblAmount.TabIndex = 15;
            lblAmount.Text = "4329";
            lblAmount.TextAlign = ContentAlignment.MiddleLeft;
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
            panel4.Controls.Add(btnSearchRoom);
            panel4.Controls.Add(dgvRooms);
            panel4.Controls.Add(txtSearchRoom);
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
            // btnSearchRoom
            // 
            btnSearchRoom.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearchRoom.BackColor = Color.FromArgb(217, 58, 102);
            btnSearchRoom.FlatAppearance.BorderSize = 0;
            btnSearchRoom.FlatStyle = FlatStyle.Flat;
            btnSearchRoom.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearchRoom.ForeColor = Color.White;
            btnSearchRoom.Location = new Point(468, 23);
            btnSearchRoom.Name = "btnSearchRoom";
            btnSearchRoom.Size = new Size(96, 24);
            btnSearchRoom.TabIndex = 18;
            btnSearchRoom.Text = "Search";
            btnSearchRoom.UseVisualStyleBackColor = false;
            // 
            // dgvRooms
            // 
            dgvRooms.AllowUserToAddRows = false;
            dgvRooms.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 228, 235);
            dgvRooms.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvRooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRooms.BackgroundColor = Color.FromArgb(255, 246, 249);
            dgvRooms.BorderStyle = BorderStyle.None;
            dgvRooms.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvRooms.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(217, 58, 102);
            dataGridViewCellStyle2.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(217, 58, 102);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvRooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvRooms.ColumnHeadersHeight = 40;
            dgvRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 246, 249);
            dataGridViewCellStyle3.Font = new Font("Berlin Sans FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.Padding = new Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 211, 220);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvRooms.DefaultCellStyle = dataGridViewCellStyle3;
            dgvRooms.Dock = DockStyle.Bottom;
            dgvRooms.EnableHeadersVisualStyles = false;
            dgvRooms.GridColor = Color.FromArgb(255, 211, 220);
            dgvRooms.Location = new Point(0, 51);
            dgvRooms.Name = "dgvRooms";
            dgvRooms.ReadOnly = true;
            dgvRooms.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvRooms.RowHeadersVisible = false;
            dgvRooms.RowTemplate.Height = 35;
            dgvRooms.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRooms.Size = new Size(593, 138);
            dgvRooms.TabIndex = 17;
            // 
            // txtSearchRoom
            // 
            txtSearchRoom.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearchRoom.Font = new Font("Berlin Sans FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchRoom.Location = new Point(3, 24);
            txtSearchRoom.Name = "txtSearchRoom";
            txtSearchRoom.PlaceholderText = "Search Room...";
            txtSearchRoom.Size = new Size(459, 24);
            txtSearchRoom.TabIndex = 16;
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
            panel5.Controls.Add(dtpCheckIn);
            panel5.Controls.Add(label4);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(3, 198);
            panel5.Name = "panel5";
            panel5.Size = new Size(592, 52);
            panel5.TabIndex = 2;
            // 
            // dtpCheckIn
            // 
            dtpCheckIn.CustomFormat = "MM/dd/yyyy hh:mm tt";
            dtpCheckIn.Dock = DockStyle.Fill;
            dtpCheckIn.Font = new Font("Segoe UI", 10F);
            dtpCheckIn.Format = DateTimePickerFormat.Custom;
            dtpCheckIn.Location = new Point(0, 18);
            dtpCheckIn.Margin = new Padding(0);
            dtpCheckIn.Name = "dtpCheckIn";
            dtpCheckIn.ShowUpDown = true;
            dtpCheckIn.Size = new Size(592, 25);
            dtpCheckIn.TabIndex = 3;
            dtpCheckIn.Value = new DateTime(2025, 6, 6, 19, 36, 7, 816);
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
            panel3.Controls.Add(btnSearchGuest);
            panel3.Controls.Add(txtSearchGuest);
            panel3.Controls.Add(dgvGuests);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(592, 189);
            panel3.TabIndex = 0;
            // 
            // btnSearchGuest
            // 
            btnSearchGuest.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearchGuest.BackColor = Color.FromArgb(217, 58, 102);
            btnSearchGuest.FlatAppearance.BorderSize = 0;
            btnSearchGuest.FlatStyle = FlatStyle.Flat;
            btnSearchGuest.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearchGuest.ForeColor = Color.White;
            btnSearchGuest.Location = new Point(463, 23);
            btnSearchGuest.Name = "btnSearchGuest";
            btnSearchGuest.Size = new Size(96, 24);
            btnSearchGuest.TabIndex = 19;
            btnSearchGuest.Text = "Search";
            btnSearchGuest.UseVisualStyleBackColor = false;
            // 
            // txtSearchGuest
            // 
            txtSearchGuest.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearchGuest.Font = new Font("Berlin Sans FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchGuest.Location = new Point(4, 24);
            txtSearchGuest.Name = "txtSearchGuest";
            txtSearchGuest.PlaceholderText = "Search Guest...";
            txtSearchGuest.Size = new Size(453, 24);
            txtSearchGuest.TabIndex = 3;
            // 
            // dgvGuests
            // 
            dgvGuests.AllowUserToAddRows = false;
            dgvGuests.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 228, 235);
            dgvGuests.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvGuests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGuests.BackgroundColor = Color.FromArgb(255, 246, 249);
            dgvGuests.BorderStyle = BorderStyle.None;
            dgvGuests.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvGuests.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(217, 58, 102);
            dataGridViewCellStyle5.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.Padding = new Padding(5);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(217, 58, 102);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvGuests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvGuests.ColumnHeadersHeight = 40;
            dgvGuests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(255, 246, 249);
            dataGridViewCellStyle6.Font = new Font("Berlin Sans FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle6.Padding = new Padding(5);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(255, 211, 220);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvGuests.DefaultCellStyle = dataGridViewCellStyle6;
            dgvGuests.Dock = DockStyle.Bottom;
            dgvGuests.EnableHeadersVisualStyles = false;
            dgvGuests.GridColor = Color.FromArgb(255, 211, 220);
            dgvGuests.Location = new Point(0, 51);
            dgvGuests.Name = "dgvGuests";
            dgvGuests.ReadOnly = true;
            dgvGuests.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvGuests.RowHeadersVisible = false;
            dgvGuests.RowTemplate.Height = 35;
            dgvGuests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGuests.Size = new Size(592, 138);
            dgvGuests.TabIndex = 14;
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
            dataPanel.Controls.Add(dgvRecentLogs);
            dataPanel.Controls.Add(panel1);
            dataPanel.Dock = DockStyle.Fill;
            dataPanel.Location = new Point(3, 375);
            dataPanel.Name = "dataPanel";
            dataPanel.Padding = new Padding(10);
            dataPanel.Size = new Size(1203, 347);
            dataPanel.TabIndex = 2;
            // 
            // dgvRecentLogs
            // 
            dgvRecentLogs.AllowUserToAddRows = false;
            dgvRecentLogs.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(255, 228, 235);
            dgvRecentLogs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dgvRecentLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecentLogs.BackgroundColor = Color.FromArgb(255, 246, 249);
            dgvRecentLogs.BorderStyle = BorderStyle.None;
            dgvRecentLogs.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvRecentLogs.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(217, 58, 102);
            dataGridViewCellStyle8.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.Padding = new Padding(5);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(217, 58, 102);
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgvRecentLogs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgvRecentLogs.ColumnHeadersHeight = 40;
            dgvRecentLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(255, 246, 249);
            dataGridViewCellStyle9.Font = new Font("Berlin Sans FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle9.Padding = new Padding(5);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(255, 211, 220);
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dgvRecentLogs.DefaultCellStyle = dataGridViewCellStyle9;
            dgvRecentLogs.Dock = DockStyle.Fill;
            dgvRecentLogs.EnableHeadersVisualStyles = false;
            dgvRecentLogs.GridColor = Color.FromArgb(255, 211, 220);
            dgvRecentLogs.Location = new Point(10, 43);
            dgvRecentLogs.Name = "dgvRecentLogs";
            dgvRecentLogs.ReadOnly = true;
            dgvRecentLogs.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvRecentLogs.RowHeadersVisible = false;
            dgvRecentLogs.RowTemplate.Height = 35;
            dgvRecentLogs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecentLogs.Size = new Size(1183, 294);
            dgvRecentLogs.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSearchRecent);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtSearchRecent);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(10, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(1183, 33);
            panel1.TabIndex = 3;
            // 
            // btnSearchRecent
            // 
            btnSearchRecent.BackColor = Color.FromArgb(217, 58, 102);
            btnSearchRecent.FlatAppearance.BorderSize = 0;
            btnSearchRecent.FlatStyle = FlatStyle.Flat;
            btnSearchRecent.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearchRecent.ForeColor = Color.White;
            btnSearchRecent.Location = new Point(498, 5);
            btnSearchRecent.Name = "btnSearchRecent";
            btnSearchRecent.Size = new Size(114, 26);
            btnSearchRecent.TabIndex = 16;
            btnSearchRecent.Text = "Search";
            btnSearchRecent.UseVisualStyleBackColor = false;
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
            // txtSearchRecent
            // 
            txtSearchRecent.Font = new Font("Berlin Sans FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchRecent.Location = new Point(175, 5);
            txtSearchRecent.Name = "txtSearchRecent";
            txtSearchRecent.PlaceholderText = "Search Booking";
            txtSearchRecent.Size = new Size(317, 24);
            txtSearchRecent.TabIndex = 15;
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
            ((System.ComponentModel.ISupportInitialize)dgvRooms).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGuests).EndInit();
            dataPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRecentLogs).EndInit();
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
        private DataGridView dgvRooms;
        private TextBox txtSearchRoom;
        private Label label3;
        private Panel panel5;
        private Label label4;
        private Panel panel3;
        private DataGridView dgvGuests;
        private Label label2;
        private TextBox txtSearchGuest;
        private Label Employee;
        private Button btnSearchRoom;
        private Button btnSearchGuest;
        private Panel panel7;
        private Panel panel2;
        private Button btnCheckIn;
        private Button btnCreateAssignment;
        private Panel dataPanel;
        private DataGridView dgvRecentLogs;
        private Panel panel1;
        private Button btnSearchRecent;
        private Label label7;
        private TextBox txtSearchRecent;
        private DateTimePicker dtpCheckIn;
        private Panel panel6;
        private DateTimePicker dtpCheckOut;
        private Label label5;
        private Panel panel8;
        private Label lblAmount;
        private Label label9;
        private Button button5;
        private Button button7;
    }
}