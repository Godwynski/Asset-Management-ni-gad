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
            panel1 = new Panel();
            DeleteModalBox = new Panel();
            button3 = new Button();
            button2 = new Button();
            richTextBox1 = new RichTextBox();
            label5 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            button1 = new Button();
            SearchBtn = new Button();
            SearchTextBox = new TextBox();
            AssetsGrid = new DataGridView();
            panel3 = new Panel();
            panel1.SuspendLayout();
            DeleteModalBox.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AssetsGrid).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 211, 220);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(DeleteModalBox);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1128, 605);
            panel1.TabIndex = 2;
            // 
            // DeleteModalBox
            // 
            DeleteModalBox.Controls.Add(button3);
            DeleteModalBox.Controls.Add(button2);
            DeleteModalBox.Controls.Add(richTextBox1);
            DeleteModalBox.Controls.Add(label5);
            DeleteModalBox.Controls.Add(label4);
            DeleteModalBox.Controls.Add(textBox3);
            DeleteModalBox.Controls.Add(label3);
            DeleteModalBox.Controls.Add(textBox2);
            DeleteModalBox.Controls.Add(label2);
            DeleteModalBox.Controls.Add(textBox1);
            DeleteModalBox.Controls.Add(label1);
            DeleteModalBox.Location = new Point(349, 95);
            DeleteModalBox.Name = "DeleteModalBox";
            DeleteModalBox.Size = new Size(347, 449);
            DeleteModalBox.TabIndex = 4;
            // 
            // button3
            // 
            button3.Location = new Point(211, 373);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 18;
            button3.Text = "Cancel";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(52, 373);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 17;
            button2.Text = "Submit";
            button2.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(37, 279);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(278, 79);
            richTextBox1.TabIndex = 16;
            richTextBox1.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Berlin Sans FB", 12F);
            label5.ForeColor = Color.FromArgb(217, 58, 102);
            label5.Location = new Point(37, 251);
            label5.Name = "label5";
            label5.Size = new Size(45, 18);
            label5.TabIndex = 15;
            label5.Text = "Notes";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Berlin Sans FB", 15.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(217, 58, 102);
            label4.Location = new Point(127, 28);
            label4.Name = "label4";
            label4.Size = new Size(92, 23);
            label4.TabIndex = 14;
            label4.Text = "Edit Asset";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F);
            textBox3.ForeColor = Color.FromArgb(217, 58, 102);
            textBox3.Location = new Point(37, 214);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(278, 29);
            textBox3.TabIndex = 13;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Berlin Sans FB", 12F);
            label2.ForeColor = Color.FromArgb(217, 58, 102);
            label2.Location = new Point(37, 136);
            label2.Name = "label2";
            label2.Size = new Size(68, 18);
            label2.TabIndex = 10;
            label2.Text = "Category";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.ForeColor = Color.FromArgb(217, 58, 102);
            textBox1.Location = new Point(37, 91);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(278, 29);
            textBox1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Berlin Sans FB", 12F);
            label1.ForeColor = Color.FromArgb(217, 58, 102);
            label1.Location = new Point(37, 70);
            label1.Name = "label1";
            label1.Size = new Size(49, 18);
            label1.TabIndex = 8;
            label1.Text = "Name";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Controls.Add(AssetsGrid, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(20);
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 492F));
            tableLayoutPanel1.Size = new Size(1128, 564);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Controls.Add(SearchBtn);
            panel2.Controls.Add(SearchTextBox);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(23, 23);
            panel2.Name = "panel2";
            panel2.Size = new Size(1082, 26);
            panel2.TabIndex = 2;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Right;
            button1.Location = new Point(1007, 1);
            button1.Name = "button1";
            button1.Size = new Size(75, 25);
            button1.TabIndex = 2;
            button1.Text = "Add Asset";
            button1.UseVisualStyleBackColor = true;
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
            AssetsGrid.Size = new Size(1088, 472);
            AssetsGrid.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Location = new Point(739, 527);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 100);
            panel3.TabIndex = 5;
            // 
            // AssetManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1128, 605);
            Controls.Add(panel1);
            Name = "AssetManagement";
            Text = "AssetManagement";
            panel1.ResumeLayout(false);
            DeleteModalBox.ResumeLayout(false);
            DeleteModalBox.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AssetsGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private DataGridView AssetsGrid;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox SearchTextBox;
        private Button SearchBtn;
        private Panel panel2;
        private Button button1;
        private Panel DeleteModalBox;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private RichTextBox richTextBox1;
        private Label label5;
        private Button button3;
        private Button button2;
        private Panel panel3;
    }
}