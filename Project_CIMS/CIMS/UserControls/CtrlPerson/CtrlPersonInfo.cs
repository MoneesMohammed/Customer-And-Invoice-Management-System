using CIMS.Customers;
using CIMS.Properties;
using CIMS.Users;
using CIMS_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIMS.UserControls.CtrlCustomer
{
    public partial class CtrlPersonInfo : UserControl
    {
        public enum enGender { Male = 0, Female = 1 }

        private clsCustomer _Customer = new clsCustomer();
        private int _CustomerID = -1;

        private clsUser _User = new clsUser();
        private int _UserID = -1;

        public int UserID { get { return _UserID; } }
        public clsUser SelectedUserInfo { get { return _User; } }
        public int CustomerID { get { return _CustomerID; } }
        public clsCustomer SelectedCustomerInfo { get { return _Customer; } }
       
        public CtrlPersonInfo()
        {
            InitializeComponent();
        }

        public void LoadCustomerInfo(int CustomerID)
        {
            _Customer = clsCustomer.Find(CustomerID);

            if (_Customer == null)
            {
                ResetCustomerInfo();
                MessageBox.Show($"No Customer With CustomerID ={CustomerID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillCustomerInfo();

            

        }
        private void _FillCustomerInfo()
        {
            _CustomerID = _Customer.CustomerID;

            llblEditCustomerInfo.Enabled = true;

            lblCustomerID.Text = _Customer.CustomerID.ToString();

            lblName.Text = _Customer.FullName;


            if (_Customer.Gender == (byte)enGender.Male)
            {
                lblGendor.Text = "Male";
                lblGendor.Image = Resources.Male;
            }
            else
            {
                lblGendor.Text = "Female";
                lblGendor.Image = Resources.Female;
            }

            lblEmail.Text = (_Customer.Email == "") ? "N/A" : _Customer.Email;
            lblPhone.Text = _Customer.Phone;
            lblDateOfBirth.Text = _Customer.DateOfBirth.ToString("MM/dd/yyyy");
            lblAddress.Text = _Customer.Address;

            lblcountry.Text = clsCountry.Find(_Customer.NationalityCountryID).CountryName;

            _LoadCustomerImage();

        }

        private void ResetCustomerInfo()
        {
            _CustomerID = -1;
            llblEditCustomerInfo.Enabled = false;

            lblCustomerID.Text = "[???]";
            lblName.Text = "[???]";


            lblGendor.Text = "Male";
            lblGendor.Image = Resources.Male;

            lblEmail.Text = "[???]";
            lblPhone.Text = "[???]";
            lblDateOfBirth.Text = "[???]";
            lblAddress.Text = "[???]";

            lblcountry.Text = "[???]";

            pbCustomerImage.Image = Resources.man;

        }

        private void _LoadCustomerImage()
        {
            pbCustomerImage.Image = _Customer.Gender == 0 ? Resources.man : Resources.woman;

            string ImagePath = _Customer.ImagePath;

            if (ImagePath != "")
            {
                if (File.Exists(ImagePath))
                    pbCustomerImage.Load(ImagePath);
                else
                    MessageBox.Show($"Could Not Find This Image : = {ImagePath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        public void LoadUserInfo(int UserID)
        {
            _User = clsUser.Find(UserID);

            if (_User == null)
            {
                ResetUserInfo();
                MessageBox.Show($"No User With UserID ={UserID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillUserInfo();

        }

        private void _FillUserInfo()
        {
            _UserID = _User.UserID;

            llblEditCustomerInfo.Enabled = true;

            label1.Text = "User ID:";
            gbCustomerInformation.Text = "User Information";
            llblEditCustomerInfo.Text = "Edit User Info";

            lblCustomerID.Text = _User.UserID.ToString();


            lblName.Text = _User.FullName;


            if (_User.Gender == (byte)enGender.Male)
            {
                lblGendor.Text = "Male";
                lblGendor.Image = Resources.Male;
            }
            else
            {
                lblGendor.Text = "Female";
                lblGendor.Image = Resources.Female;
            }

            lblEmail.Text = (_User.Email == "") ? "N/A" : _User.Email;
            lblPhone.Text = _User.Phone;
            lblDateOfBirth.Text = _User.DateOfBirth.ToString("MM/dd/yyyy");
            lblAddress.Text = _User.Address;

            lblcountry.Text = clsCountry.Find(_User.NationalityCountryID).CountryName;

            _LoadUserImage();

        }

        private void ResetUserInfo()
        {
            _UserID = -1;
            llblEditCustomerInfo.Enabled = false;

            label1.Text = "User ID:";
            gbCustomerInformation.Text = "User Information";
            llblEditCustomerInfo.Text = "Edit User Info";

            lblCustomerID.Text = "[???]";
            lblName.Text = "[???]";

            lblGendor.Text = "Male";
            lblGendor.Image = Resources.Male;

            lblEmail.Text = "[???]";
            lblPhone.Text = "[???]";
            lblDateOfBirth.Text = "[???]";
            lblAddress.Text = "[???]";

            lblcountry.Text = "[???]";

            pbCustomerImage.Image = Resources.man;
        }

        private void _LoadUserImage()
        {
            pbCustomerImage.Image = _User.Gender == 0 ? Resources.man : Resources.woman;

            string ImagePath = _User.ImagePath;

            if (ImagePath != "")
            {
                if (File.Exists(ImagePath))
                    pbCustomerImage.Load(ImagePath);
                else
                    MessageBox.Show($"Could Not Find This Image : = {ImagePath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


       
        private void llblEditCustomerInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_CustomerID != -1)
            {
                frmAddEditCustomerInfo frm = new frmAddEditCustomerInfo(_CustomerID);
                frm.ShowDialog();

                LoadCustomerInfo(_CustomerID);
            }
            else
            {
               
                frmAddEditUserInfo frm = new frmAddEditUserInfo(_UserID);
                frm.ShowDialog();

                LoadUserInfo(_UserID);

            }
        }
    }
}
