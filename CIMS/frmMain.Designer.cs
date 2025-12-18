namespace CIMS
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lblUserWelcome = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Services_TSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Users_TSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AccountSetting_TSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CurrentUserInfo_TSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangePassword_TSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.SignOut_TSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InstructionsTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(60, 60);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Services_TSMenuItem,
            this.Users_TSMenuItem,
            this.AccountSetting_TSMenuItem,
            this.HelpTSMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1465, 68);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lblUserWelcome
            // 
            this.lblUserWelcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(40)))), ((int)(((byte)(88)))));
            this.lblUserWelcome.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblUserWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserWelcome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUserWelcome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUserWelcome.Location = new System.Drawing.Point(0, 822);
            this.lblUserWelcome.Name = "lblUserWelcome";
            this.lblUserWelcome.Size = new System.Drawing.Size(1465, 33);
            this.lblUserWelcome.TabIndex = 5;
            this.lblUserWelcome.Text = "👋 Welcome! UserName";
            this.lblUserWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::CIMS.Properties.Resources.scale_1200;
            this.pictureBox1.Location = new System.Drawing.Point(0, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1465, 787);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Services_TSMenuItem
            // 
            this.Services_TSMenuItem.Image = global::CIMS.Properties.Resources.customer_service_2_;
            this.Services_TSMenuItem.Name = "Services_TSMenuItem";
            this.Services_TSMenuItem.Size = new System.Drawing.Size(190, 64);
            this.Services_TSMenuItem.Text = "Services";
            this.Services_TSMenuItem.Click += new System.EventHandler(this.Services_TSMenuItem_Click);
            // 
            // Users_TSMenuItem
            // 
            this.Users_TSMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("Users_TSMenuItem.Image")));
            this.Users_TSMenuItem.Name = "Users_TSMenuItem";
            this.Users_TSMenuItem.Size = new System.Drawing.Size(158, 64);
            this.Users_TSMenuItem.Text = "Users";
            this.Users_TSMenuItem.Click += new System.EventHandler(this.Users_TSMenuItem_Click);
            // 
            // AccountSetting_TSMenuItem
            // 
            this.AccountSetting_TSMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CurrentUserInfo_TSMenuItem,
            this.ChangePassword_TSMenuItem,
            this.signOutToolStripMenuItem,
            this.SignOut_TSMenuItem});
            this.AccountSetting_TSMenuItem.Image = global::CIMS.Properties.Resources.account_settings;
            this.AccountSetting_TSMenuItem.Name = "AccountSetting_TSMenuItem";
            this.AccountSetting_TSMenuItem.Size = new System.Drawing.Size(291, 64);
            this.AccountSetting_TSMenuItem.Text = "Account Setting";
            // 
            // CurrentUserInfo_TSMenuItem
            // 
            this.CurrentUserInfo_TSMenuItem.Image = global::CIMS.Properties.Resources.information_2;
            this.CurrentUserInfo_TSMenuItem.Name = "CurrentUserInfo_TSMenuItem";
            this.CurrentUserInfo_TSMenuItem.Size = new System.Drawing.Size(362, 66);
            this.CurrentUserInfo_TSMenuItem.Text = "Current User Info";
            this.CurrentUserInfo_TSMenuItem.Click += new System.EventHandler(this.CurrentUserInfo_TSMenuItem_Click);
            // 
            // ChangePassword_TSMenuItem
            // 
            this.ChangePassword_TSMenuItem.Image = global::CIMS.Properties.Resources.password_3;
            this.ChangePassword_TSMenuItem.Name = "ChangePassword_TSMenuItem";
            this.ChangePassword_TSMenuItem.Size = new System.Drawing.Size(362, 66);
            this.ChangePassword_TSMenuItem.Text = "Change Password";
            this.ChangePassword_TSMenuItem.Click += new System.EventHandler(this.ChangePassword_TSMenuItem_Click);
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(359, 6);
            // 
            // SignOut_TSMenuItem
            // 
            this.SignOut_TSMenuItem.Image = global::CIMS.Properties.Resources.logout_2;
            this.SignOut_TSMenuItem.Name = "SignOut_TSMenuItem";
            this.SignOut_TSMenuItem.Size = new System.Drawing.Size(362, 66);
            this.SignOut_TSMenuItem.Text = "Sign Out";
            this.SignOut_TSMenuItem.Click += new System.EventHandler(this.SignOut_TSMenuItem_Click);
            // 
            // HelpTSMenuItem
            // 
            this.HelpTSMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutTSMenuItem,
            this.InstructionsTSMenuItem});
            this.HelpTSMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("HelpTSMenuItem.Image")));
            this.HelpTSMenuItem.Name = "HelpTSMenuItem";
            this.HelpTSMenuItem.Size = new System.Drawing.Size(149, 64);
            this.HelpTSMenuItem.Text = "Help";
            // 
            // AboutTSMenuItem
            // 
            this.AboutTSMenuItem.Image = global::CIMS.Properties.Resources.information;
            this.AboutTSMenuItem.Name = "AboutTSMenuItem";
            this.AboutTSMenuItem.Size = new System.Drawing.Size(285, 66);
            this.AboutTSMenuItem.Text = "About";
            this.AboutTSMenuItem.Click += new System.EventHandler(this.AboutTSMenuItem_Click);
            // 
            // InstructionsTSMenuItem
            // 
            this.InstructionsTSMenuItem.Image = global::CIMS.Properties.Resources.guidebook1;
            this.InstructionsTSMenuItem.Name = "InstructionsTSMenuItem";
            this.InstructionsTSMenuItem.Size = new System.Drawing.Size(285, 66);
            this.InstructionsTSMenuItem.Text = "Instructions";
            this.InstructionsTSMenuItem.Click += new System.EventHandler(this.InstructionsTSMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 855);
            this.Controls.Add(this.lblUserWelcome);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Users_TSMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AccountSetting_TSMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CurrentUserInfo_TSMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangePassword_TSMenuItem;
        private System.Windows.Forms.ToolStripSeparator signOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SignOut_TSMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUserWelcome;
        private System.Windows.Forms.ToolStripMenuItem Services_TSMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpTSMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutTSMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InstructionsTSMenuItem;
    }
}

