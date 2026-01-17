using CIMS.Services.Manage_Invoices;
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

namespace CIMS.Customers
{
    public partial class frmCustomers : Form
    {
        private DataTable _dtAllCustomers;
        public frmCustomers()
        {
            InitializeComponent();
        }

        private void _RefreshCustomerList()
        {
            _dtAllCustomers = clsCustomer.GetAllCustomers();

            dgvAllCustomers.DataSource = _dtAllCustomers;

            lblRecodes.Text = dgvAllCustomers.Rows.Count.ToString();
            _FormatDGV();

        }

        private void _FormatDGV()
        {
            if (dgvAllCustomers.Rows.Count <= 0)
            { 
              return;
            }
                
            dgvAllCustomers.Columns[0].Width = 150;
            dgvAllCustomers.Columns[1].Width = 300;
            dgvAllCustomers.Columns[2].Width = 100;
            dgvAllCustomers.Columns[3].Width = 150;
            dgvAllCustomers.Columns[4].Width = 150;
            dgvAllCustomers.Columns[5].Width = 200;
           
        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            _RefreshCustomerList();

            cbFilterBy.SelectedIndex = 0;
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

                _RefreshCustomerList();
            }
            else
            {
                txtFilterBy.Visible = true;
                
                txtFilterBy.Focus();
            }
        }

        private void txtFilterBy_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = cbFilterBy.Text;

            if (txtFilterBy.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAllCustomers.DefaultView.RowFilter = "";
                lblRecodes.Text = _dtAllCustomers.Rows.Count.ToString();
                return;
            }

            if (FilterColumn == "Customer ID")
                _dtAllCustomers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterBy.Text.Trim()); //[FilterColumn] = txtFilterBy.Text
            else
                _dtAllCustomers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterBy.Text.Trim());
            //[FilterColumn] LIKE 'txtFilterBy.Text%'

            lblRecodes.Text = _dtAllCustomers.Rows.Count.ToString();
        }

        private void txtFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Customer ID" || cbFilterBy.Text == "Phone")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

            }
        }


        private void AddNewCustomer_Click(object sender, EventArgs e)
        {
            frmAddEditCustomerInfo frm = new frmAddEditCustomerInfo();
            frm.ShowDialog();

            _RefreshCustomerList();
        }

        private void tsmShowDetails_Click(object sender, EventArgs e)
        {
            int CustomerID = (int)dgvAllCustomers.CurrentRow.Cells[0].Value;
            
            frmShowCustomerInfo frm = new frmShowCustomerInfo(CustomerID);
            frm.ShowDialog();
        }

        private void tsmEdit_Click(object sender, EventArgs e)
        {
            int CustomerID = (int)dgvAllCustomers.CurrentRow.Cells[0].Value;

            frmAddEditCustomerInfo frm = new frmAddEditCustomerInfo(CustomerID);
            frm.ShowDialog();

            _RefreshCustomerList();
        }

        private void tsmDelete_Click(object sender, EventArgs e)
        {
            clsCustomer Customer = clsCustomer.Find((int)dgvAllCustomers.CurrentRow.Cells[0].Value);

            var result = MessageBox.Show($"Are you sure you want to delete the Customer \nby CustomerID: {Customer.CustomerID}", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                if (Customer.Delete())
                {
                   
                    MessageBox.Show("Customer has been deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Customer was not deleted because it has data linked to it.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

            _RefreshCustomerList();
        }

        private void tsmSendEmail_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature will be available soon.", "Send Email", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tsmPhoneCall_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature will be available soon.", "Phone Call", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tsmShowCustomerInvoiceHistory_Click(object sender, EventArgs e)
        {
            int CustomerID = (int)dgvAllCustomers.CurrentRow.Cells[0].Value;
            frmInvoiceHistory frm = new frmInvoiceHistory(CustomerID);
            frm.ShowDialog();
        }
    }
}
