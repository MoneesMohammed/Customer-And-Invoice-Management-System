using CIMS.Properties;
using CIMS_BusinessLayer;
using CIMS.Global_Classes;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.ComponentModel;

namespace CIMS.Customers
{
    public partial class frmAddEditCustomerInfo : Form
    {
        //Delegate
        public delegate void DataFoundEventHandler(object sender, int CustomerID);

        public event DataFoundEventHandler DataBack;

        public enum enMode { AddNew = 0, Update = 1 }
        public enum enGender { Male = 0, Female = 1 }

        private enMode _Mode;
        private int _CustomerID = -1;
        clsCustomer _Customer;


        public frmAddEditCustomerInfo()
        {
            InitializeComponent();

            _Mode = enMode.AddNew;
        }

        public frmAddEditCustomerInfo(int CustomerID)
        {
            InitializeComponent();

            _CustomerID = CustomerID;
            _Mode = enMode.Update;

        }

        private void _FillCountryInComboBox()
        {
            DataTable dtCountries = clsCountry.GetAllCountries();

            foreach (DataRow row in dtCountries.Rows)
            {
                cbCountry.Items.Add(row["CountryName"]);

            }

        }


        private void _ResatDefualtValues()
        {

            _FillCountryInComboBox();

            if (_Mode == enMode.AddNew)
            {
                lblMode.Text = "Add New Customer";
                _Customer = new clsCustomer();
            }
            else
            {
                lblMode.Text = "Update Customer";
            }

            if (rbMale.Checked)
                pbCustomerImage.Image = Resources.man;
            else
                pbCustomerImage.Image = Resources.woman;


            llblRemove.Visible = (pbCustomerImage.ImageLocation != null);

            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            dtpDateOfBirth.Value = dtpDateOfBirth.MaxDate;

            dtpDateOfBirth.MinDate = DateTime.Now.AddYears(-100);

            cbCountry.SelectedIndex = cbCountry.FindString("Jordan");


            txtFirstName.Text = "";
            txtSecondName.Text = "";
            txtThirdName.Text = "";
            txtLastName.Text = "";
            rbMale.Checked = true;
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";


        }

        private void frmAddEditCustomerInfo_Load(object sender, EventArgs e)
        {
            _ResatDefualtValues();

            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void _LoadData()
        {

            _Customer = clsCustomer.Find(_CustomerID);

            if (_Customer == null)
            {
                MessageBox.Show($"No Customer with ID= {_CustomerID} ", "Customer Not Found ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }


            lblCustomerID.Text = _Customer.CustomerID.ToString();

           
            txtFirstName.Text    = _Customer.FirstName;
            txtSecondName.Text   = _Customer.SecondName;
            txtThirdName.Text    = _Customer.ThirdName;
            txtLastName.Text     = _Customer.LastName;
            txtEmail.Text        = _Customer.Email;
            txtPhone.Text        = _Customer.Phone;
            txtAddress.Text      = _Customer.Address;
            dtpDateOfBirth.Value = _Customer.DateOfBirth;

            if (_Customer.Gender == (byte)enGender.Male)
            {
                rbMale.Checked = true;
            }
            else
            {
                rbFemale.Checked = true;
            }

            cbCountry.SelectedIndex = cbCountry.FindString(clsCountry.Find(_Customer.NationalityCountryID).CountryName);


            if (_Customer.ImagePath != "")
            {
                pbCustomerImage.ImageLocation = _Customer.ImagePath;
            }

            llblRemove.Visible = (_Customer.ImagePath != "");

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

            if (!_HandleCustomerImage())
                return;

            int CountryID = clsCountry.Find(cbCountry.Text).CountryID;

            _Customer.FirstName = txtFirstName.Text;
            _Customer.SecondName = txtSecondName.Text;
            _Customer.ThirdName = txtThirdName.Text;
            _Customer.LastName = txtLastName.Text;
             
            _Customer.Email = txtEmail.Text;
            _Customer.Phone = txtPhone.Text;
            _Customer.Address = txtAddress.Text;
            _Customer.DateOfBirth = dtpDateOfBirth.Value;
            _Customer.NationalityCountryID = CountryID;



            if (rbMale.Checked)
            {
                _Customer.Gender = 0;
            }
            else if (rbFemale.Checked)
            {
                _Customer.Gender = 1;
            }


            if (pbCustomerImage.ImageLocation != null)
            {
                _Customer.ImagePath = pbCustomerImage.ImageLocation;
            }
            else
            {
                _Customer.ImagePath = "";
            }

            if (_Customer.Save())
            {
                lblCustomerID.Text = _Customer.CustomerID.ToString();
                _Mode = enMode.Update;
                lblMode.Text = "Update Customer";


                MessageBox.Show("Data saved successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Trigger the event to send data back to the caller form.
                DataBack?.Invoke(this, _Customer.CustomerID);

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

                pbCustomerImage.Load(openFileDialog1.FileName);
                llblRemove.Visible = true;
            }
        }

        private void llblRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbCustomerImage.ImageLocation = null;

            pbCustomerImage.Image = rbMale.Checked ? Resources.man : Resources.woman;

            llblRemove.Visible = false;
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (!llblRemove.Visible)
                pbCustomerImage.Image = rbMale.Checked ? Resources.man : Resources.woman;
        }


        private bool _HandleCustomerImage()
        {

            // Copy and rename then grab the file path and send it to the database.
            if (_Customer.ImagePath != pbCustomerImage.ImageLocation)
            {
                if (_Customer.ImagePath != "")
                {
                    try
                    {
                        File.Delete(_Customer.ImagePath);
                    }
                    catch (IOException)
                    {
                        //Log 
                    }


                }

            }

            if (pbCustomerImage.ImageLocation != null)
            {
                string sourceImageFile = pbCustomerImage.ImageLocation.ToString();

                if (clsUtil.CopyImageToProjectImagesFolder(ref sourceImageFile))
                {
                    pbCustomerImage.ImageLocation = sourceImageFile;

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

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text.Trim()))
                return;

            //Validate Email Format
            if (!clsValidatoin.ValidateEmail(txtEmail.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmail, "Invalid Email Address Format!");
            }
            else
            {
                errorProvider1.SetError(txtEmail, null);
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
