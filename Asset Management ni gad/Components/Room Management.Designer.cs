namespace Asset_Management_ni_gad
{
    partial class Maintenance
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
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblTitle = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            SidePanel = new Panel();
            label1 = new Label();
            txtCapacity = new TextBox();
            Capacity = new Label();
            txtRoomPrice = new TextBox();
            lblCost = new Label();
            txtRoomName = new TextBox();
            cmbRoomStatus = new ComboBox();
            btnClose = new Button();
            btnCancel = new Button();
            btnAddRoom = new Button();
            lblRecordTitle = new Label();
            lblStatus = new Label();
            dgvRoom = new DataGridView();
            panel2 = new Panel();
            txtSearchRoom = new TextBox();
            btnSearchRoom = new Button();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoom).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 211, 220);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1200, 700);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lblTitle, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 2);
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1200, 700);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Berlin Sans FB", 18F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(217, 58, 102);
            lblTitle.Location = new Point(30, 20);
            lblTitle.Margin = new Padding(30, 20, 0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1170, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Room Management";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 350F));
            tableLayoutPanel3.Controls.Add(SidePanel, 1, 0);
            tableLayoutPanel3.Controls.Add(dgvRoom, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(10, 126);
            tableLayoutPanel3.Margin = new Padding(10);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1180, 564);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // SidePanel
            // 
            SidePanel.BackColor = Color.FromArgb(255, 228, 235);
            SidePanel.BorderStyle = BorderStyle.FixedSingle;
            SidePanel.Controls.Add(label1);
            SidePanel.Controls.Add(txtCapacity);
            SidePanel.Controls.Add(Capacity);
            SidePanel.Controls.Add(txtRoomPrice);
            SidePanel.Controls.Add(lblCost);
            SidePanel.Controls.Add(txtRoomName);
            SidePanel.Controls.Add(cmbRoomStatus);
            SidePanel.Controls.Add(btnClose);
            SidePanel.Controls.Add(btnCancel);
            SidePanel.Controls.Add(btnAddRoom);
            SidePanel.Controls.Add(lblRecordTitle);
            SidePanel.Controls.Add(lblStatus);
            SidePanel.Dock = DockStyle.Fill;
            SidePanel.Location = new Point(833, 3);
            SidePanel.Name = "SidePanel";
            SidePanel.Padding = new Padding(20);
            SidePanel.Size = new Size(344, 558);
            SidePanel.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(217, 58, 102);
            label1.Location = new Point(23, 257);
            label1.Name = "label1";
            label1.Size = new Size(66, 18);
            label1.TabIndex = 17;
            label1.Text = "Capacity";
            // 
            // txtCapacity
            // 
            txtCapacity.Font = new Font("Berlin Sans FB", 11.25F);
            txtCapacity.Location = new Point(24, 278);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(300, 24);
            txtCapacity.TabIndex = 16;
            // 
            // Capacity
            // 
            Capacity.AutoSize = true;
            Capacity.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Capacity.ForeColor = Color.FromArgb(217, 58, 102);
            Capacity.Location = new Point(21, 202);
            Capacity.Name = "Capacity";
            Capacity.Size = new Size(103, 18);
            Capacity.TabIndex = 15;
            Capacity.Text = "Price Per Hour";
            // 
            // txtRoomPrice
            // 
            txtRoomPrice.Font = new Font("Berlin Sans FB", 11.25F);
            txtRoomPrice.Location = new Point(22, 223);
            txtRoomPrice.Name = "txtRoomPrice";
            txtRoomPrice.Size = new Size(300, 24);
            txtRoomPrice.TabIndex = 14;
            // 
            // lblCost
            // 
            lblCost.AutoSize = true;
            lblCost.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCost.ForeColor = Color.FromArgb(217, 58, 102);
            lblCost.Location = new Point(23, 78);
            lblCost.Name = "lblCost";
            lblCost.Size = new Size(47, 18);
            lblCost.TabIndex = 13;
            lblCost.Text = "Room";
            // 
            // txtRoomName
            // 
            txtRoomName.Font = new Font("Berlin Sans FB", 11.25F);
            txtRoomName.Location = new Point(23, 99);
            txtRoomName.Name = "txtRoomName";
            txtRoomName.Size = new Size(300, 24);
            txtRoomName.TabIndex = 12;
            // 
            // cmbRoomStatus
            // 
            cmbRoomStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRoomStatus.Font = new Font("Berlin Sans FB", 11.25F);
            cmbRoomStatus.FormattingEnabled = true;
            cmbRoomStatus.Location = new Point(23, 161);
            cmbRoomStatus.Name = "cmbRoomStatus";
            cmbRoomStatus.Size = new Size(300, 25);
            cmbRoomStatus.TabIndex = 11;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(310, 20);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(20, 20);
            btnClose.TabIndex = 5;
            btnClose.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.BackColor = Color.FromArgb(217, 58, 102);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(168, 504);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 35);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnAddRoom
            // 
            btnAddRoom.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddRoom.BackColor = Color.FromArgb(217, 58, 102);
            btnAddRoom.FlatAppearance.BorderSize = 0;
            btnAddRoom.FlatStyle = FlatStyle.Flat;
            btnAddRoom.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddRoom.ForeColor = Color.White;
            btnAddRoom.Location = new Point(23, 504);
            btnAddRoom.Name = "btnAddRoom";
            btnAddRoom.Size = new Size(150, 35);
            btnAddRoom.TabIndex = 3;
            btnAddRoom.Text = "Add Room";
            btnAddRoom.UseVisualStyleBackColor = false;
            // 
            // lblRecordTitle
            // 
            lblRecordTitle.AutoSize = true;
            lblRecordTitle.Font = new Font("Berlin Sans FB", 15.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblRecordTitle.ForeColor = Color.FromArgb(217, 58, 102);
            lblRecordTitle.Location = new Point(102, 33);
            lblRecordTitle.Name = "lblRecordTitle";
            lblRecordTitle.Size = new Size(155, 23);
            lblRecordTitle.TabIndex = 2;
            lblRecordTitle.Text = "Add / Edit Room";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.FromArgb(217, 58, 102);
            lblStatus.Location = new Point(23, 140);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(47, 18);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "Status";
            // 
            // dgvRoom
            // 
            dgvRoom.AllowUserToAddRows = false;
            dgvRoom.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 228, 235);
            dgvRoom.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvRoom.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRoom.BackgroundColor = Color.FromArgb(255, 246, 249);
            dgvRoom.BorderStyle = BorderStyle.None;
            dgvRoom.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvRoom.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(217, 58, 102);
            dataGridViewCellStyle2.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(217, 58, 102);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvRoom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvRoom.ColumnHeadersHeight = 40;
            dgvRoom.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 246, 249);
            dataGridViewCellStyle3.Font = new Font("Berlin Sans FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.Padding = new Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 211, 220);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvRoom.DefaultCellStyle = dataGridViewCellStyle3;
            dgvRoom.Dock = DockStyle.Fill;
            dgvRoom.EnableHeadersVisualStyles = false;
            dgvRoom.GridColor = Color.FromArgb(255, 211, 220);
            dgvRoom.Location = new Point(20, 20);
            dgvRoom.Margin = new Padding(20);
            dgvRoom.Name = "dgvRoom";
            dgvRoom.ReadOnly = true;
            dgvRoom.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvRoom.RowHeadersVisible = false;
            dgvRoom.RowTemplate.Height = 35;
            dgvRoom.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRoom.Size = new Size(790, 524);
            dgvRoom.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtSearchRoom);
            panel2.Controls.Add(btnSearchRoom);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(20, 68);
            panel2.Margin = new Padding(20, 10, 20, 10);
            panel2.Name = "panel2";
            panel2.Size = new Size(1160, 38);
            panel2.TabIndex = 2;
            // 
            // txtSearchRoom
            // 
            txtSearchRoom.Font = new Font("Berlin Sans FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchRoom.Location = new Point(10, 8);
            txtSearchRoom.Name = "txtSearchRoom";
            txtSearchRoom.PlaceholderText = "Search room...";
            txtSearchRoom.Size = new Size(604, 24);
            txtSearchRoom.TabIndex = 4;
            // 
            // btnSearchRoom
            // 
            btnSearchRoom.BackColor = Color.FromArgb(217, 58, 102);
            btnSearchRoom.FlatAppearance.BorderSize = 0;
            btnSearchRoom.FlatStyle = FlatStyle.Flat;
            btnSearchRoom.Font = new Font("Berlin Sans FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearchRoom.ForeColor = Color.White;
            btnSearchRoom.Location = new Point(620, 8);
            btnSearchRoom.Name = "btnSearchRoom";
            btnSearchRoom.Size = new Size(90, 25);
            btnSearchRoom.TabIndex = 1;
            btnSearchRoom.Text = "Search";
            btnSearchRoom.UseVisualStyleBackColor = false;
            // 
            // Maintenance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 700);
            Controls.Add(panel1);
            Name = "Maintenance";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Maintenance Records";
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            SidePanel.ResumeLayout(false);
            SidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoom).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblTitle;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel SidePanel;
        private Label lblCost;
        private TextBox txtRoomName;
        private ComboBox cmbRoomStatus;
        private Button btnClose;
        private Button btnCancel;
        private Button btnAddRoom;
        private Label lblRecordTitle;
        private Label lblStatus;
        private DataGridView dgvRoom;
        private Panel panel2;
        private Button btnSearchRoom;
        private Label Capacity;
        private TextBox txtRoomPrice;
        private Label label1;
        private TextBox txtCapacity;
        private TextBox txtSearchRoom;
    }
}