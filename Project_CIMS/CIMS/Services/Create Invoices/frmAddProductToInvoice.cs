using CIMS.UserControls.CtrlProduct;
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

namespace CIMS.Services.Create_Invoices
{
    public partial class frmAddProductToInvoice : Form
    {
        //Delegate
        public delegate void DataProductsAddedEventHandler(object sender, DataTable dtProductsAdded);

        public event DataProductsAddedEventHandler DataBackProductsAdded;

        private DataTable _dtProducts = new DataTable();
        private DataTable _dtProductsAdded = new DataTable();

        private DataTable _dtOldProductsAdded = new DataTable();

        public frmAddProductToInvoice()
        {
            InitializeComponent();

        }

        public frmAddProductToInvoice(DataTable dtProductsAdded)
        {
            InitializeComponent();
            _dtOldProductsAdded = dtProductsAdded;
        }

        private void _RefreshProductsList()
        {
            flowLayoutPanel1.Controls.Clear();

            _dtProducts = clsProduct.GetAllProducts();
            
            if (_dtProducts.Rows.Count == 0)
                return;

            foreach (DataRow row in _dtProducts.Rows)
            {
                int ProductID = Convert.ToInt32(row["ProductID"]);
                _AddProductCard(ProductID);
            }

            lblCountProductsAdded.Text = _dtOldProductsAdded.Rows.Count.ToString();


        }

        private void _AddProductCard(int ProductID)
        {
            CtrlProductCard card = new CtrlProductCard();

            card.AddProductEnabled = true;
            card.LoadProductInfo(ProductID);

            if (_dtOldProductsAdded.Rows.Count == _dtProducts.Rows.Count)
            {
                card.btnAddProductEnabled = false;

            }
            else if (_dtOldProductsAdded.Rows.Count != 0)
            {

                foreach (DataRow row in _dtOldProductsAdded.Rows)
                {
                    int productID = Convert.ToInt32(row["ProductID"]);

                    if (productID == ProductID)
                        card.btnAddProductEnabled = false;
                }

            }

            card.DataBackForAddProduct += CardProductInfo_DataBackForAddProduct;

            if (card.SelectedProductInfo != null)
                flowLayoutPanel1.Controls.Add(card);


        }

        private void CardProductInfo_DataBackForAddProduct(object sender, int ProductID, int Quantity, float UnitPrice, float SubTotal)
        {
            _dtProductsAdded.Rows.Add(ProductID, clsProduct.Find(ProductID).Name, Quantity, UnitPrice, SubTotal);

            lblCountProductsAdded.Text = (_dtOldProductsAdded.Rows.Count + _dtProductsAdded.Rows.Count).ToString();
        }

        private void frmAddProductToInvoice_Load(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = 0;
            _RefreshProductsList();
            _CreateColumnsForDataTable();
        }

        private void _CreateColumnsForDataTable()
        {
            _dtProductsAdded.Columns.Add("ProductID" ,typeof(int));
            _dtProductsAdded.Columns.Add("Product Name", typeof(string));
            _dtProductsAdded.Columns.Add("Quantity", typeof(int));
            _dtProductsAdded.Columns.Add("UnitPrice", typeof(float));
            _dtProductsAdded.Columns.Add("SubTotal", typeof(float));

        }


        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtFilterBy.Text != "")
                txtFilterBy.Text = string.Empty;

            if (cbFilterBy.Text == "None")
            {
                txtFilterBy.Visible = false;

                _RefreshProductsList();
            }
            else
            {
                txtFilterBy.Visible = true;

                txtFilterBy.Focus();
            }
        }

        private void txtFilterBy_TextChanged(object sender, EventArgs e)
        {
            _dtProducts = clsProduct.GetAllProducts();

            string FilterColumn = cbFilterBy.Text;

            if (txtFilterBy.Text.Trim() == "" || FilterColumn == "None")
            {
                //_RefreshProductsList();
                return;
            }

            if (FilterColumn == "ProductID")
                _dtProducts.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterBy.Text.Trim()); //[FilterColumn] = txtFilterBy.Text
            else
                _dtProducts.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterBy.Text.Trim());
            //[FilterColumn] LIKE 'txtFilterBy.Text%'

            flowLayoutPanel1.Controls.Clear();

            foreach (DataRowView rowView in _dtProducts.DefaultView)
            {
                DataRow row = rowView.Row;

                int ProductID = Convert.ToInt32(row["ProductID"]);
                _AddProductCard(ProductID);
            }

        }

        private void txtFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "ProductID")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DataBackProductsAdded?.Invoke(sender, _dtProductsAdded);
            this.Close();
        }
    }
}
