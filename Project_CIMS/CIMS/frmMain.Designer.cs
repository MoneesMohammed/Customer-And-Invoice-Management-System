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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
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
            this.lblUserWelcome = new System.Windows.Forms.Label();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picGitHub = new System.Windows.Forms.PictureBox();
            this.piclinkedin = new System.Windows.Forms.PictureBox();
            this.llbllinkedin = new System.Windows.Forms.LinkLabel();
            this.llblGitHub = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.ctrlSidebarForServices1 = new CIMS.UserControls.CtrlSidebarForServices();
            this.menuStrip1.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGitHub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclinkedin)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(1636, 68);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
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
            this.Users_TSMenuItem.Image = global::CIMS.Properties.Resources.profile1;
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
            this.SignOut_TSMenuItem.Text = "Logout";
            this.SignOut_TSMenuItem.Click += new System.EventHandler(this.SignOut_TSMenuItem_Click);
            // 
            // HelpTSMenuItem
            // 
            this.HelpTSMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutTSMenuItem,
            this.InstructionsTSMenuItem});
            this.HelpTSMenuItem.Image = global::CIMS.Properties.Resources.help;
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
            // lblUserWelcome
            // 
            this.lblUserWelcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(40)))), ((int)(((byte)(88)))));
            this.lblUserWelcome.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblUserWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserWelcome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUserWelcome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUserWelcome.Location = new System.Drawing.Point(0, 1000);
            this.lblUserWelcome.Name = "lblUserWelcome";
            this.lblUserWelcome.Size = new System.Drawing.Size(1636, 33);
            this.lblUserWelcome.TabIndex = 5;
            this.lblUserWelcome.Text = "👋 Welcome! UserName";
            this.lblUserWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panelSidebar.Controls.Add(this.label4);
            this.panelSidebar.Controls.Add(this.picGitHub);
            this.panelSidebar.Controls.Add(this.piclinkedin);
            this.panelSidebar.Controls.Add(this.llbllinkedin);
            this.panelSidebar.Controls.Add(this.llblGitHub);
            this.panelSidebar.Controls.Add(this.ctrlSidebarForServices1);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 68);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(352, 932);
            this.panelSidebar.TabIndex = 6;
            this.panelSidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSidebar_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::CIMS.Properties.Resources.scale_1200;
            this.pictureBox1.Location = new System.Drawing.Point(0, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1636, 965);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // picGitHub
            // 
            this.picGitHub.BackColor = System.Drawing.Color.Transparent;
            this.picGitHub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGitHub.Image = global::CIMS.Properties.Resources.github;
            this.picGitHub.Location = new System.Drawing.Point(30, 844);
            this.picGitHub.Name = "picGitHub";
            this.picGitHub.Size = new System.Drawing.Size(61, 52);
            this.picGitHub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGitHub.TabIndex = 11;
            this.picGitHub.TabStop = false;
            this.picGitHub.Click += new System.EventHandler(this.GitHub_Click);
            // 
            // piclinkedin
            // 
            this.piclinkedin.BackColor = System.Drawing.Color.Transparent;
            this.piclinkedin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.piclinkedin.Image = global::CIMS.Properties.Resources.linkedin;
            this.piclinkedin.Location = new System.Drawing.Point(141, 844);
            this.piclinkedin.Name = "piclinkedin";
            this.piclinkedin.Size = new System.Drawing.Size(64, 50);
            this.piclinkedin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.piclinkedin.TabIndex = 10;
            this.piclinkedin.TabStop = false;
            this.piclinkedin.Click += new System.EventHandler(this.linkedin_Click);
            // 
            // llbllinkedin
            // 
            this.llbllinkedin.AutoSize = true;
            this.llbllinkedin.BackColor = System.Drawing.Color.Transparent;
            this.llbllinkedin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.llbllinkedin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbllinkedin.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.llbllinkedin.Location = new System.Drawing.Point(136, 899);
            this.llbllinkedin.Name = "llbllinkedin";
            this.llbllinkedin.Size = new System.Drawing.Size(86, 25);
            this.llbllinkedin.TabIndex = 9;
            this.llbllinkedin.TabStop = true;
            this.llbllinkedin.Text = "linkedin";
            this.llbllinkedin.Click += new System.EventHandler(this.linkedin_Click);
            // 
            // llblGitHub
            // 
            this.llblGitHub.AutoSize = true;
            this.llblGitHub.BackColor = System.Drawing.Color.Transparent;
            this.llblGitHub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.llblGitHub.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblGitHub.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.llblGitHub.Location = new System.Drawing.Point(25, 899);
            this.llblGitHub.Name = "llblGitHub";
            this.llblGitHub.Size = new System.Drawing.Size(78, 25);
            this.llblGitHub.TabIndex = 8;
            this.llblGitHub.TabStop = true;
            this.llblGitHub.Text = "GitHub";
            this.llblGitHub.Click += new System.EventHandler(this.GitHub_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(50, 802);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Contact links";
            // 
            // ctrlSidebarForServices1
            // 
            this.ctrlSidebarForServices1.BackColor = System.Drawing.Color.Transparent;
            this.ctrlSidebarForServices1.Location = new System.Drawing.Point(4, 13);
            this.ctrlSidebarForServices1.Name = "ctrlSidebarForServices1";
            this.ctrlSidebarForServices1.Size = new System.Drawing.Size(345, 618);
            this.ctrlSidebarForServices1.TabIndex = 0;
            this.ctrlSidebarForServices1.OnLogoutClicked += new System.EventHandler(this.ctrlSidebarForServices1_OnLogoutClicked);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1636, 1033);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.lblUserWelcome);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGitHub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclinkedin)).EndInit();
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
        private System.Windows.Forms.Panel panelSidebar;
        private UserControls.CtrlSidebarForServices ctrlSidebarForServices1;
        private System.Windows.Forms.PictureBox picGitHub;
        private System.Windows.Forms.PictureBox piclinkedin;
        private System.Windows.Forms.LinkLabel llbllinkedin;
        private System.Windows.Forms.LinkLabel llblGitHub;
        private System.Windows.Forms.Label label4;
    }
}

