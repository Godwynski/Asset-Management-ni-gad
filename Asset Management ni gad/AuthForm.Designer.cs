namespace Asset_Management_ni_gad
{
    partial class AuthForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthForm));
            MainPanel = new Panel();
            LoginForm = new Panel();
            checkBox1 = new CheckBox();
            pictureBox1 = new PictureBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            DashboardBtn = new Button();
            MainPanel.SuspendLayout();
            LoginForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.BackgroundImage = (Image)resources.GetObject("MainPanel.BackgroundImage");
            MainPanel.BackgroundImageLayout = ImageLayout.Stretch;
            MainPanel.Controls.Add(LoginForm);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Padding = new Padding(2);
            MainPanel.Size = new Size(744, 560);
            MainPanel.TabIndex = 0;
            // 
            // LoginForm
            // 
            LoginForm.Anchor = AnchorStyles.None;
            LoginForm.BackColor = Color.FromArgb(255, 246, 249);
            LoginForm.Controls.Add(checkBox1);
            LoginForm.Controls.Add(pictureBox1);
            LoginForm.Controls.Add(textBox2);
            LoginForm.Controls.Add(label2);
            LoginForm.Controls.Add(textBox1);
            LoginForm.Controls.Add(label1);
            LoginForm.Controls.Add(DashboardBtn);
            LoginForm.Location = new Point(189, 54);
            LoginForm.Name = "LoginForm";
            LoginForm.Padding = new Padding(2);
            LoginForm.Size = new Size(358, 470);
            LoginForm.TabIndex = 0;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Berlin Sans FB", 12F);
            checkBox1.ForeColor = Color.FromArgb(217, 58, 102);
            checkBox1.Location = new Point(64, 328);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(124, 22);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "Remember Me";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(0, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(358, 138);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.ForeColor = Color.FromArgb(217, 58, 102);
            textBox2.Location = new Point(62, 280);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(240, 29);
            textBox2.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Berlin Sans FB", 12F);
            label2.ForeColor = Color.FromArgb(217, 58, 102);
            label2.Location = new Point(64, 264);
            label2.Name = "label2";
            label2.Size = new Size(72, 18);
            label2.TabIndex = 6;
            label2.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.ForeColor = Color.FromArgb(217, 58, 102);
            textBox1.Location = new Point(62, 209);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(240, 29);
            textBox1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Berlin Sans FB", 12F);
            label1.ForeColor = Color.FromArgb(217, 58, 102);
            label1.Location = new Point(64, 193);
            label1.Name = "label1";
            label1.Size = new Size(75, 18);
            label1.TabIndex = 4;
            label1.Text = "Username";
            // 
            // DashboardBtn
            // 
            DashboardBtn.BackColor = Color.Transparent;
            DashboardBtn.BackgroundImage = (Image)resources.GetObject("DashboardBtn.BackgroundImage");
            DashboardBtn.BackgroundImageLayout = ImageLayout.Stretch;
            DashboardBtn.Cursor = Cursors.Hand;
            DashboardBtn.FlatAppearance.BorderColor = Color.FromArgb(255, 79, 129);
            DashboardBtn.FlatAppearance.BorderSize = 0;
            DashboardBtn.FlatStyle = FlatStyle.Flat;
            DashboardBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            DashboardBtn.ForeColor = Color.FromArgb(255, 79, 129);
            DashboardBtn.Location = new Point(120, 378);
            DashboardBtn.Margin = new Padding(10);
            DashboardBtn.Name = "DashboardBtn";
            DashboardBtn.Size = new Size(110, 37);
            DashboardBtn.TabIndex = 3;
            DashboardBtn.UseVisualStyleBackColor = false;
            // 
            // AuthForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 560);
            Controls.Add(MainPanel);
            Name = "AuthForm";
            Text = "Authentication";
            Resize += resize;
            MainPanel.ResumeLayout(false);
            LoginForm.ResumeLayout(false);
            LoginForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel MainPanel;
        private Panel LoginForm;
        private TextBox textBox1;
        private Label label1;
        private Button DashboardBtn;
        private PictureBox pictureBox1;
        private TextBox textBox2;
        private Label label2;
        private CheckBox checkBox1;
    }
}
