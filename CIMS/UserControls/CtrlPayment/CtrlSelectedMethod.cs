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

namespace CIMS.UserControls.CtrlPayment
{
    public partial class CtrlSelectedMethod : UserControl
    {
        //private string _SelectedMethod;

        private clsPayment.enPaymentMethod _PaymentMethod;

        public clsPayment.enPaymentMethod SelectedPaymentMethod
        { get { return _PaymentMethod; } }

        public CtrlSelectedMethod()
        {
            InitializeComponent();
        }

        private void StylePaymentPanel(Panel panel, Label label, PictureBox icon, bool selected)
        {
            if (selected)
            {
                panel.BorderStyle = BorderStyle.FixedSingle;
                panel.Padding = new Padding(3);
                label.ForeColor = Color.Blue;
                icon.Visible = true;
                panel.BackColor = Color.FromArgb(230, 245, 255); // لون أزرق فاتح


            }
            else
            {
                label.ForeColor = Color.Black;
                panel.BorderStyle = BorderStyle.FixedSingle;
                icon.Visible = false;
                panel.BackColor = Color.FromArgb(245, 245, 245); // رمادي فاتح
            }
        }

        private void SelectPayment(clsPayment.enPaymentMethod Method)
        {
            _PaymentMethod = Method;

            StylePaymentPanel(panelCreditCards, lblCreditCards, picCreditCards, Method == clsPayment.enPaymentMethod.CreditCard);
            StylePaymentPanel(panelCash, lblCash, picCash, Method == clsPayment.enPaymentMethod.Cash);
            StylePaymentPanel(panelDebitCards, lblDebitCards, picDebitCards, Method == clsPayment.enPaymentMethod.DebitCard);
            StylePaymentPanel(panelChecks, lblChecks, picChecks, Method == clsPayment.enPaymentMethod.Check);
            StylePaymentPanel(panelElectronicFundsTransfer, lblElectronicFundsTransfer, picElectronicFundsTransfer, Method == clsPayment.enPaymentMethod.ElectronicFundsTransfer);
            StylePaymentPanel(panelDigitalWallets, lblDigitalWallets, picDigitalWallets, Method == clsPayment.enPaymentMethod.DigitalWallet);
        }

        private void panel_Click(object sender, EventArgs e)
        {
            Panel panel = (Panel)sender;
            clsPayment.enPaymentMethod PM = (clsPayment.enPaymentMethod)Convert.ToByte((string)panel.Tag);

            SelectPayment(PM);

        }

        private void CtrlSelectedMethod_Load(object sender, EventArgs e)
        {
            SelectPayment(clsPayment.enPaymentMethod.Cash);
        }


    }
}
