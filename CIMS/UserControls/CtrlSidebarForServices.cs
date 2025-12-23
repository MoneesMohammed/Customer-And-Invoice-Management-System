using CIMS.Customers;
using CIMS.Services.Create_Invoices;
using CIMS.Services.Manage_Invoices;
using CIMS.Services.Payments;
using CIMS.Services.Products;
using CIMS.Services.Reports;
using CIMS.UserControls.CtrlCustomer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIMS.UserControls
{
    public partial class CtrlSidebarForServices : UserControl
    {

        public event EventHandler OnLogoutClicked;

        public CtrlSidebarForServices()
        {
            InitializeComponent();
        }

        private void btn_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.Text == "Logout")
            {
                btn.BackColor = Color.FromArgb(40, Color.Red);
            }
            else
                btn.BackColor = Color.FromArgb(40, Color.RoyalBlue);
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Transparent;
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            frmCustomers frm = new frmCustomers();
            frm.ShowDialog();
        }

        private void btnManageInvoices_Click(object sender, EventArgs e)
        {
            frmManageInvoices frm = new frmManageInvoices();
            frm.ShowDialog();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            frmProducts frm = new frmProducts();
            frm.ShowDialog();
        }

        private void btnCreateInvoice_Click(object sender, EventArgs e)
        {
            frmCreateInvoices frm = new frmCreateInvoices();
            frm.ShowDialog();
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            frmPayments frm = new frmPayments();
            frm.ShowDialog();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            frmReports frm = new frmReports();
            frm.ShowDialog();
        }

        private void butLogout_Click(object sender, EventArgs e)
        {
            OnLogoutClicked?.Invoke(sender,e);
        }
    }
}
