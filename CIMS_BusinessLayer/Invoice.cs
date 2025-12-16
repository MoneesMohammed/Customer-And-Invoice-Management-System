using CIMS_DataAccessLayar;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIMS_BusinessLayer
{
    public class clsInvoice
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode Mode = enMode.AddNew;

        public enum enInvoiceStatus { Paid = 0, Unpaid = 1, Pending = 2, Cancelled = 3 };

        public int             InvoiceID        { get; set; }
        public int             CustomerID       { get; set; }
        public clsCustomer     CustomerInfo;
        public DateTime        InvoiceDate      { get; set; }
        public enInvoiceStatus InvoiceStatus    { get; set; }
        public float           TotalAmount      { get; set; }
        public int        CreatedByUserID { get; set; }
        public clsUser    CreatedByUserInfo;

        public string StatusText
        {
            get
            {
                switch (InvoiceStatus)
                {
                    case enInvoiceStatus.Paid:
                        return "Paid";
                    case enInvoiceStatus.Cancelled:
                        return "Cancelled";
                    case enInvoiceStatus.Unpaid:
                        return "Unpaid";
                    case enInvoiceStatus.Pending:
                        return "Pending";
                    default:
                        return "Unknown";

                }

            }

        }

        public clsInvoice()
        {
            InvoiceID = -1;
            CustomerID = -1;
            InvoiceDate = DateTime.Now;
            InvoiceStatus = enInvoiceStatus.Unpaid;
            TotalAmount = 0;
            CreatedByUserID = -1;

            Mode = enMode.AddNew;
        }

        private clsInvoice(int InvoiceID, int CustomerID, DateTime InvoiceDate, enInvoiceStatus InvoiceStatus, float TotalAmount, int CreatedByUserID)
        {
            this.InvoiceID = InvoiceID;
            this.CustomerID = CustomerID;
            this.InvoiceDate = InvoiceDate;
            this.InvoiceStatus = InvoiceStatus;
            this.TotalAmount = TotalAmount;
            this.CreatedByUserID = CreatedByUserID;

            CustomerInfo = clsCustomer.Find(CustomerID);
            CreatedByUserInfo = clsUser.Find(CreatedByUserID);

            Mode = enMode.Update;
        }

        public static clsInvoice Find(int InvoiceID)
        {
            int CustomerID = -1 , CreatedByUserID = -1;
            DateTime InvoiceDate = DateTime.Now;
            byte InvoiceStatus = 0;
            float TotalAmount = 0;

            if (clsInvoicesData.GetInvoiceInfoByInvoiceID(InvoiceID, ref CustomerID, ref InvoiceDate, ref InvoiceStatus, ref TotalAmount, ref CreatedByUserID))
            {
                return new clsInvoice(InvoiceID, CustomerID, InvoiceDate, (enInvoiceStatus)InvoiceStatus, TotalAmount, CreatedByUserID);
            }
            else
                return null;
        }

        public static clsInvoice FindByCustomerID(int CustomerID)
        {
            int InvoiceID = -1, CreatedByUserID = -1;
            DateTime InvoiceDate = DateTime.Now;
            byte InvoiceStatus = 0;
            float TotalAmount = 0;

            if (clsInvoicesData.GetInvoiceInfoByCustomerID(CustomerID, ref InvoiceID, ref InvoiceDate, ref InvoiceStatus, ref TotalAmount, ref CreatedByUserID))
            {
                return new clsInvoice(InvoiceID, CustomerID, InvoiceDate, (enInvoiceStatus)InvoiceStatus, TotalAmount, CreatedByUserID);
            }
            else
                return null;
        }


        private bool _AddNewInvoice()
        {

            this.InvoiceID = clsInvoicesData.AddNewInvoice(this.CustomerID, this.InvoiceDate, (byte)this.InvoiceStatus, this.TotalAmount, this.CreatedByUserID);
            return (InvoiceID != -1);

        }

        private bool _UpdateInvoice()
        {

            return clsInvoicesData.UpdateInvoice(this.InvoiceID, this.CustomerID, this.InvoiceDate, (byte)this.InvoiceStatus, this.TotalAmount, this.CreatedByUserID);


        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (_AddNewInvoice())
                    {
                        Mode = enMode.Update;
                        return true;

                    }
                    else
                    {
                        return false;
                    }


                case enMode.Update:

                    return (_UpdateInvoice());


            }

            return false;
        }

        public bool Delete()
        {
            return clsInvoicesData.DeleteInvoice(this.InvoiceID);
        }

        public static DataTable GetAllInvoices()
        {

            return clsInvoicesData.GetAllInvoices();
        }

        public static DataTable GetInvoicesByCustomerID(int CustomerID)
        {
            return clsInvoicesData.GetInvoicesByCustomerID(CustomerID);
        }

        public bool SetTotalAmount(float TotalAmount)
        {
            return clsInvoicesData.SetTotalAmount(this.InvoiceID , TotalAmount);
        }

        public bool SetStatus(enInvoiceStatus status)
        {
            return clsInvoicesData.SetStatus(this.InvoiceID, (byte)status);
        }

        public bool IsCancelled()
        {
            return this.InvoiceStatus == enInvoiceStatus.Cancelled;  
        }
        

        public bool IsPaid()
        {
            return this.InvoiceStatus == enInvoiceStatus.Paid;
        }
    }
}
