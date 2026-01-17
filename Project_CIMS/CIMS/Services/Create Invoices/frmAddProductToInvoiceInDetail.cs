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
    public partial class frmAddProductToInvoiceInDetail : Form
    {
        //Delegate
        public delegate void DataFoundEventHandler(object sender, int ProductID , int Quantity , float UnitPrice , float SubTotal);

        public event DataFoundEventHandler DataBack;

        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;

        private int _ProductID = -1;

        private int _Quantity = 1;

        public frmAddProductToInvoiceInDetail(int ProductID)
        {
            InitializeComponent();
            _ProductID = ProductID;

            _Mode = enMode.AddNew;
        }

        public frmAddProductToInvoiceInDetail(int ProductID , int Quantity)
        {
            InitializeComponent();
            _ProductID = ProductID;
            _Quantity  = Quantity;

            _Mode = enMode.Update;
        }

        private void frmAddProductToInvoiceInDetail_Load(object sender, EventArgs e)
        {
            ctrlProductInfo1.LoadProductInfo(_ProductID);

            lblUnitPrice.Text     = ctrlProductInfo1.SelectedProductInfo.Price.ToString().Trim();
            lblSubTotal.Text      = ctrlProductInfo1.SelectedProductInfo.Price.ToString().Trim();

            if (_Mode == enMode.Update)
            {
                txtQuantity.Text = _Quantity.ToString().Trim();
                btnAddProduct.Text = "Update";
            }
            
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantity.Text != "")
            {
                lblSubTotal.Text = (Convert.ToSingle(lblUnitPrice.Text) * Convert.ToSingle(txtQuantity.Text)).ToString();

                lblMass.Visible = false;

                if (int.Parse(txtQuantity.Text) > ctrlProductInfo1.SelectedProductInfo.QuantityInStock)
                {
                    txtQuantity.Text = ctrlProductInfo1.SelectedProductInfo.QuantityInStock.ToString();
                    lblMass.Visible = true;
                }

                if (int.Parse(txtQuantity.Text) == 0)
                {
                    txtQuantity.Text = "1";
                    lblMass.Visible = true;
                }

            }
            else
            {

                lblMass.Visible = false;
                lblSubTotal.Text = (Convert.ToSingle(lblUnitPrice.Text) * 1).ToString();
            }

        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int Quantity = int.Parse(txtQuantity.Text);
            clsProduct Product = clsProduct.Find(_ProductID);

            DataBack?.Invoke(sender, _ProductID, Quantity, Convert.ToSingle(lblUnitPrice.Text) , Convert.ToSingle(lblSubTotal.Text));

            //if (_Mode == enMode.Update)
            //{
            //    //_Quantity is Old | Quantity is new 

            //    if (_Quantity > Quantity)
            //    {
            //        Product.IncreaseStock(_Quantity - Quantity);
            //    }

            //    if (_Quantity < Quantity)
            //    {
            //        Product.DecreaseStock(Quantity - _Quantity);
            //    }


            //}
            //else //  Add New Mode
            //{
            //    Product.DecreaseStock(Quantity);
            //}

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtQuantity_Validating(object sender, CancelEventArgs e)
        {
            
            if (string.IsNullOrEmpty(txtQuantity.Text.Trim()))
            {
                e.Cancel = true;

                errorProvider1.SetError(txtQuantity, "this field is required!");

            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(txtQuantity, null);

            }

        }
    }
}
