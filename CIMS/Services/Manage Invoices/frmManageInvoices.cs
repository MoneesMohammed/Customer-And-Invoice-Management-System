using CIMS.Global_Classes;
using CIMS.Services.Create_Invoices;
using CIMS.Services.Payments;
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

namespace CIMS.Services.Manage_Invoices
{
    public partial class frmManageInvoices : Form
    {
        private DataTable _dtAllInvoices;

        public frmManageInvoices()
        {
            InitializeComponent();
        }

        private void _RefreshInvoicesList()
        {
            _dtAllInvoices = clsInvoice.GetAllInvoices();

            dgvAllInvoices.DataSource = _dtAllInvoices;

            lblRecodes.Text = dgvAllInvoices.Rows.Count.ToString();
            _FormatDGV();

        }

        private void _FormatDGV()
        {
            if (dgvAllInvoices.Rows.Count <= 0)
            {
                return;
            }

            dgvAllInvoices.Columns[0].Width = 150;
            dgvAllInvoices.Columns[1].Width = 350;
            dgvAllInvoices.Columns[2].Width = 220;
            dgvAllInvoices.Columns[3].Width = 200;
            dgvAllInvoices.Columns[4].Width = 170;
            

        }

        private void frmManageInvoices_Load(object sender, EventArgs e)
        {
            _RefreshInvoicesList();
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
                cbStatus.Visible = false;
                _RefreshInvoicesList();
            }
            else if (cbFilterBy.Text == "Status")
            {
                cbStatus.SelectedIndex = 0;

                txtFilterBy.Visible = false;
                cbStatus.Visible = true;
            }
            else
            {
                txtFilterBy.Visible = true;
                cbStatus.Visible = false;
                txtFilterBy.Focus();
            }
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStatus.Text == "All")
            {
                _RefreshInvoicesList();
                return;
            }

            //Paid = 0, Unpaid = 1, Pending = 2, Cancelled = 3

            string FilterColumn = cbStatus.Text.Trim();

            _dtAllInvoices.DefaultView.RowFilter = string.Format($"Status = '{FilterColumn}'");

            lblRecodes.Text = dgvAllInvoices.Rows.Count.ToString();
        }


        private void txtFilterBy_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = cbFilterBy.Text;

            if (txtFilterBy.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAllInvoices.DefaultView.RowFilter = "";
                lblRecodes.Text = _dtAllInvoices.Rows.Count.ToString();
                return;
            }

            if (FilterColumn == "Invoice ID")
                _dtAllInvoices.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterBy.Text.Trim()); //[FilterColumn] = txtFilterBy.Text
            else
                _dtAllInvoices.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterBy.Text.Trim());
            //[FilterColumn] LIKE 'txtFilterBy.Text%'

            lblRecodes.Text = _dtAllInvoices.Rows.Count.ToString();
        }

        private void txtFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Invoice ID" )
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

            }
        }


        private void tsmShowDetails_Click(object sender, EventArgs e)
        {
            int InvoiceID = (int)dgvAllInvoices.CurrentRow.Cells[0].Value;
            frmInvoiceShowDetails frm = new frmInvoiceShowDetails(InvoiceID);
            frm.ShowDialog();
        }

        private void CreateInvoice_Click(object sender, EventArgs e)
        {
            frmCreateInvoices frm = new frmCreateInvoices();
            frm.ShowDialog();

            _RefreshInvoicesList();
        }

        private void tsmEdit_Click(object sender, EventArgs e)
        {
            int InvoiceID = (int)dgvAllInvoices.CurrentRow.Cells[0].Value;

            frmCreateInvoices frm = new frmCreateInvoices(InvoiceID);
            frm.ShowDialog();

            _RefreshInvoicesList();
        }

        private void tsmDelete_Click(object sender, EventArgs e)
        {
            int InvoiceID = (int)dgvAllInvoices.CurrentRow.Cells[0].Value;

            var result = MessageBox.Show($"Are you sure you want to delete the Invoice by InvoiceID: {InvoiceID}", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                RevertOldInvoiceStock(InvoiceID);
                clsInvoiceDetail.DeleteAllInvoiceDetails(InvoiceID);


                if (clsInvoice.Find(InvoiceID).Delete())
                {

                    MessageBox.Show("Invoice has been deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    _RefreshInvoicesList();
                }
                else
                {
                    MessageBox.Show("Invoice was not deleted because it has data linked to it.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void RevertOldInvoiceStock(int InvoiceID)
        {

            DataTable dtOld = clsInvoiceDetail.GetAllInvoiceDetails(InvoiceID);  

            foreach (DataRow rowOld in dtOld.Rows)
            {
                int oldProductID = Convert.ToInt32(rowOld["ProductID"]);
                int oldQuantity = Convert.ToInt32(rowOld["Quantity"]);

                clsProduct.Find(oldProductID).IncreaseStock(oldQuantity);

            }

        }

        private void tsmCancel_Click(object sender, EventArgs e)
        {
            int InvoiceID = (int)dgvAllInvoices.CurrentRow.Cells[0].Value;

            var result = MessageBox.Show($"Are you sure you want to Cancel the Invoice by InvoiceID: {InvoiceID}", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                if (clsInvoice.Find(InvoiceID).SetStatus(clsInvoice.enInvoiceStatus.Cancelled))
                {

                    MessageBox.Show("Invoice has been Cancelled successfully.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    _RefreshInvoicesList();
                }
                else
                {
                    MessageBox.Show("Invoice was not Cancelled because it has data linked to it.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

                

            _RefreshInvoicesList();

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            string StatusText = (string)dgvAllInvoices.CurrentRow.Cells[3].Value;


            if (StatusText == "Cancelled" || StatusText == "Paid")
            {
                tsmDelete.Enabled = false;
                tsmEdit.Enabled = false;
                tsmCancel.Enabled = false;
                tsmPay.Enabled = false;

            }
            else if(StatusText == "Pending")
            {
                tsmDelete.Enabled = false;
                tsmEdit.Enabled = false;
                tsmCancel.Enabled = false;
                tsmPay.Enabled    = true;
            }
            else 
            {
                tsmDelete.Enabled = true;
                tsmEdit.Enabled = true;
                tsmCancel.Enabled = true;
                tsmPay.Enabled = true;
            }



        }

        private void tsmPay_Click(object sender, EventArgs e)
        {
            int InvoiceID = (int)dgvAllInvoices.CurrentRow.Cells[0].Value;

            frmAddEditPaymentInfo frm = new frmAddEditPaymentInfo(InvoiceID);
            frm.ShowDialog();

            _RefreshInvoicesList();
        }

        private void tsmPrintPDF_Click(object sender, EventArgs e)
        {
            //clsPDF.ExportInvoiceToPDF();
            int InvoiceID = (int)dgvAllInvoices.CurrentRow.Cells[0].Value;

            clsInvoice Invoice = clsInvoice.Find(InvoiceID);

           clsPDF.GenerateInvoicePDF(InvoiceID, Invoice.CustomerInfo.FullName , Invoice.InvoiceDate, Invoice.CustomerID.ToString() , clsInvoiceDetail.GetAllInvoiceDetails(InvoiceID) , Invoice.TotalAmount);
        }
    }
}
