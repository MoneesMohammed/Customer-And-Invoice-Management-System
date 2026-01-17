using CIMS_DataAccessLayar;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIMS_BusinessLayer
{
    public class clsPayment
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode Mode = enMode.AddNew;
        
        public enum enPaymentMethod { Cash = 0, CreditCard = 1, DebitCard = 2, Check = 3, ElectronicFundsTransfer = 4, DigitalWallet = 5 };

        
        public int PaymentID { get; set; }
        public int InvoiceID { get; set; }
        public clsInvoice InvoiceInfo;
        public enPaymentMethod PaymentMethod { get; set; }
        public DateTime PaymentDate { get; set; }
        public float AmountPaid { get; set; }
        

        public string MethodText
        {
            get
            {
                switch (PaymentMethod)
                { 
                    case enPaymentMethod.Cash:
                        return "Cash";
                    case enPaymentMethod.CreditCard:
                        return "Credit Card";
                    case enPaymentMethod.DebitCard:
                        return "Debit Card";
                    case enPaymentMethod.Check:
                        return "Check";
                    case enPaymentMethod.ElectronicFundsTransfer:
                        return "Electronic Funds Transfer";
                    case enPaymentMethod.DigitalWallet:
                        return "Digital Wallet";
                    default:
                        return "Unknown";

                }

            }

        }

        public clsPayment()
        {
            PaymentID     = -1;
            InvoiceID     = -1;
            PaymentMethod = enPaymentMethod.Cash;
            PaymentDate   = DateTime.Now;
            AmountPaid    = 0;

            Mode = enMode.AddNew;
        }

        private clsPayment(int PaymentID, int InvoiceID, enPaymentMethod PaymentMethod, DateTime PaymentDate, float AmountPaid)
        {

            this.PaymentID = PaymentID;
            this.InvoiceID = InvoiceID;
            this.PaymentMethod = PaymentMethod;
            this.PaymentDate = PaymentDate;
            this.AmountPaid = AmountPaid;

            InvoiceInfo = clsInvoice.Find(InvoiceID);

            Mode = enMode.Update;
        }

        public static clsPayment Find(int PaymentID)
        {
            int InvoiceID = -1;
            DateTime PaymentDate = DateTime.Now;
            byte PaymentMethod = 0;
            float AmountPaid = 0;

            if (clsPaymentsData.GetPaymentInfoByID(PaymentID, ref InvoiceID, ref PaymentMethod, ref PaymentDate, ref AmountPaid))
            {
                return new clsPayment(PaymentID, InvoiceID, (enPaymentMethod)PaymentMethod, PaymentDate, AmountPaid);
            }
            else
                return null;
        }


        private bool _AddNewPayment()
        {
            this.PaymentID = clsPaymentsData.AddNewPayment(InvoiceID, (byte)PaymentMethod, PaymentDate, AmountPaid);
            return (PaymentID != -1);
        }

        private bool _UpdatePayment()
        {
            return clsPaymentsData.UpdatePayment(PaymentID,InvoiceID, (byte)PaymentMethod, PaymentDate, AmountPaid);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (_AddNewPayment())
                    {
                        Mode = enMode.Update;
                        return true;

                    }
                    else
                    {
                        return false;
                    }


                case enMode.Update:

                    return (_UpdatePayment());


            }

            return false;
        }

        public bool Delete()
        {
            return clsPaymentsData.DeletePayment(this.PaymentID);
        }

        public static DataTable GetAllPayments()
        {
            return clsPaymentsData.GetAllPayments();
        }

        public float GetTotalPaid()
        {
            return clsPaymentsData.GetTotalPaidByInvoiceID(this.InvoiceID);
        }


        public static float GetTotalPaidByInvoiceID(int InvoiceID)
        { 
           return clsPaymentsData.GetTotalPaidByInvoiceID(InvoiceID);
        }


    }
}
