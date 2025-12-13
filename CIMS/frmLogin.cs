using CIMS.Global_Classes;
using CIMS.Properties;
using CIMS_BusinessLayer;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShowHidePassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                btnShowHidePassword.Image = Resources.show;
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
                btnShowHidePassword.Image = Resources.close_eye;

            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUserName.Focus();

            string UserName = "", Password = "";

            if (clsGlobal.GetStoredCredential(ref UserName, ref Password))
            {

                txtUserName.Text = UserName;
                txtPassword.Text = Password;
                cbRememberMe.Checked = true;
            }
            else
            {
                cbRememberMe.Checked = false;
            }
        }

        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            clsUser user = clsUser.FindByUserNameAndPassword(txtUserName.Text.Trim(), txtPassword.Text.Trim());


            if (user != null)
            {
                if (user.IsActive)
                {
                    if (cbRememberMe.Checked)
                    {
                        clsGlobal.RememberUsernameAndPassword(txtUserName.Text.Trim(), txtPassword.Text.Trim());
                    }
                    else
                    {
                        clsGlobal.RememberUsernameAndPassword("", "");
                    }

                    clsGlobal.CurrentUser = user;
                    this.DialogResult = DialogResult.OK;
                    this.Close();

                }
                else
                {
                    txtUserName.Focus();
                    MessageBox.Show("your account is not active it..\nplease contact your admin", "Warning Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                txtUserName.Focus();
                MessageBox.Show("Invalid The Username/Password .", "Warning Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
