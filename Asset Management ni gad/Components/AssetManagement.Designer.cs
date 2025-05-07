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
            ParentPanel = new Panel();
            DeleteAssetPanel = new TableLayoutPanel();
            panel3 = new Panel();
            button7 = new Button();
            CancelDeleteBtn = new Button();
            DeleteBtn = new Button();
            DebugText = new Label();
            EditAssetPanel = new TableLayoutPanel();
            panel5 = new Panel();
            EditCategoryz = new TextBox();
            EditPrice = new TextBox();
            EditStatusComboBox = new ComboBox();
            label13 = new Label();
            button2 = new Button();
            button3 = new Button();
            UpdateAssetBtn = new Button();
            EditNotes = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            EditAssetName = new TextBox();
            label5 = new Label();
            AddAssetPanel = new TableLayoutPanel();
            panel4 = new Panel();
            AddCategory = new TextBox();
            AddStatus = new ComboBox();
            label8 = new Label();
            button1 = new Button();
            AddSubmitBtn = new Button();
            AddNotes = new RichTextBox();
            label10 = new Label();
            label14 = new Label();
            button8 = new Button();
            label9 = new Label();
            AddPrice = new TextBox();
            label11 = new Label();
            AddName = new TextBox();
            label12 = new Label();
            MainPanel = new TableLayoutPanel();
            panel2 = new Panel();
            AddAssetBtn = new Button();
            SearchBtn = new Button();
            SearchTextBox = new TextBox();
            AssetsGrid = new DataGridView();
            ParentPanel.SuspendLayout();
            DeleteAssetPanel.SuspendLayout();
            panel3.SuspendLayout();
            EditAssetPanel.SuspendLayout();
            panel5.SuspendLayout();
            AddAssetPanel.SuspendLayout();
            panel4.SuspendLayout();
            MainPanel.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AssetsGrid).BeginInit();
            SuspendLayout();
            // 
            // ParentPanel
            // 
            ParentPanel.BackColor = Color.FromArgb(255, 211, 220);
            ParentPanel.Controls.Add(DeleteAssetPanel);
            ParentPanel.Controls.Add(EditAssetPanel);
            ParentPanel.Controls.Add(AddAssetPanel);
            ParentPanel.Controls.Add(MainPanel);
            ParentPanel.Dock = DockStyle.Fill;
            ParentPanel.Location = new Point(0, 0);
            ParentPanel.Name = "ParentPanel";
            ParentPanel.Size = new Size(1496, 1061);
            ParentPanel.TabIndex = 2;
            ParentPanel.Resize += Resize;
            // 
            // DeleteAssetPanel
            // 
            DeleteAssetPanel.BackColor = Color.FromArgb(217, 58, 102);
            DeleteAssetPanel.ColumnCount = 1;
            DeleteAssetPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            DeleteAssetPanel.Controls.Add(panel3, 0, 0);
            DeleteAssetPanel.Location = new Point(34, 574);
            DeleteAssetPanel.Name = "DeleteAssetPanel";
            DeleteAssetPanel.RowCount = 1;
            DeleteAssetPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            DeleteAssetPanel.Size = new Size(346, 194);
            DeleteAssetPanel.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 211, 220);
            panel3.Controls.Add(button7);
            panel3.Controls.Add(CancelDeleteBtn);
            panel3.Controls.Add(DeleteBtn);
            panel3.Controls.Add(DebugText);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(340, 188);
            panel3.TabIndex = 5;
            // 
            // button7
            // 
            button7.BackColor = Color.Transparent;
            button7.BackgroundImage = Properties.Resources.close;
            button7.BackgroundImageLayout = ImageLayout.Stretch;
            button7.Cursor = Cursors.Hand;
            button7.FlatAppearance.BorderColor = Color.FromArgb(255, 79, 129);
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Berlin Sans FB Demi", 12F, FontStyle.Bold);
            button7.ForeColor = Color.FromArgb(255, 79, 129);
            button7.Location = new Point(314, 11);
            button7.Margin = new Padding(10, 11, 10, 11);
            button7.Name = "button7";
            button7.Size = new Size(20, 20);
            button7.TabIndex = 20;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // CancelDeleteBtn
            // 
            CancelDeleteBtn.Location = new Point(179, 123);
            CancelDeleteBtn.Name = "CancelDeleteBtn";
            CancelDeleteBtn.Size = new Size(75, 23);
            CancelDeleteBtn.TabIndex = 19;
            CancelDeleteBtn.Text = "No";
            CancelDeleteBtn.UseVisualStyleBackColor = true;
            CancelDeleteBtn.Click += CancelDeleteBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Location = new Point(81, 123);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(75, 23);
            DeleteBtn.TabIndex = 18;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // DebugText
            // 
            DebugText.AutoSize = true;
            DebugText.Font = new Font("Berlin Sans FB", 15.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            DebugText.ForeColor = Color.FromArgb(217, 58, 102);
            DebugText.Location = new Point(23, 56);
            DebugText.Name = "DebugText";
            DebugText.Size = new Size(296, 23);
            DebugText.TabIndex = 16;
            DebugText.Text = "Are you sure you want to delete?";
            // 
            // EditAssetPanel
            // 
            EditAssetPanel.BackColor = Color.FromArgb(217, 58, 102);
            EditAssetPanel.ColumnCount = 1;
            EditAssetPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            EditAssetPanel.Controls.Add(panel5, 0, 0);
            EditAssetPanel.Location = new Point(406, 560);
            EditAssetPanel.Name = "EditAssetPanel";
            EditAssetPanel.RowCount = 1;
            EditAssetPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            EditAssetPanel.Size = new Size(349, 489);
            EditAssetPanel.TabIndex = 8;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(255, 211, 220);
            panel5.Controls.Add(EditCategoryz);
            panel5.Controls.Add(EditPrice);
            panel5.Controls.Add(EditStatusComboBox);
            panel5.Controls.Add(label13);
            panel5.Controls.Add(button2);
            panel5.Controls.Add(button3);
            panel5.Controls.Add(UpdateAssetBtn);
            panel5.Controls.Add(EditNotes);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(EditAssetName);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(343, 483);
            panel5.TabIndex = 7;
            // 
            // EditCategoryz
            // 
            EditCategoryz.Font = new Font("Segoe UI", 12F);
            EditCategoryz.ForeColor = Color.FromArgb(217, 58, 102);
            EditCategoryz.Location = new Point(37, 220);
            EditCategoryz.Name = "EditCategoryz";
            EditCategoryz.Size = new Size(278, 29);
            EditCategoryz.TabIndex = 25;
            // 
            // EditPrice
            // 
            EditPrice.Font = new Font("Segoe UI", 12F);
            EditPrice.ForeColor = Color.FromArgb(217, 58, 102);
            EditPrice.Location = new Point(37, 157);
            EditPrice.Name = "EditPrice";
            EditPrice.Size = new Size(278, 29);
            EditPrice.TabIndex = 24;
            // 
            // EditStatusComboBox
            // 
            EditStatusComboBox.FormattingEnabled = true;
            EditStatusComboBox.Location = new Point(37, 284);
            EditStatusComboBox.Name = "EditStatusComboBox";
            EditStatusComboBox.Size = new Size(278, 23);
            EditStatusComboBox.TabIndex = 22;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Berlin Sans FB", 12F);
            label13.ForeColor = Color.FromArgb(217, 58, 102);
            label13.Location = new Point(37, 257);
            label13.Name = "label13";
            label13.Size = new Size(47, 18);
            label13.TabIndex = 21;
            label13.Text = "Status";
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = Properties.Resources.close;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.FromArgb(255, 79, 129);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Berlin Sans FB Demi", 12F, FontStyle.Bold);
            button2.ForeColor = Color.FromArgb(255, 79, 129);
            button2.Location = new Point(317, 11);
            button2.Margin = new Padding(10, 11, 10, 11);
            button2.Name = "button2";
            button2.Size = new Size(20, 20);
            button2.TabIndex = 19;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(215, 439);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 18;
            button3.Text = "Cancel";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // UpdateAssetBtn
            // 
            UpdateAssetBtn.Location = new Point(53, 439);
            UpdateAssetBtn.Name = "UpdateAssetBtn";
            UpdateAssetBtn.Size = new Size(75, 23);
            UpdateAssetBtn.TabIndex = 17;
            UpdateAssetBtn.Text = "Submit";
            UpdateAssetBtn.UseVisualStyleBackColor = true;
            UpdateAssetBtn.Click += UpdateAssetBtn_Click;
            // 
            // EditNotes
            // 
            EditNotes.Location = new Point(37, 342);
            EditNotes.MaxLength = 30;
            EditNotes.Name = "EditNotes";
            EditNotes.Size = new Size(278, 79);
            EditNotes.TabIndex = 16;
            EditNotes.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Berlin Sans FB", 12F);
            label1.ForeColor = Color.FromArgb(217, 58, 102);
            label1.Location = new Point(37, 314);
            label1.Name = "label1";
            label1.Size = new Size(45, 18);
            label1.TabIndex = 15;
            label1.Text = "Notes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Berlin Sans FB", 15.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(217, 58, 102);
            label2.Location = new Point(127, 28);
            label2.Name = "label2";
            label2.Size = new Size(92, 23);
            label2.TabIndex = 14;
            label2.Text = "Edit Asset";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Berlin Sans FB", 12F);
            label3.ForeColor = Color.FromArgb(217, 58, 102);
            label3.Location = new Point(37, 193);
            label3.Name = "label3";
            label3.Size = new Size(68, 18);
            label3.TabIndex = 12;
            label3.Text = "Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Berlin Sans FB", 12F);
            label4.ForeColor = Color.FromArgb(217, 58, 102);
            label4.Location = new Point(37, 136);
            label4.Name = "label4";
            label4.Size = new Size(40, 18);
            label4.TabIndex = 10;
            label4.Text = "Price";
            // 
            // EditAssetName
            // 
            EditAssetName.Font = new Font("Segoe UI", 12F);
            EditAssetName.ForeColor = Color.FromArgb(217, 58, 102);
            EditAssetName.Location = new Point(37, 91);
            EditAssetName.Name = "EditAssetName";
            EditAssetName.Size = new Size(278, 29);
            EditAssetName.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Berlin Sans FB", 12F);
            label5.ForeColor = Color.FromArgb(217, 58, 102);
            label5.Location = new Point(37, 70);
            label5.Name = "label5";
            label5.Size = new Size(49, 18);
            label5.TabIndex = 8;
            label5.Text = "Name";
            // 
            // AddAssetPanel
            // 
            AddAssetPanel.BackColor = Color.FromArgb(217, 58, 102);
            AddAssetPanel.ColumnCount = 1;
            AddAssetPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            AddAssetPanel.Controls.Add(panel4, 0, 0);
            AddAssetPanel.Location = new Point(775, 560);
            AddAssetPanel.Name = "AddAssetPanel";
            AddAssetPanel.RowCount = 1;
            AddAssetPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            AddAssetPanel.Size = new Size(349, 489);
            AddAssetPanel.TabIndex = 7;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(255, 211, 220);
            panel4.Controls.Add(AddCategory);
            panel4.Controls.Add(AddStatus);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(button1);
            panel4.Controls.Add(AddSubmitBtn);
            panel4.Controls.Add(AddNotes);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(button8);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(AddPrice);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(AddName);
            panel4.Controls.Add(label12);
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(343, 483);
            panel4.TabIndex = 7;
            // 
            // AddCategory
            // 
            AddCategory.Font = new Font("Segoe UI", 12F);
            AddCategory.ForeColor = Color.FromArgb(217, 58, 102);
            AddCategory.Location = new Point(37, 220);
            AddCategory.Name = "AddCategory";
            AddCategory.Size = new Size(278, 29);
            AddCategory.TabIndex = 31;
            // 
            // AddStatus
            // 
            AddStatus.FormattingEnabled = true;
            AddStatus.Location = new Point(37, 284);
            AddStatus.Name = "AddStatus";
            AddStatus.Size = new Size(278, 23);
            AddStatus.TabIndex = 30;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Berlin Sans FB", 12F);
            label8.ForeColor = Color.FromArgb(217, 58, 102);
            label8.Location = new Point(37, 257);
            label8.Name = "label8";
            label8.Size = new Size(47, 18);
            label8.TabIndex = 29;
            label8.Text = "Status";
            // 
            // button1
            // 
            button1.Location = new Point(215, 439);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 27;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            // 
            // AddSubmitBtn
            // 
            AddSubmitBtn.Location = new Point(53, 439);
            AddSubmitBtn.Name = "AddSubmitBtn";
            AddSubmitBtn.Size = new Size(75, 23);
            AddSubmitBtn.TabIndex = 26;
            AddSubmitBtn.Text = "Submit";
            AddSubmitBtn.UseVisualStyleBackColor = true;
            AddSubmitBtn.Click += AddSubmitBtn_Click;
            // 
            // AddNotes
            // 
            AddNotes.Location = new Point(37, 342);
            AddNotes.MaxLength = 30;
            AddNotes.Name = "AddNotes";
            AddNotes.Size = new Size(278, 79);
            AddNotes.TabIndex = 25;
            AddNotes.Text = "";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Berlin Sans FB", 12F);
            label10.ForeColor = Color.FromArgb(217, 58, 102);
            label10.Location = new Point(37, 314);
            label10.Name = "label10";
            label10.Size = new Size(45, 18);
            label10.TabIndex = 24;
            label10.Text = "Notes";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Berlin Sans FB", 12F);
            label14.ForeColor = Color.FromArgb(217, 58, 102);
            label14.Location = new Point(37, 136);
            label14.Name = "label14";
            label14.Size = new Size(40, 18);
            label14.TabIndex = 23;
            label14.Text = "Price";
            // 
            // button8
            // 
            button8.BackColor = Color.Transparent;
            button8.BackgroundImage = Properties.Resources.close;
            button8.BackgroundImageLayout = ImageLayout.Stretch;
            button8.Cursor = Cursors.Hand;
            button8.FlatAppearance.BorderColor = Color.FromArgb(255, 79, 129);
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Berlin Sans FB Demi", 12F, FontStyle.Bold);
            button8.ForeColor = Color.FromArgb(255, 79, 129);
            button8.Location = new Point(317, 11);
            button8.Margin = new Padding(10, 11, 10, 11);
            button8.Name = "button8";
            button8.Size = new Size(20, 20);
            button8.TabIndex = 19;
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Berlin Sans FB", 15.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(217, 58, 102);
            label9.Location = new Point(127, 28);
            label9.Name = "label9";
            label9.Size = new Size(96, 23);
            label9.TabIndex = 14;
            label9.Text = "Add Asset";
            // 
            // AddPrice
            // 
            AddPrice.Font = new Font("Segoe UI", 12F);
            AddPrice.ForeColor = Color.FromArgb(217, 58, 102);
            AddPrice.Location = new Point(37, 157);
            AddPrice.Name = "AddPrice";
            AddPrice.Size = new Size(278, 29);
            AddPrice.TabIndex = 11;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Berlin Sans FB", 12F);
            label11.ForeColor = Color.FromArgb(217, 58, 102);
            label11.Location = new Point(37, 195);
            label11.Name = "label11";
            label11.Size = new Size(68, 18);
            label11.TabIndex = 10;
            label11.Text = "Category";
            // 
            // AddName
            // 
            AddName.Font = new Font("Segoe UI", 12F);
            AddName.ForeColor = Color.FromArgb(217, 58, 102);
            AddName.Location = new Point(37, 91);
            AddName.Name = "AddName";
            AddName.Size = new Size(278, 29);
            AddName.TabIndex = 9;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Berlin Sans FB", 12F);
            label12.ForeColor = Color.FromArgb(217, 58, 102);
            label12.Location = new Point(37, 70);
            label12.Name = "label12";
            label12.Size = new Size(49, 18);
            label12.TabIndex = 8;
            label12.Text = "Name";
            // 
            // MainPanel
            // 
            MainPanel.ColumnCount = 1;
            MainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            MainPanel.Controls.Add(panel2, 0, 0);
            MainPanel.Controls.Add(AssetsGrid, 0, 1);
            MainPanel.Dock = DockStyle.Top;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Padding = new Padding(20);
            MainPanel.RowCount = 2;
            MainPanel.RowStyles.Add(new RowStyle());
            MainPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 492F));
            MainPanel.Size = new Size(1496, 554);
            MainPanel.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(AddAssetBtn);
            panel2.Controls.Add(SearchBtn);
            panel2.Controls.Add(SearchTextBox);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(23, 23);
            panel2.Name = "panel2";
            panel2.Size = new Size(1450, 26);
            panel2.TabIndex = 2;
            // 
            // AddAssetBtn
            // 
            AddAssetBtn.Anchor = AnchorStyles.Right;
            AddAssetBtn.Location = new Point(1375, 1);
            AddAssetBtn.Name = "AddAssetBtn";
            AddAssetBtn.Size = new Size(75, 25);
            AddAssetBtn.TabIndex = 2;
            AddAssetBtn.Text = "Add Asset";
            AddAssetBtn.UseVisualStyleBackColor = true;
            AddAssetBtn.Click += AddAssetBtn_Click;
            // 
            // SearchBtn
            // 
            SearchBtn.Location = new Point(455, 0);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(75, 25);
            SearchBtn.TabIndex = 1;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = true;
            SearchBtn.Click += SearchBtn_Click_1;
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
            // AssetsGrid
            // 
            AssetsGrid.AllowUserToAddRows = false;
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
            AssetsGrid.Location = new Point(20, 72);
            AssetsGrid.Margin = new Padding(0, 20, 0, 0);
            AssetsGrid.Name = "AssetsGrid";
            AssetsGrid.ReadOnly = true;
            AssetsGrid.Size = new Size(1456, 472);
            AssetsGrid.TabIndex = 0;
            // 
            // AssetManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1496, 1061);
            Controls.Add(ParentPanel);
            Name = "AssetManagement";
            Text = "AssetManagement";
            ParentPanel.ResumeLayout(false);
            DeleteAssetPanel.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            EditAssetPanel.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            AddAssetPanel.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            MainPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AssetsGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel ParentPanel;
        private DataGridView AssetsGrid;
        private TableLayoutPanel MainPanel;
        private TextBox SearchTextBox;
        private Button SearchBtn;
        private Panel panel2;
        private Button AddAssetBtn;
        private Panel panel3;
        private Label DebugText;
        private Button CancelDeleteBtn;
        private Button DeleteBtn;
        private Button button7;
        private TableLayoutPanel AddAssetPanel;
        private Panel panel4;
        private Button button8;
        private Button button10;
        private Label label9;
        private TextBox AddPrice;
        private Label label11;
        private TextBox AddName;
        private Label label12;
        private TableLayoutPanel EditAssetPanel;
        private Panel panel5;
        private Button button2;
        private Button button3;
        private Button UpdateAssetBtn;
        private RichTextBox EditNotes;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox EditAssetName;
        private Label label5;
        private ComboBox EditCategory;
        private TableLayoutPanel DeleteAssetPanel;
        private ComboBox EditStatusComboBox;
        private Label label13;
        private ComboBox AddStatus;
        private Label label8;
        private ComboBox comboBox4;
        private Button button1;
        private Button AddSubmitBtn;
        private RichTextBox AddNotes;
        private Label label10;
        private Label label14;
        private TextBox AddCategory;
        private TextBox EditPrice;
        private TextBox EditCategoryz;
    }
}