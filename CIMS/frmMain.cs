using CIMS.Global_Classes;
using CIMS.Help;
using CIMS.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

        private void SignOut_TSMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Services_TSMenuItem_Click(object sender, EventArgs e)
        {
            frmServices form = new frmServices();
            form.ShowDialog();
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
    }
}
