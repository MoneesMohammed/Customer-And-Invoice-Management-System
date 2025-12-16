using CIMS.Properties;
using CIMS_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using CIMS.Services.Products;

namespace CIMS.UserControls.CtrlProduct
{
    public partial class CtrlProductInfo : UserControl
    {
        private clsProduct _Product;
        private int _ProductID = -1;

        public int ProductID { get { return _ProductID; } }
        public clsProduct SelectedProductInfo { get { return _Product; } }

        public CtrlProductInfo()
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

            lblProductID.Text = _Product.ProductID.ToString();
            lblName.Text = _Product.Name.Trim();
            lblPrice.Text = $"$ {_Product.Price}";
            lblDescription.Text = _Product.Description.Trim();
            lblQuantityInStock.Text = $"{_Product.QuantityInStock}";

            llblEditProductInfo.Enabled = true;

            _LoadProductImage();

        }

        private void ResetProductInfo()
        {
            _ProductID = -1;

            lblProductID.Text = "N/A";
            lblName.Text = "[???????]";
            lblPrice.Text = $"$ 0"; ;
            lblDescription.Text = "[???????]";
            lblQuantityInStock.Text = "0";

            llblEditProductInfo.Enabled = false;

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

        private void llblEditProductInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddEditProductInfo EditProductInfo = new frmAddEditProductInfo(_ProductID);
            EditProductInfo.ShowDialog();

            LoadProductInfo(_ProductID);
        }
    }
}
