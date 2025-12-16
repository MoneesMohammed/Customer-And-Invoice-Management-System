using CIMS.Global_Classes;
using CIMS.Services.Create_Invoices;
using CIMS.Services.Manage_Invoices;
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

namespace CIMS.UserControls.CtrlInvoices
{
    public partial class CtrlInvoicesDGV : UserControl
    {
        private DataTable _dtInvoicesHistory;

        private int _CustomerID = -1;
      
        public int CustomerID { get { return _CustomerID; } }

        public CtrlInvoicesDGV()
        {
            InitializeComponent();
        }

        private void _LoadInvoicesInfo()
        {
            _dtInvoicesHistory = clsInvoice.GetInvoicesByCustomerID(_CustomerID);
            dgvInvoicesHistory.DataSource = _dtInvoicesHistory;
            lblRecodes.Text = dgvInvoicesHistory.Rows.Count.ToString();

            _FormatInvoicesDGV();
        }

        private void _FormatInvoicesDGV()
        {
            if (dgvInvoicesHistory.Rows.Count <= 0)
            { return; }

            dgvInvoicesHistory.Columns[0].Width = 180;
            dgvInvoicesHistory.Columns[1].Width = 388;
            dgvInvoicesHistory.Columns[2].Width = 298;
            dgvInvoicesHistory.Columns[3].Width = 164;
            dgvInvoicesHistory.Columns[4].Width = 159;

        }

        public void LoadInfo(int CustomerID)
        {
            if (CustomerID == -1)
            {
                MessageBox.Show("There Is No Invoices Linked With Customer With ID = " + CustomerID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

             _CustomerID = CustomerID;

            _LoadInvoicesInfo();

        }

        public void Clear()
        {
            _dtInvoicesHistory.Clear();
        }

        private void tsmShowDetails_Click(object sender, EventArgs e)
        {
            int InvoiceID = (int)dgvInvoicesHistory.CurrentRow.Cells[0].Value;
            frmInvoiceShowDetails frm = new frmInvoiceShowDetails(InvoiceID);
            frm.ShowDialog();
        }

        private void tsmEdit_Click(object sender, EventArgs e)
        {
            int InvoiceID = (int)dgvInvoicesHistory.CurrentRow.Cells[0].Value;

            frmCreateInvoices frm = new frmCreateInvoices(InvoiceID);
            frm.ShowDialog();

            _LoadInvoicesInfo();
        }

        private void tsmDelete_Click(object sender, EventArgs e)
        {
            int InvoiceID = (int)dgvInvoicesHistory.CurrentRow.Cells[0].Value;

            var result = MessageBox.Show($"Are you sure you want to delete the Invoice by InvoiceID: {InvoiceID}", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                RevertOldInvoiceStock(InvoiceID);
                clsInvoiceDetail.DeleteAllInvoiceDetails(InvoiceID);


                if (clsInvoice.Find(InvoiceID).Delete())
                {

                    MessageBox.Show("Invoice has been deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    _LoadInvoicesInfo();
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
            int InvoiceID = (int)dgvInvoicesHistory.CurrentRow.Cells[0].Value;

            var result = MessageBox.Show($"Are you sure you want to Cancel the Invoice by InvoiceID: {InvoiceID}", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                if (clsInvoice.Find(InvoiceID).SetStatus(clsInvoice.enInvoiceStatus.Cancelled))
                {

                    MessageBox.Show("Invoice has been Cancelled successfully.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    _LoadInvoicesInfo();
                }
                else
                {
                    MessageBox.Show("Invoice was not Cancelled because it has data linked to it.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }


        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            string StatusText = (string)dgvInvoicesHistory.CurrentRow.Cells[3].Value;


            if (StatusText == "Cancelled" || StatusText == "Paid")
            {
                tsmDelete.Enabled = false;
                tsmEdit.Enabled = false;
                tsmCancel.Enabled = false;
                tsmPay.Enabled = false;

            }
            else if (StatusText == "Pending")
            {
                tsmDelete.Enabled = false;
                tsmEdit.Enabled = false;
                tsmCancel.Enabled = false;
                tsmPay.Enabled = true;
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
            int InvoiceID = (int)dgvInvoicesHistory.CurrentRow.Cells[0].Value;

            frmAddEditPaymentInfo frm = new frmAddEditPaymentInfo(InvoiceID);
            frm.ShowDialog();

            _LoadInvoicesInfo();
        }

        private void tsmSaveToPDF_Click(object sender, EventArgs e)
        {
            int InvoiceID = (int)dgvInvoicesHistory.CurrentRow.Cells[0].Value;

            clsPDF.GenerateInvoicePDF(InvoiceID);
        }


    }
}
