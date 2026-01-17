using CIMS.UserControls.CtrlCustomer;
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

namespace CIMS.UserControls.CtrlInvoices
{
    public partial class CtrlFilterInvoice : UserControl
    {
        public event Action<int> OnInvoiceSelected;

        protected virtual void InvoiceSelected(int InvoiceID)
        {
            Action<int> handler = OnInvoiceSelected;
            if (handler != null)
            {
                handler(InvoiceID);
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

        public int InvoiceID
        {
            get { return ctrlInvoiceInfo1.InvoiceID; }

        }

        public clsInvoice SelectedInvoiceInfo
        {
            get { return ctrlInvoiceInfo1.SelectedInvoiceInfo; }

        }



        public CtrlFilterInvoice()
        {
            InitializeComponent();
        }


        public void FilterFocus()
        {
            txtFindBy.Focus();
        }

        public void LoadInvoiceInfo(int InvoiceID)
        {

            cbFindBy.SelectedIndex = 0;
            txtFindBy.Text = InvoiceID.ToString();

            FindNow();
        }

        private void FindNow()
        {

            if (cbFindBy.SelectedIndex == 0 && int.TryParse(txtFindBy.Text, out int ID))
            {
                clsInvoice Invoice = clsInvoice.Find(ID);

                if (Invoice != null)
                {
                    if (Invoice.IsCancelled())
                    {
                        MessageBox.Show("The invoice you selected has been cancelled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ctrlInvoiceInfo1.ResetInvoiceInfo();
                        return;
                    }

                    if (Invoice.IsPaid())
                    {
                        MessageBox.Show("The invoice you selected has been Paid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ctrlInvoiceInfo1.ResetInvoiceInfo();
                        return;
                    }

                }

                ctrlInvoiceInfo1.LoadInvoiceInfo(ID);
            }
                
            //else if (cbFindBy.SelectedIndex == 0)
            //    ctrlPersonInfo1.LoadCustomerInfo(txtFindBy.Text);


            if (OnInvoiceSelected != null && FilterEnabled)
                OnInvoiceSelected(ctrlInvoiceInfo1.InvoiceID);

        }

        private void ctrlInvoiceInfo1_Load(object sender, EventArgs e)
        {
            cbFindBy.SelectedIndex = 0;
            txtFindBy.Focus();
        }

        private void btnSearchInvoice_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FindNow();
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
                btnSearchInvoice.PerformClick();
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
