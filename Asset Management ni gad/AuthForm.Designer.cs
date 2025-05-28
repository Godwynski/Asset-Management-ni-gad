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
            pictureBox1 = new PictureBox();
            PasswordTextbox = new TextBox();
            label2 = new Label();
            UsernameTextbox = new TextBox();
            label1 = new Label();
            LoginBtn = new Button();
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
            LoginForm.Controls.Add(pictureBox1);
            LoginForm.Controls.Add(PasswordTextbox);
            LoginForm.Controls.Add(label2);
            LoginForm.Controls.Add(UsernameTextbox);
            LoginForm.Controls.Add(label1);
            LoginForm.Controls.Add(LoginBtn);
            LoginForm.Location = new Point(189, 54);
            LoginForm.Name = "LoginForm";
            LoginForm.Padding = new Padding(2);
            LoginForm.Size = new Size(358, 470);
            LoginForm.TabIndex = 0;
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
            // PasswordTextbox
            // 
            PasswordTextbox.Font = new Font("Segoe UI", 12F);
            PasswordTextbox.ForeColor = Color.FromArgb(217, 58, 102);
            PasswordTextbox.Location = new Point(62, 280);
            PasswordTextbox.Name = "PasswordTextbox";
            PasswordTextbox.PasswordChar = '*';
            PasswordTextbox.Size = new Size(240, 29);
            PasswordTextbox.TabIndex = 7;
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
            // UsernameTextbox
            // 
            UsernameTextbox.Font = new Font("Segoe UI", 12F);
            UsernameTextbox.ForeColor = Color.FromArgb(217, 58, 102);
            UsernameTextbox.Location = new Point(62, 209);
            UsernameTextbox.Name = "UsernameTextbox";
            UsernameTextbox.Size = new Size(240, 29);
            UsernameTextbox.TabIndex = 5;
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
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.Transparent;
            LoginBtn.BackgroundImage = (Image)resources.GetObject("LoginBtn.BackgroundImage");
            LoginBtn.BackgroundImageLayout = ImageLayout.Stretch;
            LoginBtn.Cursor = Cursors.Hand;
            LoginBtn.FlatAppearance.BorderColor = Color.FromArgb(255, 79, 129);
            LoginBtn.FlatAppearance.BorderSize = 0;
            LoginBtn.FlatStyle = FlatStyle.Flat;
            LoginBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            LoginBtn.ForeColor = Color.FromArgb(255, 79, 129);
            LoginBtn.Location = new Point(120, 378);
            LoginBtn.Margin = new Padding(10);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(110, 37);
            LoginBtn.TabIndex = 3;
            LoginBtn.UseVisualStyleBackColor = false;
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
        private TextBox UsernameTextbox;
        private Label label1;
        private Button LoginBtn;
        private PictureBox pictureBox1;
        private TextBox PasswordTextbox;
        private Label label2;
    }
}
