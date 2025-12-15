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

namespace CIMS.Services.Reports
{
    public partial class frmReports : Form
    {
        private DataTable _dtSalesReport;
        private DataTable _dtTopProducts;
        private DataTable _dtCustomersReport;

        public frmReports()
        {
            InitializeComponent();
        }

        private void _RefreshReportLists()
        {
            _dtSalesReport     = clsReport.GetSalesReport();
            _dtTopProducts     = clsReport.GetTopProducts();
            _dtCustomersReport = clsReport.GetCustomersReport();

            dgvSalesReport.DataSource     = _dtSalesReport;
            dgvTopProducts.DataSource     = _dtTopProducts;
            dgvCustomersReport.DataSource = _dtCustomersReport;
            
            _FormatSalesDGV();
            _FormatTopProductsDGV();
            _FormatCustomersDGV();

        }

        private void frmReports_Load(object sender, EventArgs e)
        {
            _RefreshReportLists();
            cbFilterSalesBy.SelectedIndex = 0;
            cbFilterProductsBy.SelectedIndex = 0;
            cbFilterCustomersBy.SelectedIndex = 0;
        }

        private void _FormatSalesDGV()
        {
            if (dgvSalesReport.Rows.Count <= 0)
            { return; }
               
            dgvSalesReport.Columns[0].Width = 178;
            dgvSalesReport.Columns[1].Width = 174;
            
        }

        private void _FormatTopProductsDGV()
        {
            if (dgvTopProducts.Rows.Count <= 0)
            { return; }

            dgvTopProducts.Columns[0].Width = 202;
            dgvTopProducts.Columns[1].Width = 150;

        }

        private void _FormatCustomersDGV()
        {
            if (dgvCustomersReport.Rows.Count <= 0)
            { return; }

            dgvCustomersReport.Columns[0].Width = 124;
            dgvCustomersReport.Columns[1].Width = 279;
            dgvCustomersReport.Columns[2].Width = 138;
            dgvCustomersReport.Columns[3].Width = 126;

            //124 279 138 126
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveToPDF_Click(object sender, EventArgs e)
        {

        }

        private void cbFilterSalesBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterSalesBy.Text == "None")
            {
                cbSalesDate.Visible = false;

                _dtSalesReport = clsReport.GetSalesReport();
                dgvSalesReport.DataSource = _dtSalesReport; 
            }
            else
            {
                if(cbSalesDate.Items.Count == 0)
                _FillSalesDateInComboBox();

                cbSalesDate.SelectedIndex = 0;
                cbSalesDate.Visible = true;
            }
        }

        private void cbSalesDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = cbSalesDate.Text.Trim();

            _dtSalesReport.DefaultView.RowFilter = string.Format($"[Sale Date] = '{FilterColumn}'");

        }

        private void _FillSalesDateInComboBox()
        {
            DataTable dtSales = clsReport.GetSalesReport();

            foreach (DataRow row in dtSales.Rows)
            {
                cbSalesDate.Items.Add(row["Sale Date"]);
            }

        }

        private void cbFilterProductsBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtFilterProductsBy.Text != "")
                txtFilterProductsBy.Text = string.Empty;

            if (cbFilterProductsBy.Text == "None")
            {
                txtFilterProductsBy.Visible = false;
                _dtTopProducts = clsReport.GetTopProducts();
                dgvTopProducts.DataSource = _dtTopProducts;
            }
            else
            {
                txtFilterProductsBy.Visible = true;
                txtFilterProductsBy.Focus();
            }
        }

        private void txtFilterProductsBy_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = cbFilterProductsBy.Text;

            if (txtFilterProductsBy.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtTopProducts.DefaultView.RowFilter = "";
                return;
            }

            _dtTopProducts.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterProductsBy.Text.Trim());
            //[FilterColumn] LIKE 'txtFilterBy.Text%'

        }

        private void cbFilterCustomersBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtFilterCustomersBy.Text != "")
                txtFilterCustomersBy.Text = string.Empty;

            if (cbFilterCustomersBy.Text == "None")
            {
                txtFilterCustomersBy.Visible = false;
                _dtCustomersReport = clsReport.GetCustomersReport();
                dgvCustomersReport.DataSource = _dtCustomersReport;
            }
            else
            {
                txtFilterCustomersBy.Visible = true;
                txtFilterCustomersBy.Focus();
            }
        }

        private void txtFilterCustomersBy_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = cbFilterCustomersBy.Text;

            if (txtFilterCustomersBy.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtCustomersReport.DefaultView.RowFilter = "";
                return;
            }

            if (FilterColumn == "Customer ID")
                _dtCustomersReport.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterCustomersBy.Text.Trim()); //[FilterColumn] = txtFilterBy.Text
            else
                _dtCustomersReport.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterCustomersBy.Text.Trim());
            //[FilterColumn] LIKE 'txtFilterBy.Text%'

        }

        private void txtFilterCustomersBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterCustomersBy.Text == "Customer ID")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

            }
        }
    }
}
