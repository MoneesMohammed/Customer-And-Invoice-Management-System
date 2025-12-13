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

namespace CIMS.Services.Payments
{
    public partial class frmPayments : Form
    {
        private DataTable _dtAllPayments;

        public frmPayments()
        {
            InitializeComponent();
        }

        private void _RefreshPaymentsList()
        {
            _dtAllPayments = clsPayment.GetAllPayments();

            dgvAllPayments.DataSource = _dtAllPayments;

            lblRecodes.Text = dgvAllPayments.Rows.Count.ToString();
            _FormatDGV();

        }

        private void _FormatDGV()
        {
            if (dgvAllPayments.Rows.Count <= 0)
            {
                return;
            }

            dgvAllPayments.Columns[0].Width = 150;
            dgvAllPayments.Columns[1].Width = 150;
            dgvAllPayments.Columns[2].Width = 180;
            dgvAllPayments.Columns[3].Width = 250;
            dgvAllPayments.Columns[4].Width = 150;


        }

        private void frmPayments_Load(object sender, EventArgs e)
        {
            _RefreshPaymentsList();
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
                cbPaymentMethod.Visible = false;
                _RefreshPaymentsList();
            }
            else if (cbFilterBy.Text == "Payment Method")
            {
                cbPaymentMethod.SelectedIndex = 0;

                txtFilterBy.Visible = false;
                cbPaymentMethod.Visible = true;
            }
            else
            {
                txtFilterBy.Visible = true;
                cbPaymentMethod.Visible = false;
                txtFilterBy.Focus();
            }
        }

        private void cbPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPaymentMethod.Text == "All")
            {
                _RefreshPaymentsList();
                return;
            }

            //Cash = 0, CreditCard = 1, DebitCard = 2, Check = 3, ElectronicFundsTransfer = 4, DigitalWallet = 5

            string FilterColumn = cbPaymentMethod.Text.Trim();

            _dtAllPayments.DefaultView.RowFilter = string.Format($"[Payment Method] = '{FilterColumn}'");

            lblRecodes.Text = dgvAllPayments.Rows.Count.ToString();
        }

        private void txtFilterBy_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = cbFilterBy.Text;

            if (txtFilterBy.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAllPayments.DefaultView.RowFilter = "";
                lblRecodes.Text = _dtAllPayments.Rows.Count.ToString();
                return;
            }

           
           _dtAllPayments.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterBy.Text.Trim()); //[FilterColumn] = txtFilterBy.Text
            

            lblRecodes.Text = _dtAllPayments.Rows.Count.ToString();
        }

        private void txtFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
           {
               e.Handled = true;
           }

        }

        private void butAddNewPayment_Click(object sender, EventArgs e)
        {
            frmAddEditPaymentInfo frm = new frmAddEditPaymentInfo();
            frm.ShowDialog();

            _RefreshPaymentsList();
        }

        private void tsmShowDetails_Click(object sender, EventArgs e)
        {
            int InvoiceID = (int)dgvAllPayments.CurrentRow.Cells[1].Value;
            frmInvoiceShowDetails frm = new frmInvoiceShowDetails(InvoiceID);
            frm.ShowDialog();
        }
    }
}
