using CIMS.Properties;
using CIMS.Services.Create_Invoices;
using CIMS.Services.Products;
using CIMS_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIMS.UserControls.CtrlProduct
{
    public partial class CtrlProductCard : UserControl
    {
        //Delegate
        public delegate void DataFoundEventHandler(object sender, int ProductID);

        public event DataFoundEventHandler DataBack;

        //Delegate
        public delegate void DataForAddProductEventHandler(object sender, int ProductID, int Quantity, float UnitPrice, float SubTotal);

        public event DataForAddProductEventHandler DataBackForAddProduct;


        private clsProduct _Product;
        private int _ProductID = -1;

        public int ProductID { get { return _ProductID; } }
        public clsProduct SelectedProductInfo { get { return _Product; } }

       

        private bool _AddProductEnabled = false;

        public bool AddProductEnabled
        {

            get { return _AddProductEnabled; }

            set
            {
                _AddProductEnabled = value;

                tsmDelete.Enabled       = !_AddProductEnabled;
                tsmEdit.Enabled         = !_AddProductEnabled;
                tsmAddProduct.Enabled   = _AddProductEnabled;
               //tsmUnaddProduct.Enabled = _AddProductEnabled;


                btnReadMore.Visible     = !_AddProductEnabled;
                btnAddProduct.Visible   = _AddProductEnabled;
                
            }
        }

        private bool _btnAddProductEnabled = true;

        public bool btnAddProductEnabled
        {

            get { return _btnAddProductEnabled; }

            set
            {
                _btnAddProductEnabled = value;

                tsmAddProduct.Enabled = _btnAddProductEnabled;
                
                btnAddProduct.Enabled = _btnAddProductEnabled;
            }
        }


        //public CtrlProductCard SelectedProductCard;CtrlProductInfo

        public CtrlProductCard()
        {
            InitializeComponent();
        }

        public void LoadProductInfo(int ProductID)
        {
            _Product = clsProduct.Find(ProductID);

            if (_Product == null)
            {
                ResetProductInfo();
                MessageBox.Show($"No Product With ProductID ={ProductID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillProductInfo();

        }

        private void _FillProductInfo()
        {
            _ProductID = _Product.ProductID;

            lblName.Text = _Product.Name.Trim();
            lblPrice.Text =  $"$ {_Product.Price}";
            lblDescription.Text = _Product.Description.Trim();
            lblQuantityInStock.Text = $"Stock : {_Product.QuantityInStock}";

            lblOutOfStock.Visible = (_Product.QuantityInStock == 0);

            btnAddProductEnabled = !(_Product.QuantityInStock == 0);

            _LoadProductImage();

        }

        private void ResetProductInfo()
        {
            _ProductID = -1;
            
            btnReadMore.Enabled = false;
            lblName.Text = "[???????]";
            lblPrice.Text = $"$ 0"; ;
            lblDescription.Text = "[???????]";
            lblQuantityInStock.Text = "Stock : 0";
            lblOutOfStock.Visible = true;

            pbProductImage.Image = Resources.product_default;

        }

        private void _LoadProductImage()
        {
            pbProductImage.Image = Resources.product_default;

            string ImagePath = _Product.ImagePath;

            if (ImagePath != "")
            {
                if (File.Exists(ImagePath))
                    pbProductImage.Load(ImagePath);
                else
                    MessageBox.Show($"Could Not Find This Image : = {ImagePath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnReadMore_Click(object sender, EventArgs e)
        {
            frmShowProductInfo frmShowProductInfo = new frmShowProductInfo(ProductID);
            frmShowProductInfo.ShowDialog();
            DataBack?.Invoke(this, _Product.ProductID);
        }

        private void tsmEdit_Click(object sender, EventArgs e)
        {
            frmAddEditProductInfo frmEditProductInfo = new frmAddEditProductInfo(_Product.ProductID);
            frmEditProductInfo.ShowDialog();

            DataBack?.Invoke(this, _Product.ProductID);
            // _RefreshProductList();
        }

        private void tsmDelete_Click(object sender, EventArgs e)
        {
            if (_Product == null)
            {
                MessageBox.Show($"No Product With ProductID ={ProductID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = MessageBox.Show($"Are you sure you want to delete the Product \nby ProductID: {_Product.ProductID}", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                if (_Product.Delete())
                {
                    DataBack?.Invoke(this, -1);
                    MessageBox.Show("Product has been deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Product was not deleted because it has data linked to it.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

           // _RefreshProductList();
   
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            frmAddProductToInvoiceInDetail frm = new frmAddProductToInvoiceInDetail(_ProductID);
            frm.DataBack += AddProductToInvoiceInDetail_DataBack;

            if (frm.ShowDialog() == DialogResult.OK)
            {
                tsmAddProduct.Enabled = false;
                btnAddProduct.Enabled = false;
            }

        }


        private void AddProductToInvoiceInDetail_DataBack(object sender, int ProductID , int Quantity, float UnitPrice, float SubTotal)
        {
            DataBackForAddProduct?.Invoke(sender, ProductID, Quantity, UnitPrice, SubTotal);

        }

        
    }
}
