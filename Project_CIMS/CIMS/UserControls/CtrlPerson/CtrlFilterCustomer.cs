using CIMS.Customers;
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

namespace CIMS.UserControls.CtrlPerson
{
    public partial class CtrlFilterCustomer : UserControl
    {

        public event Action<int> OnCustomerSelected;

        protected virtual void CustomerSelected(int CustomerID)
        {
            Action<int> handler = OnCustomerSelected;
            if (handler != null)
            {
                handler(CustomerID);
            }

        }


        private bool _ShowAddCustomer = true;

        public bool ShowAddCustomer
        {

            get { return _ShowAddCustomer; }

            set
            {
                _ShowAddCustomer = value;
                btnAddNewCustomer.Visible = _ShowAddCustomer;
            }
        }

        private bool _FilterEnabled = true;

        public bool FilterEnabled
        {

            get { return _FilterEnabled; }

            set
            {
                _FilterEnabled = value;
                gbFind.Enabled = _FilterEnabled;
            }
        }

        public int CustomerID
        {
            get { return ctrlPersonInfo1.CustomerID; }

        }


        public clsCustomer SelectedCustomerInfo
        {
            get { return ctrlPersonInfo1.SelectedCustomerInfo; }

        }


        public CtrlFilterCustomer()
        {
            InitializeComponent();
        }

        public void FilterFocus()
        {
            txtFindBy.Focus();
        }

        public void LoadCustomerInfo(int CustomerID)
        {

            cbFindBy.SelectedIndex = 0;
            txtFindBy.Text = CustomerID.ToString();

            FindNow();
        }

        private void FindNow()
        {

            if (cbFindBy.SelectedIndex == 0 && int.TryParse(txtFindBy.Text, out int ID))
                ctrlPersonInfo1.LoadCustomerInfo(ID);
            //else if (cbFindBy.SelectedIndex == 0)
            //    ctrlPersonInfo1.LoadCustomerInfo(txtFindBy.Text);


            if (OnCustomerSelected != null && FilterEnabled)
                OnCustomerSelected(ctrlPersonInfo1.CustomerID);

        }

        private void CtrlFilterCustomer_Load(object sender, EventArgs e)
        {
            cbFindBy.SelectedIndex = 0;
            txtFindBy.Focus();
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FindNow();
        }

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            frmAddEditCustomerInfo frmAddCustomer = new frmAddEditCustomerInfo();
            frmAddCustomer.DataBack += frmAddCustomer_DataBack;
            frmAddCustomer.ShowDialog();
        }

        private void frmAddCustomer_DataBack(object sender, int CustomerID)
        {
            cbFindBy.SelectedIndex = 0;
            txtFindBy.Text = CustomerID.ToString();

            ctrlPersonInfo1.LoadCustomerInfo(CustomerID);
        }

        private void txtFindBy_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFindBy.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFindBy, "This field is required!");
            }
            else
            {
                errorProvider1.SetError(txtFindBy, null);

            }
        }

        private void txtFindBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnSearchCustomer.PerformClick();
            }

            if (cbFindBy.SelectedIndex == 0)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }
    }
}
