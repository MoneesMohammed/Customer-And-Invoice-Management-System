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

namespace CIMS.Users
{
    public partial class frmUsers : Form
    {
        private DataTable _dtUsers = clsUser.GetAllUsers();

        public frmUsers()
        {
            InitializeComponent();
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            _RefreshUsersList();

            cbFilterBy.SelectedIndex = 0;
        }


        private void _RefreshUsersList()
        {
            _dtUsers = clsUser.GetAllUsers();

            dgvAllUsers.DataSource = _dtUsers;

            lblRecodes.Text = dgvAllUsers.Rows.Count.ToString();
            _FormatDGV();
        }

        private void _FormatDGV()
        {
            if (dgvAllUsers.Rows.Count <= 0)
            {
                return;
            }

            dgvAllUsers.Columns[0].Width = 100;
            dgvAllUsers.Columns[1].Width = 365;
            dgvAllUsers.Columns[2].Width = 150;
            dgvAllUsers.Columns[3].Width = 100;
            

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtFilterBy.Text != "")
                txtFilterBy.Text = string.Empty;

            if (cbFilterBy.Text == "None")
            {
                txtFilterBy.Visible = false;
                cbIsActive.Visible = false;
                _RefreshUsersList();
            }
            else if (cbFilterBy.Text == "Is Active")
            {
                cbIsActive.SelectedIndex = 0;

                txtFilterBy.Visible = false;
                cbIsActive.Visible = true;
            }
            else
            {
                txtFilterBy.Visible = true;
                cbIsActive.Visible = false;
                txtFilterBy.Focus();
            }

        }


        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbIsActive.Text == "All")
            {
                _RefreshUsersList();
                return;
            }

            string FilterColumn = (cbIsActive.Text == "Yes") ? "1" : "0";

            _dtUsers.DefaultView.RowFilter = string.Format($"[Is Active] = {FilterColumn}");

            lblRecodes.Text = dgvAllUsers.Rows.Count.ToString();
        }


        private void txtFilterBy_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = cbFilterBy.Text;

            if (txtFilterBy.Text.Trim() == "" || FilterColumn == "None" || FilterColumn == "Is Active")
            {
                _dtUsers.DefaultView.RowFilter = "";
                lblRecodes.Text = _dtUsers.Rows.Count.ToString();
                return;
            }

            if (FilterColumn == "User ID")
                _dtUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterBy.Text.Trim()); //[FilterColumn] = txtFilterBy.Text
            else
                _dtUsers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterBy.Text.Trim());
            //[FilterColumn] LIKE 'txtFilterBy.Text%'

            lblRecodes.Text = dgvAllUsers.Rows.Count.ToString();

        }

        private void txtFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "User ID")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

            }

        }

        private void tsmShowDetails_Click(object sender, EventArgs e)
        {
            int UserID = (int)dgvAllUsers.CurrentRow.Cells[0].Value;

            frmShowUserInfo frm = new frmShowUserInfo(UserID);
            frm.ShowDialog();
        }

        private void AddNewUser_Click(object sender, EventArgs e)
        {
            frmAddEditUserInfo frm = new frmAddEditUserInfo();
            frm.ShowDialog();

            _RefreshUsersList();
        }

        private void tsmEdit_Click(object sender, EventArgs e)
        {
            int UserID = (int)dgvAllUsers.CurrentRow.Cells[0].Value;

            frmAddEditUserInfo frm = new frmAddEditUserInfo(UserID);
            frm.ShowDialog();

            _RefreshUsersList();
        }

        private void tsmDelete_Click(object sender, EventArgs e)
        {
            int UserID = (int)dgvAllUsers.CurrentRow.Cells[0].Value;

            var result = MessageBox.Show($"Are you sure you want to delete the User by UserID: {UserID}", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                if (clsUser.Find(UserID).Delete())
                {

                    MessageBox.Show("User has been deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshUsersList();
                }
                else
                {
                    MessageBox.Show("User was not deleted because it has data linked to it.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void tsmChangePassword_Click(object sender, EventArgs e)
        {
            int UserID = (int)dgvAllUsers.CurrentRow.Cells[0].Value;

            frmChangePassword frm = new frmChangePassword(UserID);
            frm.ShowDialog();
        }

        private void tsmSendEmail_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature will be available soon.", "Send Email", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tsmPhoneCall_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature will be available soon.", "Phone Call", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
