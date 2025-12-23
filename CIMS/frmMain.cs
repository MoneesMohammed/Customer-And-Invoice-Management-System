using CIMS.Global_Classes;
using CIMS.Help;
using CIMS.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIMS
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            //panelSidebar.Visible = false;
        }

        private void SignOut_TSMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void ctrlSidebarForServices1_OnLogoutClicked()
        //{ 
            
        
        //}

        private void Services_TSMenuItem_Click(object sender, EventArgs e)
        {
            //frmServices form = new frmServices();
            //form.ShowDialog();
            
            panelSidebar.Visible = !panelSidebar.Visible;
        }

        private void Users_TSMenuItem_Click(object sender, EventArgs e)
        {
            frmUsers frm = new frmUsers();
            frm.ShowDialog();
        }

        private void CurrentUserInfo_TSMenuItem_Click(object sender, EventArgs e)
        {
            frmShowUserInfo frm = new frmShowUserInfo(clsGlobal.CurrentUser.UserID);
            frm.ShowDialog();
        }

        private void ChangePassword_TSMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword(clsGlobal.CurrentUser.UserID);
            frm.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblUserWelcome.Text = $"👋 Welcome! {clsGlobal.CurrentUser.UserName}";
        }

        private void AboutTSMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout frmAbout = new frmAbout();
            frmAbout.ShowDialog();
        }

        private void InstructionsTSMenuItem_Click(object sender, EventArgs e)
        {
            frmInstructions frmInstructions = new frmInstructions();
            frmInstructions.ShowDialog();
        }

        private void panelSidebar_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(
               panelSidebar.ClientRectangle,
               Color.FromArgb(60, 120, 200),
               Color.FromArgb(120, 60, 160),
               90f))
            {
                e.Graphics.FillRectangle(brush, panelSidebar.ClientRectangle);
            }
        }

        private void ctrlSidebarForServices1_OnLogoutClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            panelSidebar.Visible = false;
        }

        private void linkedin_Click(object sender, EventArgs e)
        {
            llbllinkedin.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/mounes-alshawashi-466396372/");
        }

        private void GitHub_Click(object sender, EventArgs e)
        {
            llblGitHub.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/MoneesMohammed");
        }
    }
}
