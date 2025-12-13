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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIMS.Users
{
    public partial class frmAddEditUserInfo : Form
    {
        //Delegate
        public delegate void DataFoundEventHandler(object sender, int CustomerID);

        public event DataFoundEventHandler DataBack;

        public enum enMode { AddNew = 0, Update = 1 }
        public enum enGender { Male = 0, Female = 1 }

        private enMode _Mode;
        private int _UserID = -1;
        private clsUser _User;


        public frmAddEditUserInfo()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        public frmAddEditUserInfo(int UserID)
        {
            InitializeComponent();

            _UserID = UserID;
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
                lblMode.Text = "Add New User";
                this.Text = "Add New User";
                _User = new clsUser();
                tpLoginInfo.Enabled = false;

            }
            else
            {
                lblMode.Text = "Update User";
                tpLoginInfo.Enabled = true;
                btnSave.Enabled = true;
            }

            txtUserName.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            cbIsActive.Checked = true;

            if (rbMale.Checked)
                pbUserImage.Image = Resources.man;
            else
                pbUserImage.Image = Resources.woman;


            llblRemove.Visible = (pbUserImage.ImageLocation != null);

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


        private void frmAddEditUserInfo_Load(object sender, EventArgs e)
        {
            _ResatDefualtValues();

            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void _LoadData()
        {
            _User = clsUser.Find(_UserID);

            //groupBox1.Enabled = false;

            if (_User == null)
            {
                MessageBox.Show($"No User with ID= {_UserID} ", "User Not Found ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }


            lblUserID.Text   = _User.UserID.ToString();
            
            txtUserName.Text = _User.UserName;
            txtPassword.Text = _User.Password;
            txtConfirmPassword.Text = _User.Password;
            cbIsActive.Checked = _User.IsActive;

            txtFirstName.Text    = _User.FirstName;
            txtSecondName.Text   = _User.SecondName;
            txtThirdName.Text    = _User.ThirdName;
            txtLastName.Text     = _User.LastName;
            txtEmail.Text        = _User.Email;
            txtPhone.Text        = _User.Phone;
            txtAddress.Text      = _User.Address;
            dtpDateOfBirth.Value = _User.DateOfBirth;

            if (_User.Gender == (byte)enGender.Male)
            {
                rbMale.Checked = true;
            }
            else
            {
                rbFemale.Checked = true;
            }

            cbCountry.SelectedIndex = cbCountry.FindString(clsCountry.Find(_User.NationalityCountryID).CountryName);

            if (_User.ImagePath != "")
            {
                pbUserImage.ImageLocation = _User.ImagePath;
            }

            llblRemove.Visible = (_User.ImagePath != "");

            //if (clsGlobal.CurrentUser.UserID != _UserID)
            //{
            //    btnShowHidePassword.Enabled = false;
            //    txtUserName.Enabled = false;

            //}
            //else
            //{
            //    cbIsActive.Enabled = false;
            //}

            //txtPassword.Enabled = false;
            //txtConfirmPassword.Enabled = false;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tcUserInfo.Selecting -= tcUserInfo_Selecting;  // Temporarily unblock
            tcUserInfo.SelectedTab = tpUserInfo;        // or any other tab
            tcUserInfo.Selecting += tcUserInfo_Selecting;  // Reblock
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.Update)
            {
                btnSave.Enabled = true;
                tpLoginInfo.Enabled = true;

                GoToTabLoginInfo();
                return;
            }

            

            if (ValidateGroupBox(groupBox1))
            {
                btnSave.Enabled = true;
                tpLoginInfo.Enabled = true;

                GoToTabLoginInfo();

            }
            else
            {
                MessageBox.Show($"Some fileds are not valide!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private bool ValidateGroupBox(GroupBox group)
        {
            bool isValid = true;
            Control previous = this.ActiveControl;

            foreach (Control c in group.Controls)
            {
                if (c is TextBox)
                {
                    this.ActiveControl = c;   // نحرك التركيز لهذا التكست بوكس
                    if (!this.Validate())    // يشغل حدث Validating له فقط
                    {
                        isValid = false;
                    }
                }
            }

            this.ActiveControl = previous; // نرجع التركيز كمان كان

            return isValid;
        }

        private void GoToTabLoginInfo()
        {
            tcUserInfo.Selecting -= tcUserInfo_Selecting;  // Temporarily unblock
            tcUserInfo.SelectedTab = tpLoginInfo;           // or any other tab
            tcUserInfo.Selecting += tcUserInfo_Selecting;  // Reblock

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

            if (!_HandleUserImage())
                return;

            int CountryID = clsCountry.Find(cbCountry.Text).CountryID;

            _User.FirstName = txtFirstName.Text;
            _User.SecondName = txtSecondName.Text;
            _User.ThirdName = txtThirdName.Text;
            _User.LastName = txtLastName.Text;
            
            _User.Email = txtEmail.Text;
            _User.Phone = txtPhone.Text;
            _User.Address = txtAddress.Text;
            _User.DateOfBirth = dtpDateOfBirth.Value;
            _User.NationalityCountryID = CountryID;

            //_User.PersonID = ucFilterPerson1.PersonID;
            _User.UserName = txtUserName.Text;
            _User.Password = txtPassword.Text;
            _User.IsActive = cbIsActive.Checked;


            if (rbMale.Checked)
            {
                _User.Gender = 0;
            }
            else if (rbFemale.Checked)
            {
                _User.Gender = 1;
            }


            if (pbUserImage.ImageLocation != null)
            {
                _User.ImagePath = pbUserImage.ImageLocation;
            }
            else
            {
                _User.ImagePath = "";
            }

            if (_User.Save())
            {
                
                _Mode = enMode.Update;
                this.Text = "Update User";
                lblMode.Text = "Update User";
                lblUserID.Text = _User.UserID.ToString();

                MessageBox.Show("Data saved successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Trigger the event to send data back to the caller form.
                DataBack?.Invoke(this, _User.UserID);

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

                pbUserImage.Load(openFileDialog1.FileName);
                llblRemove.Visible = true;
            }
        }

        private void llblRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbUserImage.ImageLocation = null;

            pbUserImage.Image = rbMale.Checked ? Resources.man : Resources.woman;

            llblRemove.Visible = false;
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (!llblRemove.Visible)
                pbUserImage.Image = rbMale.Checked ? Resources.man : Resources.woman;
        }

        private bool _HandleUserImage()
        {

            // Copy and rename then grab the file path and send it to the database.
            if (_User.ImagePath != pbUserImage.ImageLocation)
            {
                if (_User.ImagePath != "")
                {
                    try
                    {
                        File.Delete(_User.ImagePath);
                    }
                    catch (IOException)
                    {
                        //Log 
                    }


                }

            }

            if (pbUserImage.ImageLocation != null)
            {
                string sourceImageFile = pbUserImage.ImageLocation.ToString();

                if (clsUtil.CopyImageToProjectImagesFolder(ref sourceImageFile))
                {
                    pbUserImage.ImageLocation = sourceImageFile;

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

        private void tcUserInfo_Selecting(object sender, TabControlCancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void AllTextBoxes_Validating(object sender, CancelEventArgs e)
        {
            TextBox CurrentTextBox = (TextBox)sender;


            switch (CurrentTextBox.Name.ToString())
            {
                case "txtUserName":
                    {

                        if (string.IsNullOrEmpty(CurrentTextBox.Text))
                        {
                            //CurrentTextBox.Focus();
                            e.Cancel = true;
                            errorProvider1.SetError(CurrentTextBox, "UserName should have a Value!");

                        }
                        else if (clsUser.IsUserExists(CurrentTextBox.Text) && txtUserName.Text != _User.UserName.ToString())
                        {
                            //CurrentTextBox.Focus();
                            e.Cancel = true;
                            errorProvider1.SetError(CurrentTextBox, "Username is already in use, please use another username");

                        }
                        else
                        {
                            e.Cancel = false;
                            errorProvider1.SetError(CurrentTextBox, "");

                        }



                        break;
                    }
                case "txtPassword":
                    {
                        if (string.IsNullOrEmpty(CurrentTextBox.Text))
                        {
                            //CurrentTextBox.Focus();
                            e.Cancel = true;

                            errorProvider1.SetError(CurrentTextBox, "Password should have a Value!");

                        }
                        else
                        {
                            e.Cancel = false;
                            errorProvider1.SetError(CurrentTextBox, "");

                        }



                        break;
                    }
                case "txtConfirmPassword":
                    {
                        if (string.IsNullOrEmpty(CurrentTextBox.Text))
                        {

                            CurrentTextBox.Focus();
                            e.Cancel = true;
                            errorProvider1.SetError(CurrentTextBox, "ConfirmPassword should have a Value!");

                        }
                        else if (txtConfirmPassword.Text != txtPassword.Text)
                        {
                            CurrentTextBox.Focus();
                            e.Cancel = true;
                            errorProvider1.SetError(CurrentTextBox, "password confirmation does not match password!");


                        }
                        else
                        {
                            e.Cancel = false;
                            errorProvider1.SetError(CurrentTextBox, "");

                        }



                        break;
                    }

            }

        }

        private void btnShowHidePassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*' && txtConfirmPassword.PasswordChar == '*')
            {
                btnShowHidePassword.Image = Resources.show;
                txtPassword.PasswordChar = '\0';
                txtConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
                txtConfirmPassword.PasswordChar = '*';
                btnShowHidePassword.Image = Resources.close_eye;

            }
        }
   
    
    }
}
