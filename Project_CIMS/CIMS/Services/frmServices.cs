using CIMS.Customers;
using CIMS.Services.Create_Invoices;
using CIMS.Services.Manage_Invoices;
using CIMS.Services.Payments;
using CIMS.Services.Products;
using CIMS.Services.Reports;
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
    public partial class frmServices : Form
    {
        public frmServices()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Customers_Click(object sender, EventArgs e)
        {
            frmCustomers frm = new frmCustomers();
            frm.ShowDialog();
        }

        private void Products_Click(object sender, EventArgs e)
        {
            frmProducts frm = new frmProducts();
            frm.ShowDialog();
        }

        private void CreateInvoices_Click(object sender, EventArgs e)
        {
            frmCreateInvoices frm = new frmCreateInvoices();
            frm.ShowDialog();
        }

        private void Payments_Click(object sender, EventArgs e)
        {
            frmPayments frm = new frmPayments();
            frm.ShowDialog();
        }

        private void ManageInvoices_Click(object sender, EventArgs e)
        {
            frmManageInvoices frm = new frmManageInvoices();
            frm.ShowDialog();
        }

        private void Reports_Click(object sender, EventArgs e)
        {
            frmReports frm = new frmReports();
            frm.ShowDialog();
        }
    }
}
