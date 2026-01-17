using CIMS.Global_Classes;
using CIMS.UserControls.CtrlPerson;
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

namespace CIMS.Services.Payments
{
    public partial class frmAddEditPaymentInfo : Form
    {
        //Delegate
        public delegate void DataFoundEventHandler(object sender, int CustomerID);

        public event DataFoundEventHandler DataBack;

        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;

        private int _SelectedInvoiceID = -1;

        private int _PaymentID = -1;
        private clsPayment _Payment;

        public frmAddEditPaymentInfo()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        public frmAddEditPaymentInfo(int InvoiceID)
        {
            InitializeComponent();
            _SelectedInvoiceID = InvoiceID;
            _Mode = enMode.Update;
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (tabControl1.SelectedTab != tabInvoiceInfo)
                e.Cancel = true;
        }

        private void _GoToTabPaymentInfo()
        {
            tabControl1.Selecting -= tabControl1_Selecting;  // Temporarily unblock
            tabControl1.SelectedTab = tabPaymentInfo;           // or any other tab
            tabControl1.Selecting += tabControl1_Selecting;  // Reblock

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.AddNew)
            {
                if (ctrlFilterInvoice1.InvoiceID == -1)
                {
                    MessageBox.Show($"There is no Invoice.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
            }

            

            _GoToTabPaymentInfo();

            float TotalAmount = ctrlFilterInvoice1.SelectedInvoiceInfo.TotalAmount;

            lblTotalAmount.Text = TotalAmount.ToString();

            if (ctrlFilterInvoice1.SelectedInvoiceInfo.InvoiceStatus == clsInvoice.enInvoiceStatus.Pending)
            {
                lblRemainingAmountT.Visible = true;
                lblRemainingAmount.Visible = true;

                float TotalPaid = clsPayment.GetTotalPaidByInvoiceID(ctrlFilterInvoice1.SelectedInvoiceInfo.InvoiceID);

                lblRemainingAmount.Text = (TotalAmount - TotalPaid).ToString();

            }
            else
            {
                lblRemainingAmountT.Visible = false;
                lblRemainingAmount.Visible = false;
                lblRemainingAmount.Text = "000";

            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //textBox1.Text = ctrlSelectedMethod1.SelectedPaymentMethod.ToString();
            this.Close();
        }

        private void frmAddEditPaymentInfo_Load(object sender, EventArgs e)
        {
            _ResetDefualtValue();

            if (_Mode == enMode.Update)
                _LoadData();
        }


        private void _ResetDefualtValue()
        {
            if (_Mode == enMode.AddNew)
            {
                lblMode.Text = "Add New Payment";
                this.Text = "Add New Payment";
                _Payment = new clsPayment();

                lblPaymentDate.Text = DateTime.Now.ToString("MM/dd/yyyy");

            }
            else
            {
                lblMode.Text = "Pay Invoice";
                this.Text = "Pay Invoice";

                _Payment = new clsPayment();
                //tabControl1.Enabled = true;
                //btnSave.Enabled = true;

            }

        }

        private void _LoadData()
        {
            ctrlFilterInvoice1.FilterEnabled = false;
            clsInvoice Invoice = clsInvoice.Find(_SelectedInvoiceID);

            if (Invoice == null)
            {
                MessageBox.Show($"No Invoice With ID = {_SelectedInvoiceID}", "No Invoice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            ctrlFilterInvoice1.LoadInvoiceInfo(_SelectedInvoiceID);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }


            _Payment.InvoiceID = _SelectedInvoiceID;
            _Payment.PaymentMethod = ctrlSelectedMethod1.SelectedPaymentMethod;
            _Payment.PaymentDate = DateTime.Now;
            _Payment.AmountPaid = Convert.ToSingle(txtAmountPaid.Text);


            if (_Payment.Save())
            {
                lblPaymentID.Text = _Payment.PaymentID.ToString();
                _Mode = enMode.Update;
                
                ctrlFilterInvoice1.FilterEnabled = false;
                btnSave.Enabled = false;

                MessageBox.Show("Data saved successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Trigger the event to send data back to the caller form.
                DataBack?.Invoke(this, _Payment.PaymentID);


                clsInvoice Invoice = ctrlFilterInvoice1.SelectedInvoiceInfo;

                
                if((Invoice.TotalAmount - _Payment.GetTotalPaid() ) <= 0)
                {

                    Invoice.SetStatus(clsInvoice.enInvoiceStatus.Paid);
                }
                else
                {
                    Invoice.SetStatus(clsInvoice.enInvoiceStatus.Pending);
                    
                }


            }
            else
            {

                MessageBox.Show("Error : data is not saved successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }




            this.Close();


        }

        private void ctrlFilterInvoice1_OnInvoiceSelected(int obj)
        {
            _SelectedInvoiceID = obj;
        }

        private void txtAmountPaid_TextChanged(object sender, EventArgs e)
        {
            float TotalAmount = ctrlFilterInvoice1.SelectedInvoiceInfo.TotalAmount;
            float AmountPaid = 0;

            if (txtAmountPaid.Text != "")
            {
                AmountPaid = Convert.ToSingle(txtAmountPaid.Text);

                if (ctrlFilterInvoice1.SelectedInvoiceInfo.InvoiceStatus == clsInvoice.enInvoiceStatus.Pending)
                {
                    float RemainingAmount = Convert.ToSingle(lblRemainingAmount.Text);

                    if (RemainingAmount < AmountPaid)
                    {
                        txtAmountPaid.Text = RemainingAmount.ToString();
                        lblMessage.Text = "The Amount Paid you entered is invalid because it is greater than the Remaining Amount.";
                        lblMessage.Visible = true;
                    }
                    else
                    {
                        lblMessage.Visible = false;
                    }
                }
                else
                {
                    if (TotalAmount < AmountPaid)
                    {
                        txtAmountPaid.Text = TotalAmount.ToString();
                        lblMessage.Text = "The Amount Paid you entered is invalid because it is greater than the Total Amount.";
                        lblMessage.Visible = true;
                    }
                    else
                    {
                        lblMessage.Visible = false;
                    }

                }

            }
            else
            {

                lblMessage.Visible = false;

            }
        }


        private void txtAmountPaid_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtAmountPaid.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtAmountPaid, "This field is required!");
            }
            else
            {
                errorProvider1.SetError(txtAmountPaid, null);

            }
        }



        private void txtAmountPaid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnPaidInFull_Click(object sender, EventArgs e)
        {
            float TotalAmount = ctrlFilterInvoice1.SelectedInvoiceInfo.TotalAmount;
            float TotalPaid = clsPayment.GetTotalPaidByInvoiceID(ctrlFilterInvoice1.SelectedInvoiceInfo.InvoiceID);

            if (ctrlFilterInvoice1.SelectedInvoiceInfo.InvoiceStatus == clsInvoice.enInvoiceStatus.Pending)
            {
                txtAmountPaid.Text = (TotalAmount - TotalPaid).ToString();
            }
            else
            {
                txtAmountPaid.Text = TotalAmount.ToString();
            }

                

        }
    }
}
