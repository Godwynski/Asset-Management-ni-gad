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
            label2 = new Label();
            DashboardBtn = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(DashboardBtn);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(285, 599);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Berlin Sans FB", 12F);
            label2.ForeColor = Color.FromArgb(217, 58, 102);
            label2.Location = new Point(42, 114);
            label2.Name = "label2";
            label2.Size = new Size(76, 18);
            label2.TabIndex = 8;
            label2.Text = "Full Name";
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
            DashboardBtn.Font = new Font("Berlin Sans FB Demi", 12F, FontStyle.Bold);
            DashboardBtn.ForeColor = Color.FromArgb(255, 79, 129);
            DashboardBtn.Location = new Point(42, 534);
            DashboardBtn.Margin = new Padding(10);
            DashboardBtn.Name = "DashboardBtn";
            DashboardBtn.Size = new Size(207, 55);
            DashboardBtn.TabIndex = 6;
            DashboardBtn.Text = "Logout";
            DashboardBtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Berlin Sans FB", 12F);
            label1.ForeColor = Color.FromArgb(217, 58, 102);
            label1.Location = new Point(43, 79);
            label1.Name = "label1";
            label1.Size = new Size(75, 18);
            label1.TabIndex = 5;
            label1.Text = "Username";
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
        private Label label1;
        private Button DashboardBtn;
        private Label label2;
    }
}