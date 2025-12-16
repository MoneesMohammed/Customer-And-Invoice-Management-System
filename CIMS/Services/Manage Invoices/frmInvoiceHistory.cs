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
    public partial class frmInvoiceHistory : Form
    {
        private int _CustomerID = -1;
        
        public frmInvoiceHistory()
        {
            InitializeComponent();
        }

        public frmInvoiceHistory(int CustomerID)
        {
            InitializeComponent();
            _CustomerID = CustomerID;
        }

        private void frmInvoiceHistory_Load(object sender, EventArgs e)
        {
            if (_CustomerID != -1)
            {
                ctrlFilterCustomer1.LoadCustomerInfo(_CustomerID);
                ctrlFilterCustomer1.FilterEnabled = false;

                ctrlInvoicesDGV1.LoadInfo(_CustomerID);
            }
            else
            {
                ctrlFilterCustomer1.FilterEnabled = true;
                ctrlFilterCustomer1.FilterFocus();
            }
        }

        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrlFilterCustomer1_OnCustomerSelected(int obj)
        {
            _CustomerID = obj;

            if (_CustomerID == -1)
            { ctrlInvoicesDGV1.Clear(); }
            else
            { ctrlInvoicesDGV1.LoadInfo(_CustomerID); }

        }

    }
}
