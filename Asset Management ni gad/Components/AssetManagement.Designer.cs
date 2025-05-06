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
            label7 = new Label();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            label6 = new Label();
            EditAssetPanel = new TableLayoutPanel();
            panel5 = new Panel();
            comboBox1 = new ComboBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            AddAssetPanel = new TableLayoutPanel();
            panel4 = new Panel();
            comboBox2 = new ComboBox();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            richTextBox2 = new RichTextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            textBox5 = new TextBox();
            label11 = new Label();
            textBox6 = new TextBox();
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
            panel3.Controls.Add(label7);
            panel3.Controls.Add(button7);
            panel3.Controls.Add(button6);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(340, 188);
            panel3.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Berlin Sans FB", 15.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(217, 58, 102);
            label7.Location = new Point(10, 74);
            label7.Name = "label7";
            label7.Size = new Size(113, 23);
            label7.TabIndex = 21;
            label7.Text = "Asset Name";
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
            // button6
            // 
            button6.Location = new Point(179, 123);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 19;
            button6.Text = "No";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(81, 123);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 18;
            button5.Text = "Yes";
            button5.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Berlin Sans FB", 15.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(217, 58, 102);
            label6.Location = new Point(10, 41);
            label6.Name = "label6";
            label6.Size = new Size(288, 23);
            label6.TabIndex = 16;
            label6.Text = "Are you sure you want to delete";
            // 
            // EditAssetPanel
            // 
            EditAssetPanel.BackColor = Color.FromArgb(217, 58, 102);
            EditAssetPanel.ColumnCount = 1;
            EditAssetPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            EditAssetPanel.Controls.Add(panel5, 0, 0);
            EditAssetPanel.Location = new Point(408, 574);
            EditAssetPanel.Name = "EditAssetPanel";
            EditAssetPanel.RowCount = 1;
            EditAssetPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            EditAssetPanel.Size = new Size(349, 451);
            EditAssetPanel.TabIndex = 8;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(255, 211, 220);
            panel5.Controls.Add(comboBox1);
            panel5.Controls.Add(button2);
            panel5.Controls.Add(button3);
            panel5.Controls.Add(button4);
            panel5.Controls.Add(richTextBox1);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(textBox2);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(textBox3);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(343, 445);
            panel5.TabIndex = 7;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(37, 220);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(278, 23);
            comboBox1.TabIndex = 20;
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
            button3.Location = new Point(215, 373);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 18;
            button3.Text = "Cancel";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(52, 373);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 17;
            button4.Text = "Submit";
            button4.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(37, 279);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(278, 79);
            richTextBox1.TabIndex = 16;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Berlin Sans FB", 12F);
            label1.ForeColor = Color.FromArgb(217, 58, 102);
            label1.Location = new Point(37, 251);
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
            label3.Size = new Size(47, 18);
            label3.TabIndex = 12;
            label3.Text = "Status";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.ForeColor = Color.FromArgb(217, 58, 102);
            textBox2.Location = new Point(37, 157);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(278, 29);
            textBox2.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Berlin Sans FB", 12F);
            label4.ForeColor = Color.FromArgb(217, 58, 102);
            label4.Location = new Point(37, 136);
            label4.Name = "label4";
            label4.Size = new Size(68, 18);
            label4.TabIndex = 10;
            label4.Text = "Category";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F);
            textBox3.ForeColor = Color.FromArgb(217, 58, 102);
            textBox3.Location = new Point(37, 91);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(278, 29);
            textBox3.TabIndex = 9;
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
            AddAssetPanel.Location = new Point(775, 574);
            AddAssetPanel.Name = "AddAssetPanel";
            AddAssetPanel.RowCount = 1;
            AddAssetPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            AddAssetPanel.Size = new Size(349, 451);
            AddAssetPanel.TabIndex = 7;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(255, 211, 220);
            panel4.Controls.Add(comboBox2);
            panel4.Controls.Add(button8);
            panel4.Controls.Add(button9);
            panel4.Controls.Add(button10);
            panel4.Controls.Add(richTextBox2);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(textBox5);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(textBox6);
            panel4.Controls.Add(label12);
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(343, 445);
            panel4.TabIndex = 7;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(37, 220);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(278, 23);
            comboBox2.TabIndex = 21;
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
            // button9
            // 
            button9.Location = new Point(211, 373);
            button9.Name = "button9";
            button9.Size = new Size(75, 23);
            button9.TabIndex = 18;
            button9.Text = "Cancel";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(52, 373);
            button10.Name = "button10";
            button10.Size = new Size(75, 23);
            button10.TabIndex = 17;
            button10.Text = "Submit";
            button10.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(37, 279);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(278, 79);
            richTextBox2.TabIndex = 16;
            richTextBox2.Text = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Berlin Sans FB", 12F);
            label8.ForeColor = Color.FromArgb(217, 58, 102);
            label8.Location = new Point(37, 251);
            label8.Name = "label8";
            label8.Size = new Size(45, 18);
            label8.TabIndex = 15;
            label8.Text = "Notes";
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
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Berlin Sans FB", 12F);
            label10.ForeColor = Color.FromArgb(217, 58, 102);
            label10.Location = new Point(37, 193);
            label10.Name = "label10";
            label10.Size = new Size(47, 18);
            label10.TabIndex = 12;
            label10.Text = "Status";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 12F);
            textBox5.ForeColor = Color.FromArgb(217, 58, 102);
            textBox5.Location = new Point(37, 157);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(278, 29);
            textBox5.TabIndex = 11;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Berlin Sans FB", 12F);
            label11.ForeColor = Color.FromArgb(217, 58, 102);
            label11.Location = new Point(37, 136);
            label11.Name = "label11";
            label11.Size = new Size(68, 18);
            label11.TabIndex = 10;
            label11.Text = "Category";
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 12F);
            textBox6.ForeColor = Color.FromArgb(217, 58, 102);
            textBox6.Location = new Point(37, 91);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(278, 29);
            textBox6.TabIndex = 9;
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
            SearchBtn.Location = new Point(307, 0);
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
            SearchTextBox.Size = new Size(301, 25);
            SearchTextBox.TabIndex = 0;
            SearchTextBox.Tag = "Search...";
            // 
            // AssetsGrid
            // 
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
        private Label label6;
        private Button button6;
        private Button button5;
        private Button button7;
        private TableLayoutPanel AddAssetPanel;
        private Panel panel4;
        private Button button8;
        private Button button9;
        private Button button10;
        private RichTextBox richTextBox2;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox textBox5;
        private Label label11;
        private TextBox textBox6;
        private Label label12;
        private TableLayoutPanel EditAssetPanel;
        private Panel panel5;
        private Button button2;
        private Button button3;
        private Button button4;
        private RichTextBox richTextBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TableLayoutPanel DeleteAssetPanel;
        private Label label7;
    }
}