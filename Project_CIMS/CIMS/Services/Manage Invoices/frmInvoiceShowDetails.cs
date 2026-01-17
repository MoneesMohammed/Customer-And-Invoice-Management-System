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

namespace CIMS.Services.Manage_Invoices
{
    public partial class frmInvoiceShowDetails : Form
    {
        private int _InvoiceID = -1;
       
        public frmInvoiceShowDetails(int InvoiceID)
        {
            InitializeComponent();
            _InvoiceID = InvoiceID;
        }
       
        private void frmInvoiceShowDetails_Load(object sender, EventArgs e)
        {
            ctrlInvoiceInfo1.LoadInvoiceInfo(_InvoiceID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
