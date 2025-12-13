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
    public partial class CtrlInvoiceInfo : UserControl
    {
        private DataTable _dtInvoiceDetails;

        private int _InvoiceID = -1;
        private clsInvoice _Invoice;

        public int InvoiceID { get { return _InvoiceID; } }
        public clsInvoice SelectedInvoiceInfo { get { return _Invoice; } }

        public CtrlInvoiceInfo()
        {
            InitializeComponent();
        }

        private void _RefreshInvoiceList()
        {
            _dtInvoiceDetails = clsInvoiceDetail.GetAllInvoiceDetails(_InvoiceID);

            dgvAllInvoiceDetails.DataSource = _dtInvoiceDetails;

            _FormatDGV();

        }

        private void _FormatDGV()
        {
            if (dgvAllInvoiceDetails.Rows.Count <= 0)
            {
                return;
            }

            dgvAllInvoiceDetails.Columns[0].Width = 100;
            dgvAllInvoiceDetails.Columns[1].Width = 310;
            dgvAllInvoiceDetails.Columns[2].Width = 150;
            dgvAllInvoiceDetails.Columns[3].Width = 150;
            dgvAllInvoiceDetails.Columns[4].Width = 170;


        }


        public void LoadInvoiceInfo(int InvoiceID)
        {
            _Invoice = clsInvoice.Find(InvoiceID);

            if (_Invoice == null)
            {
                ResetInvoiceInfo();
                MessageBox.Show($"No Invoice With InvoiceID ={InvoiceID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            _FillInvoiceInfo();
            _RefreshInvoiceList();

        }

        private void _FillInvoiceInfo()
        {
            _InvoiceID = _Invoice.InvoiceID;

            lblInvoiceID.Text = _Invoice.InvoiceID.ToString();
            lblCustomerID.Text = _Invoice.CustomerID.ToString();
            lblName.Text = _Invoice.CustomerInfo.FullName;
            lblDate.Text = _Invoice.InvoiceDate.ToString("dd MMM yyyy");

            lblTotalAmount.Text = _Invoice.TotalAmount.ToString();



            if (_Invoice.InvoiceStatus == clsInvoice.enInvoiceStatus.Pending)
            {
                lblPaidT.Visible = true;
                lblPaid.Visible = true;
                lblRemainingAmountT.Visible = true;
                lblRemainingAmount.Visible = true;

                float TotalPaid = clsPayment.GetTotalPaidByInvoiceID(_InvoiceID);

                lblPaid.Text = TotalPaid.ToString();
                lblRemainingAmount.Text = (_Invoice.TotalAmount - TotalPaid).ToString();

            }
            else if (_Invoice.InvoiceStatus == clsInvoice.enInvoiceStatus.Paid)
            {
                lblPaid.Visible = true;
                lblPaid.Text = "Is Paid";
            }
            else if (_Invoice.InvoiceStatus == clsInvoice.enInvoiceStatus.Cancelled)
            {
                lblPaid.Visible = true;
                lblPaid.Text = "Is Cancelled";
                lblPaid.ForeColor = Color.Red;
            }
            else
            {

                lblPaidT.Visible = false;
                lblPaid.Visible = false;
                lblRemainingAmountT.Visible = false;
                lblRemainingAmount.Visible = false;
                lblPaid.ForeColor = Color.Green;
            }


        }

        public void ResetInvoiceInfo()
        {
            _InvoiceID = -1;

            lblInvoiceID.Text = "[???]";
            lblCustomerID.Text = "[???]";
            lblName.Text = "[???]";
            lblDate.Text = DateTime.Now.ToString("dd MMM yyyy"); //07 Jan 2022

            dgvAllInvoiceDetails.DataSource = null;

            lblTotalAmount.Text = "000";
            lblPaid.Text = "000";
            lblRemainingAmount.Text ="000";

            lblPaidT.Visible = false;
            lblPaid.Visible = false;
            lblRemainingAmountT.Visible = false;
            lblRemainingAmount.Visible = false;

        }




    }
}
