namespace Asset_Management_ni_gad.Components
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            panel1 = new Panel();
            FullNameTextbox = new Label();
            DashboardBtn = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(FullNameTextbox);
            panel1.Controls.Add(DashboardBtn);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(285, 599);
            panel1.TabIndex = 0;
            // 
            // FullNameTextbox
            // 
            FullNameTextbox.AutoSize = true;
            FullNameTextbox.Font = new Font("Berlin Sans FB", 12F);
            FullNameTextbox.ForeColor = Color.FromArgb(217, 58, 102);
            FullNameTextbox.Location = new Point(24, 94);
            FullNameTextbox.Name = "FullNameTextbox";
            FullNameTextbox.Size = new Size(76, 18);
            FullNameTextbox.TabIndex = 8;
            FullNameTextbox.Text = "Full Name";
            // 
            // DashboardBtn
            // 
            DashboardBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            DashboardBtn.BackColor = Color.Transparent;
            DashboardBtn.BackgroundImage = (Image)resources.GetObject("DashboardBtn.BackgroundImage");
            DashboardBtn.BackgroundImageLayout = ImageLayout.Stretch;
            DashboardBtn.Cursor = Cursors.Hand;
            DashboardBtn.FlatAppearance.BorderColor = Color.FromArgb(255, 79, 129);
            DashboardBtn.FlatAppearance.BorderSize = 0;
            DashboardBtn.FlatStyle = FlatStyle.Flat;
            DashboardBtn.Font = new Font("Berlin Sans FB Demi", 12F, FontStyle.Bold);
            DashboardBtn.ForeColor = Color.FromArgb(255, 79, 129);
            DashboardBtn.Location = new Point(40, 245);
            DashboardBtn.Margin = new Padding(10);
            DashboardBtn.Name = "DashboardBtn";
            DashboardBtn.Size = new Size(207, 55);
            DashboardBtn.TabIndex = 6;
            DashboardBtn.Text = "Logout";
            DashboardBtn.UseVisualStyleBackColor = false;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 246, 249);
            ClientSize = new Size(285, 599);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(280, 0);
            Name = "Settings";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Username";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button DashboardBtn;
        private Label FullNameTextbox;
    }
}