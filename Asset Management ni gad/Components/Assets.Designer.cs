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
            EditAssetPanel = new Panel();
            panel5 = new Panel();
            button2 = new Button();
            label2 = new Label();
            EditAssetName = new TextBox();
            label5 = new Label();
            EditPrice = new TextBox();
            label4 = new Label();
            EditCategoryz = new TextBox();
            label3 = new Label();
            EditStatusComboBox = new ComboBox();
            label13 = new Label();
            EditNotes = new RichTextBox();
            label1 = new Label();
            button3 = new Button();
            UpdateAssetBtn = new Button();
            DeleteAssetPanel = new Panel();
            panel3 = new Panel();
            button7 = new Button();
            DebugText = new Label();
            DeleteBtn = new Button();
            CancelDeleteBtn = new Button();
            AddAssetPanel = new Panel();
            panel4 = new Panel();
            button8 = new Button();
            label9 = new Label();
            AddName = new TextBox();
            label12 = new Label();
            AddPrice = new TextBox();
            label11 = new Label();
            AddCategory = new TextBox();
            AddStatus = new ComboBox();
            label8 = new Label();
            AddNotes = new RichTextBox();
            label10 = new Label();
            label14 = new Label();
            button1 = new Button();
            AddSubmitBtn = new Button();
            MainPanel = new TableLayoutPanel();
            panel2 = new Panel();
            SearchPanel = new Panel();
            SearchTextBox = new TextBox();
            SearchBtn = new Button();
            AddAssetBtn = new Button();
            AssetsGrid = new DataGridView();
            ParentPanel.SuspendLayout();
            EditAssetPanel.SuspendLayout();
            panel5.SuspendLayout();
            DeleteAssetPanel.SuspendLayout();
            panel3.SuspendLayout();
            AddAssetPanel.SuspendLayout();
            panel4.SuspendLayout();
            MainPanel.SuspendLayout();
            panel2.SuspendLayout();
            SearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AssetsGrid).BeginInit();
            SuspendLayout();
            // 
            // ParentPanel
            // 
            ParentPanel.BackColor = Color.FromArgb(255, 246, 249);
            ParentPanel.Controls.Add(EditAssetPanel);
            ParentPanel.Controls.Add(DeleteAssetPanel);
            ParentPanel.Controls.Add(AddAssetPanel);
            ParentPanel.Controls.Add(MainPanel);
            ParentPanel.Dock = DockStyle.Fill;
            ParentPanel.Location = new Point(0, 0);
            ParentPanel.Name = "ParentPanel";
            ParentPanel.Size = new Size(1200, 980);
            ParentPanel.TabIndex = 0;
            // 
            // EditAssetPanel
            // 
            EditAssetPanel.BackColor = Color.White;
            EditAssetPanel.BorderStyle = BorderStyle.FixedSingle;
            EditAssetPanel.Controls.Add(panel5);
            EditAssetPanel.Location = new Point(30, 361);
            EditAssetPanel.Name = "EditAssetPanel";
            EditAssetPanel.Size = new Size(350, 500);
            EditAssetPanel.TabIndex = 1;
            EditAssetPanel.Visible = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(button2);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(EditAssetName);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(EditPrice);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(EditCategoryz);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(EditStatusComboBox);
            panel5.Controls.Add(label13);
            panel5.Controls.Add(EditNotes);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(button3);
            panel5.Controls.Add(UpdateAssetBtn);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(20);
            panel5.Size = new Size(348, 498);
            panel5.TabIndex = 0;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = Properties.Resources.close;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(318, 20);
            button2.Name = "button2";
            button2.Size = new Size(20, 20);
            button2.TabIndex = 0;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Berlin Sans FB", 18F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(255, 79, 129);
            label2.Location = new Point(20, 20);
            label2.Name = "label2";
            label2.Size = new Size(139, 30);
            label2.TabIndex = 1;
            label2.Text = "EDIT ASSET";
            // 
            // EditAssetName
            // 
            EditAssetName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            EditAssetName.BorderStyle = BorderStyle.FixedSingle;
            EditAssetName.Font = new Font("Berlin Sans FB", 12F);
            EditAssetName.Location = new Point(20, 90);
            EditAssetName.Name = "EditAssetName";
            EditAssetName.Size = new Size(300, 25);
            EditAssetName.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Berlin Sans FB", 12F);
            label5.ForeColor = Color.FromArgb(136, 136, 136);
            label5.Location = new Point(20, 70);
            label5.Name = "label5";
            label5.Size = new Size(49, 18);
            label5.TabIndex = 3;
            label5.Text = "Name";
            // 
            // EditPrice
            // 
            EditPrice.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            EditPrice.BorderStyle = BorderStyle.FixedSingle;
            EditPrice.Font = new Font("Berlin Sans FB", 12F);
            EditPrice.Location = new Point(20, 150);
            EditPrice.Name = "EditPrice";
            EditPrice.Size = new Size(300, 25);
            EditPrice.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Berlin Sans FB", 12F);
            label4.ForeColor = Color.FromArgb(136, 136, 136);
            label4.Location = new Point(20, 130);
            label4.Name = "label4";
            label4.Size = new Size(40, 18);
            label4.TabIndex = 5;
            label4.Text = "Price";
            // 
            // EditCategoryz
            // 
            EditCategoryz.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            EditCategoryz.BorderStyle = BorderStyle.FixedSingle;
            EditCategoryz.Font = new Font("Berlin Sans FB", 12F);
            EditCategoryz.Location = new Point(20, 210);
            EditCategoryz.Name = "EditCategoryz";
            EditCategoryz.Size = new Size(300, 25);
            EditCategoryz.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Berlin Sans FB", 12F);
            label3.ForeColor = Color.FromArgb(136, 136, 136);
            label3.Location = new Point(20, 190);
            label3.Name = "label3";
            label3.Size = new Size(68, 18);
            label3.TabIndex = 7;
            label3.Text = "Category";
            // 
            // EditStatusComboBox
            // 
            EditStatusComboBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            EditStatusComboBox.Font = new Font("Berlin Sans FB", 12F);
            EditStatusComboBox.FormattingEnabled = true;
            EditStatusComboBox.Location = new Point(20, 270);
            EditStatusComboBox.Name = "EditStatusComboBox";
            EditStatusComboBox.Size = new Size(300, 26);
            EditStatusComboBox.TabIndex = 8;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Berlin Sans FB", 12F);
            label13.ForeColor = Color.FromArgb(136, 136, 136);
            label13.Location = new Point(20, 250);
            label13.Name = "label13";
            label13.Size = new Size(47, 18);
            label13.TabIndex = 9;
            label13.Text = "Status";
            // 
            // EditNotes
            // 
            EditNotes.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            EditNotes.BorderStyle = BorderStyle.FixedSingle;
            EditNotes.Font = new Font("Berlin Sans FB", 12F);
            EditNotes.Location = new Point(20, 330);
            EditNotes.Name = "EditNotes";
            EditNotes.Size = new Size(300, 100);
            EditNotes.TabIndex = 10;
            EditNotes.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Berlin Sans FB", 12F);
            label1.ForeColor = Color.FromArgb(136, 136, 136);
            label1.Location = new Point(20, 310);
            label1.Name = "label1";
            label1.Size = new Size(45, 18);
            label1.TabIndex = 11;
            label1.Text = "Notes";
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button3.BackColor = Color.White;
            button3.FlatAppearance.BorderColor = Color.FromArgb(255, 79, 129);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Berlin Sans FB", 12F);
            button3.ForeColor = Color.FromArgb(255, 79, 129);
            button3.Location = new Point(190, 450);
            button3.Name = "button3";
            button3.Size = new Size(130, 35);
            button3.TabIndex = 12;
            button3.Text = "CANCEL";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // UpdateAssetBtn
            // 
            UpdateAssetBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            UpdateAssetBtn.BackColor = Color.FromArgb(255, 79, 129);
            UpdateAssetBtn.FlatAppearance.BorderSize = 0;
            UpdateAssetBtn.FlatStyle = FlatStyle.Flat;
            UpdateAssetBtn.Font = new Font("Berlin Sans FB", 12F, FontStyle.Bold);
            UpdateAssetBtn.ForeColor = Color.White;
            UpdateAssetBtn.Location = new Point(20, 450);
            UpdateAssetBtn.Name = "UpdateAssetBtn";
            UpdateAssetBtn.Size = new Size(130, 35);
            UpdateAssetBtn.TabIndex = 13;
            UpdateAssetBtn.Text = "UPDATE";
            UpdateAssetBtn.UseVisualStyleBackColor = false;
            UpdateAssetBtn.Click += UpdateAssetBtn_Click_1;
            // 
            // DeleteAssetPanel
            // 
            DeleteAssetPanel.BackColor = Color.White;
            DeleteAssetPanel.BorderStyle = BorderStyle.FixedSingle;
            DeleteAssetPanel.Controls.Add(panel3);
            DeleteAssetPanel.Location = new Point(402, 362);
            DeleteAssetPanel.Name = "DeleteAssetPanel";
            DeleteAssetPanel.Size = new Size(350, 250);
            DeleteAssetPanel.TabIndex = 2;
            DeleteAssetPanel.Visible = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(button7);
            panel3.Controls.Add(DebugText);
            panel3.Controls.Add(DeleteBtn);
            panel3.Controls.Add(CancelDeleteBtn);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(20);
            panel3.Size = new Size(348, 248);
            panel3.TabIndex = 0;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button7.BackColor = Color.Transparent;
            button7.BackgroundImage = Properties.Resources.close;
            button7.BackgroundImageLayout = ImageLayout.Stretch;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Location = new Point(318, 20);
            button7.Name = "button7";
            button7.Size = new Size(20, 20);
            button7.TabIndex = 0;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click_1;
            // 
            // DebugText
            // 
            DebugText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DebugText.Font = new Font("Berlin Sans FB", 14F, FontStyle.Bold);
            DebugText.ForeColor = Color.FromArgb(255, 79, 129);
            DebugText.Location = new Point(20, 60);
            DebugText.Name = "DebugText";
            DebugText.Size = new Size(300, 80);
            DebugText.TabIndex = 1;
            DebugText.Text = "Are you sure you want to delete this asset?";
            DebugText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            DeleteBtn.BackColor = Color.FromArgb(255, 79, 129);
            DeleteBtn.FlatAppearance.BorderSize = 0;
            DeleteBtn.FlatStyle = FlatStyle.Flat;
            DeleteBtn.Font = new Font("Berlin Sans FB", 12F, FontStyle.Bold);
            DeleteBtn.ForeColor = Color.White;
            DeleteBtn.Location = new Point(20, 180);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(130, 35);
            DeleteBtn.TabIndex = 2;
            DeleteBtn.Text = "DELETE";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // CancelDeleteBtn
            // 
            CancelDeleteBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CancelDeleteBtn.BackColor = Color.White;
            CancelDeleteBtn.FlatAppearance.BorderColor = Color.FromArgb(255, 79, 129);
            CancelDeleteBtn.FlatStyle = FlatStyle.Flat;
            CancelDeleteBtn.Font = new Font("Berlin Sans FB", 12F);
            CancelDeleteBtn.ForeColor = Color.FromArgb(255, 79, 129);
            CancelDeleteBtn.Location = new Point(190, 180);
            CancelDeleteBtn.Name = "CancelDeleteBtn";
            CancelDeleteBtn.Size = new Size(130, 35);
            CancelDeleteBtn.TabIndex = 3;
            CancelDeleteBtn.Text = "CANCEL";
            CancelDeleteBtn.UseVisualStyleBackColor = false;
            CancelDeleteBtn.Click += CancelDeleteBtn_Click_1;
            // 
            // AddAssetPanel
            // 
            AddAssetPanel.BackColor = Color.White;
            AddAssetPanel.BorderStyle = BorderStyle.FixedSingle;
            AddAssetPanel.Controls.Add(panel4);
            AddAssetPanel.Location = new Point(758, 363);
            AddAssetPanel.Name = "AddAssetPanel";
            AddAssetPanel.Size = new Size(350, 500);
            AddAssetPanel.TabIndex = 0;
            AddAssetPanel.Visible = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(button8);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(AddName);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(AddPrice);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(AddCategory);
            panel4.Controls.Add(AddStatus);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(AddNotes);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(button1);
            panel4.Controls.Add(AddSubmitBtn);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(20);
            panel4.Size = new Size(348, 498);
            panel4.TabIndex = 0;
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button8.BackColor = Color.Transparent;
            button8.BackgroundImage = Properties.Resources.close;
            button8.BackgroundImageLayout = ImageLayout.Stretch;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Location = new Point(318, 20);
            button8.Name = "button8";
            button8.Size = new Size(20, 20);
            button8.TabIndex = 0;
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click_1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Berlin Sans FB", 18F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(255, 79, 129);
            label9.Location = new Point(20, 20);
            label9.Name = "label9";
            label9.Size = new Size(140, 30);
            label9.TabIndex = 1;
            label9.Text = "ADD ASSET";
            // 
            // AddName
            // 
            AddName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            AddName.BorderStyle = BorderStyle.FixedSingle;
            AddName.Font = new Font("Berlin Sans FB", 12F);
            AddName.Location = new Point(20, 90);
            AddName.Name = "AddName";
            AddName.Size = new Size(300, 25);
            AddName.TabIndex = 2;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Berlin Sans FB", 12F);
            label12.ForeColor = Color.FromArgb(136, 136, 136);
            label12.Location = new Point(20, 70);
            label12.Name = "label12";
            label12.Size = new Size(49, 18);
            label12.TabIndex = 3;
            label12.Text = "Name";
            // 
            // AddPrice
            // 
            AddPrice.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            AddPrice.BorderStyle = BorderStyle.FixedSingle;
            AddPrice.Font = new Font("Berlin Sans FB", 12F);
            AddPrice.Location = new Point(20, 150);
            AddPrice.Name = "AddPrice";
            AddPrice.Size = new Size(300, 25);
            AddPrice.TabIndex = 4;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Berlin Sans FB", 12F);
            label11.ForeColor = Color.FromArgb(136, 136, 136);
            label11.Location = new Point(20, 130);
            label11.Name = "label11";
            label11.Size = new Size(40, 18);
            label11.TabIndex = 5;
            label11.Text = "Price";
            // 
            // AddCategory
            // 
            AddCategory.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            AddCategory.BorderStyle = BorderStyle.FixedSingle;
            AddCategory.Font = new Font("Berlin Sans FB", 12F);
            AddCategory.Location = new Point(20, 210);
            AddCategory.Name = "AddCategory";
            AddCategory.Size = new Size(300, 25);
            AddCategory.TabIndex = 6;
            // 
            // AddStatus
            // 
            AddStatus.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            AddStatus.Font = new Font("Berlin Sans FB", 12F);
            AddStatus.FormattingEnabled = true;
            AddStatus.Location = new Point(20, 270);
            AddStatus.Name = "AddStatus";
            AddStatus.Size = new Size(300, 26);
            AddStatus.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Berlin Sans FB", 12F);
            label8.ForeColor = Color.FromArgb(136, 136, 136);
            label8.Location = new Point(20, 250);
            label8.Name = "label8";
            label8.Size = new Size(47, 18);
            label8.TabIndex = 8;
            label8.Text = "Status";
            // 
            // AddNotes
            // 
            AddNotes.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            AddNotes.BorderStyle = BorderStyle.FixedSingle;
            AddNotes.Font = new Font("Berlin Sans FB", 12F);
            AddNotes.Location = new Point(20, 330);
            AddNotes.Name = "AddNotes";
            AddNotes.Size = new Size(300, 100);
            AddNotes.TabIndex = 9;
            AddNotes.Text = "";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Berlin Sans FB", 12F);
            label10.ForeColor = Color.FromArgb(136, 136, 136);
            label10.Location = new Point(20, 310);
            label10.Name = "label10";
            label10.Size = new Size(45, 18);
            label10.TabIndex = 10;
            label10.Text = "Notes";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Berlin Sans FB", 12F);
            label14.ForeColor = Color.FromArgb(136, 136, 136);
            label14.Location = new Point(20, 190);
            label14.Name = "label14";
            label14.Size = new Size(68, 18);
            label14.TabIndex = 11;
            label14.Text = "Category";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderColor = Color.FromArgb(255, 79, 129);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Berlin Sans FB", 12F);
            button1.ForeColor = Color.FromArgb(255, 79, 129);
            button1.Location = new Point(190, 450);
            button1.Name = "button1";
            button1.Size = new Size(130, 35);
            button1.TabIndex = 12;
            button1.Text = "CANCEL";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // AddSubmitBtn
            // 
            AddSubmitBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddSubmitBtn.BackColor = Color.FromArgb(255, 79, 129);
            AddSubmitBtn.FlatAppearance.BorderSize = 0;
            AddSubmitBtn.FlatStyle = FlatStyle.Flat;
            AddSubmitBtn.Font = new Font("Berlin Sans FB", 12F, FontStyle.Bold);
            AddSubmitBtn.ForeColor = Color.White;
            AddSubmitBtn.Location = new Point(20, 450);
            AddSubmitBtn.Name = "AddSubmitBtn";
            AddSubmitBtn.Size = new Size(130, 35);
            AddSubmitBtn.TabIndex = 13;
            AddSubmitBtn.Text = "SUBMIT";
            AddSubmitBtn.UseVisualStyleBackColor = false;
            AddSubmitBtn.Click += AddSubmitBtn_Click_1;
            // 
            // MainPanel
            // 
            MainPanel.ColumnCount = 1;
            MainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            MainPanel.Controls.Add(panel2, 0, 0);
            MainPanel.Controls.Add(AssetsGrid, 0, 1);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Padding = new Padding(20);
            MainPanel.RowCount = 2;
            MainPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            MainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            MainPanel.Size = new Size(1200, 980);
            MainPanel.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(SearchPanel);
            panel2.Controls.Add(AddAssetBtn);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(20, 20);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1160, 60);
            panel2.TabIndex = 0;
            // 
            // SearchPanel
            // 
            SearchPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            SearchPanel.BackColor = Color.White;
            SearchPanel.BorderStyle = BorderStyle.FixedSingle;
            SearchPanel.Controls.Add(SearchTextBox);
            SearchPanel.Controls.Add(SearchBtn);
            SearchPanel.Location = new Point(0, 15);
            SearchPanel.Name = "SearchPanel";
            SearchPanel.Size = new Size(900, 40);
            SearchPanel.TabIndex = 0;
            // 
            // SearchTextBox
            // 
            SearchTextBox.BackColor = Color.White;
            SearchTextBox.BorderStyle = BorderStyle.None;
            SearchTextBox.Dock = DockStyle.Fill;
            SearchTextBox.Font = new Font("Berlin Sans FB", 12F);
            SearchTextBox.ForeColor = Color.FromArgb(51, 51, 51);
            SearchTextBox.Location = new Point(0, 0);
            SearchTextBox.Margin = new Padding(10);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.PlaceholderText = "Search assets...";
            SearchTextBox.Size = new Size(798, 18);
            SearchTextBox.TabIndex = 0;
            // 
            // SearchBtn
            // 
            SearchBtn.BackColor = Color.FromArgb(255, 79, 129);
            SearchBtn.Dock = DockStyle.Right;
            SearchBtn.FlatAppearance.BorderSize = 0;
            SearchBtn.FlatStyle = FlatStyle.Flat;
            SearchBtn.Font = new Font("Berlin Sans FB", 12F);
            SearchBtn.ForeColor = Color.White;
            SearchBtn.Location = new Point(798, 0);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(100, 38);
            SearchBtn.TabIndex = 1;
            SearchBtn.Text = "SEARCH";
            SearchBtn.UseVisualStyleBackColor = false;
            SearchBtn.Click += SearchBtn_Click_2;
            // 
            // AddAssetBtn
            // 
            AddAssetBtn.Anchor = AnchorStyles.Right;
            AddAssetBtn.BackColor = Color.FromArgb(255, 79, 129);
            AddAssetBtn.FlatAppearance.BorderSize = 0;
            AddAssetBtn.FlatStyle = FlatStyle.Flat;
            AddAssetBtn.Font = new Font("Berlin Sans FB", 12F);
            AddAssetBtn.ForeColor = Color.White;
            AddAssetBtn.Location = new Point(950, 15);
            AddAssetBtn.Name = "AddAssetBtn";
            AddAssetBtn.Size = new Size(200, 40);
            AddAssetBtn.TabIndex = 1;
            AddAssetBtn.Text = "+ ADD NEW ASSET";
            AddAssetBtn.UseVisualStyleBackColor = false;
            AddAssetBtn.Click += AddAssetBtn_Click_1;
            // 
            // AssetsGrid
            // 
            AssetsGrid.AllowUserToAddRows = false;
            AssetsGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 246, 249);
            dataGridViewCellStyle1.Font = new Font("Berlin Sans FB", 10F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 211, 220);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(51, 51, 51);
            AssetsGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            AssetsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AssetsGrid.BackgroundColor = Color.White;
            AssetsGrid.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 79, 129);
            dataGridViewCellStyle2.Font = new Font("Berlin Sans FB", 12F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 79, 129);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            AssetsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            AssetsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Berlin Sans FB", 10F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 211, 220);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            AssetsGrid.DefaultCellStyle = dataGridViewCellStyle3;
            AssetsGrid.Dock = DockStyle.Fill;
            AssetsGrid.EnableHeadersVisualStyles = false;
            AssetsGrid.GridColor = Color.FromArgb(255, 211, 220);
            AssetsGrid.Location = new Point(20, 80);
            AssetsGrid.Margin = new Padding(0, 0, 0, 20);
            AssetsGrid.Name = "AssetsGrid";
            AssetsGrid.ReadOnly = true;
            AssetsGrid.RowHeadersVisible = false;
            AssetsGrid.RowTemplate.Height = 35;
            AssetsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AssetsGrid.Size = new Size(1160, 860);
            AssetsGrid.TabIndex = 1;
            // 
            // AssetManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 980);
            Controls.Add(ParentPanel);
            Name = "AssetManagement";
            Text = "Asset Management System";
            ParentPanel.ResumeLayout(false);
            EditAssetPanel.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            DeleteAssetPanel.ResumeLayout(false);
            panel3.ResumeLayout(false);
            AddAssetPanel.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            MainPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            SearchPanel.ResumeLayout(false);
            SearchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AssetsGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel ParentPanel;
        private TableLayoutPanel MainPanel;
        private Panel panel2;
        private Panel SearchPanel;
        private TextBox SearchTextBox;
        private Button SearchBtn;
        private Button AddAssetBtn;
        private DataGridView AssetsGrid;
        private Panel AddAssetPanel;
        private Panel EditAssetPanel;
        private Panel panel5;
        private Button button2;
        private Label label2;
        private TextBox EditAssetName;
        private Label label5;
        private TextBox EditPrice;
        private Label label4;
        private TextBox EditCategoryz;
        private Label label3;
        private ComboBox EditStatusComboBox;
        private Label label13;
        private RichTextBox EditNotes;
        private Label label1;
        private Button button3;
        private Button UpdateAssetBtn;
        private Panel DeleteAssetPanel;
        private Panel panel3;
        private Button button7;
        private Label DebugText;
        private Button DeleteBtn;
        private Button CancelDeleteBtn;
        private Panel panel4;
        private Button button8;
        private Label label9;
        private TextBox AddName;
        private Label label12;
        private TextBox AddPrice;
        private Label label11;
        private TextBox AddCategory;
        private ComboBox AddStatus;
        private Label label8;
        private RichTextBox AddNotes;
        private Label label10;
        private Label label14;
        private Button button1;
        private Button AddSubmitBtn;
    }
}