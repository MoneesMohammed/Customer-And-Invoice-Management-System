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

namespace CIMS.Services.Products
{
    public partial class frmProducts : Form
    {
        private DataTable _dtProducts;

        public frmProducts()
        {
            InitializeComponent();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _RefreshProductsList()
        {
            flowLayoutPanel1.Controls.Clear();

            _dtProducts = clsProduct.GetAllProducts();
            //dgvAllPeople.DataSource = _dtPeople;

            lblRecodes.Text = _dtProducts.Rows.Count.ToString();

            if (_dtProducts.Rows.Count == 0)
                return;

            foreach (DataRow row in _dtProducts.Rows)
            {
                int ProductID = Convert.ToInt32(row["ProductID"]);
                _AddProductCard(ProductID);
            }
            
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = 0;
            _RefreshProductsList();
        }

        private void butAddProduct_Click(object sender, EventArgs e)
        {
            frmAddEditProductInfo frmAddProductInfo = new frmAddEditProductInfo();
            frmAddProductInfo.ShowDialog();

            _RefreshProductsList();
            
        }

        private void _AddProductCard(int ProductID)
        {
            CtrlProductCard card = new CtrlProductCard();
            card.LoadProductInfo(ProductID);

            card.DataBack += CardProductInfo_DataBack;

            if (card.SelectedProductInfo != null)
            flowLayoutPanel1.Controls.Add(card);
        }

        private void CardProductInfo_DataBack(object sender, int ProductID)
        {
            //CtrlProductCard clickedCard = (CtrlProductCard)sender;

            //MessageBox.Show("تم الضغط على البطاقة: " + clickedCard.SelectedProductInfo.Name);
            _RefreshProductsList();
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

            if (FilterColumn == "ProductID" )
                _dtProducts.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterBy.Text.Trim()); //[FilterColumn] = txtFilterBy.Text
            else
                _dtProducts.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterBy.Text.Trim());
            //[FilterColumn] LIKE 'txtFilterBy.Text%'

            lblRecodes.Text = _dtProducts.DefaultView.Count.ToString();

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
    }
}
