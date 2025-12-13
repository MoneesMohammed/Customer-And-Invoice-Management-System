using CIMS.Global_Classes;
using CIMS.Properties;
using CIMS_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CIMS.Services.Products
{
    public partial class frmAddEditProductInfo : Form
    {
        //Delegate
        public delegate void DataFoundEventHandler(object sender, int ProductID);

        public event DataFoundEventHandler DataBack;

        public enum enMode { AddNew = 0, Update = 1 }
       
        private enMode _Mode;
        private int _ProductID = -1;
        private clsProduct _Product;

        public frmAddEditProductInfo()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        public frmAddEditProductInfo(int ProductID)
        {
            InitializeComponent();
            _ProductID = ProductID;
            _Mode = enMode.Update;
        }


        private void _ResatDefualtValues()
        {
            if (_Mode == enMode.AddNew)
            {
                lblMode.Text = "Add New Product";
                _Product = new clsProduct();
            }
            else
            {
                lblMode.Text = "Update Product";
            }

            pbProductImage.Image = Resources.product_default;
            
            llblRemove.Visible = (pbProductImage.ImageLocation != null);

            txtName.Text            = "";
            txtPrice.Text           = "";
            txtQuantityInStock.Text = "";
            txtDescription.Text     = "";
          
        }

        private void frmAddEditProductInfo_Load(object sender, EventArgs e)
        {
            _ResatDefualtValues();

            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void _LoadData()
        {

            _Product = clsProduct.Find(_ProductID);

            if (_Product == null)
            {
                MessageBox.Show($"No Product with ID= {_ProductID} ", "Product Not Found ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }


            lblProductID.Text = _Product.ProductID.ToString();

            txtName.Text = _Product.Name.ToString();
            txtPrice.Text = _Product.Price.ToString();
            txtQuantityInStock.Text = _Product.QuantityInStock.ToString("0");
            txtDescription.Text = _Product.Description.ToString();


            if (_Product.ImagePath != "")
            {
                pbProductImage.ImageLocation = _Product.ImagePath;
            }

            llblRemove.Visible = (_Product.ImagePath != "");

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            if (!_HandleProductImage())
                return;

            _Product.Name = txtName.Text;
            _Product.Price = Convert.ToSingle(txtPrice.Text);
            _Product.QuantityInStock = int.Parse(txtQuantityInStock.Text);
            _Product.Description = txtDescription.Text;


            if (pbProductImage.ImageLocation != null)
            {
                _Product.ImagePath = pbProductImage.ImageLocation;
            }
            else
            {
                _Product.ImagePath = "";
            }

            if (_Product.Save())
            {
                lblProductID.Text = _Product.ProductID.ToString();
                _Mode = enMode.Update;
                lblMode.Text = "Update Product";


                MessageBox.Show("Data saved successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Trigger the event to send data back to the caller form.
                DataBack?.Invoke(this, _Product.ProductID);

            }
            else
            {

                MessageBox.Show("Error : data is not saved successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void llblSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.DefaultExt = "JPG";

            openFileDialog1.Filter = "JPG Files (*.jpg;*.jpeg)|*.jpg;*.jpeg|PNG Files (*.png)|*.png|All Files (*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                pbProductImage.Load(openFileDialog1.FileName);
                llblRemove.Visible = true;
            }
        }

        private void llblRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbProductImage.ImageLocation = null;

            pbProductImage.Image = Resources.product_default;

            llblRemove.Visible = false;
        }

        private bool _HandleProductImage()
        {

            // Copy and rename then grab the file path and send it to the database.
            if (_Product.ImagePath != pbProductImage.ImageLocation)
            {
                if (_Product.ImagePath != "")
                {
                    try
                    {
                        File.Delete(_Product.ImagePath);
                    }
                    catch (IOException)
                    {
                        //Log 
                    }


                }

            }

            if (pbProductImage.ImageLocation != null)
            {
                string sourceImageFile = pbProductImage.ImageLocation.ToString();

                if (clsUtil.CopyImageToProjectImagesFolder(ref sourceImageFile))
                {
                    pbProductImage.ImageLocation = sourceImageFile;

                    return true;
                }
                else
                {

                    MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;

                }

            }

            return true;
        }

        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {
            TextBox Tepm = ((TextBox)sender);

            if (string.IsNullOrEmpty(Tepm.Text.Trim()))
            {
                e.Cancel = true;

                errorProvider1.SetError(Tepm, "this field is required!");

            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(Tepm, null);

            }
        }

        private void WritingOnlyNumbersTextBox(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
