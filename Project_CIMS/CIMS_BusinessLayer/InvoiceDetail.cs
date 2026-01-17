using CIMS_DataAccessLayar;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CIMS_BusinessLayer.clsInvoice;

namespace CIMS_BusinessLayer
{
    public class clsInvoiceDetail
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode Mode = enMode.AddNew;

        public int InvoiceDetailID { get; set; }
        public int   InvoiceID { get; set; }
        public clsInvoice InvoiceInfo;
        public int   ProductID { get; set; }
        public clsProduct ProductInfo;
        public int   Quantity  { get; set; }
        public float UnitPrice { get; set; }
        public float SubTotal  { get; set; }

        public clsInvoiceDetail()
        {
            InvoiceDetailID = -1;
            InvoiceID       = -1;
            ProductID       = -1;
            Quantity        =  0;
            UnitPrice       =  0;
            SubTotal        =  0;

            Mode = enMode.AddNew;
        }

        private clsInvoiceDetail(int InvoiceDetailID, int InvoiceID, int ProductID, int Quantity, float UnitPrice, float SubTotal)
        {
            this.InvoiceDetailID = InvoiceDetailID;
            this.InvoiceID       = InvoiceID;
            this.ProductID       = ProductID;
            this.Quantity        = Quantity;
            this.UnitPrice       = UnitPrice;
            this.SubTotal        = SubTotal;

            ProductInfo = clsProduct.Find(ProductID);
            InvoiceInfo = clsInvoice.Find(InvoiceID);

            Mode = enMode.Update;
        }


        public static clsInvoiceDetail Find(int InvoiceDetailID)
        {
            int InvoiceID = -1, ProductID = -1 , Quantity = 0;
            
            float UnitPrice = 0 , SubTotal = 0;

            if (clsInvoiceDetailsData.GetInvoiceDetailInfoByID(InvoiceDetailID , ref InvoiceID, ref ProductID, ref Quantity, ref UnitPrice, ref SubTotal))
            {
                return new clsInvoiceDetail(InvoiceDetailID , InvoiceID, ProductID, Quantity, UnitPrice, SubTotal);
            }
            else
                return null;
        }

        private bool _AddNewInvoiceDetail()
        {

            this.InvoiceDetailID = clsInvoiceDetailsData.AddNewInvoiceDetail(this.InvoiceID, this.ProductID, this.Quantity, this.UnitPrice, this.SubTotal);
            return (InvoiceDetailID != -1);

        }

        private bool _UpdateInvoiceDetail()
        {

            return clsInvoiceDetailsData.UpdateInvoiceDetail(this.InvoiceDetailID, this.InvoiceID, this.ProductID, this.Quantity, this.UnitPrice, this.SubTotal);

        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (_AddNewInvoiceDetail())
                    {
                        Mode = enMode.Update;
                        return true;

                    }
                    else
                    {
                        return false;
                    }


                case enMode.Update:

                    return (_UpdateInvoiceDetail());


            }

            return false;
        }

        public bool Delete()
        {
            return clsInvoiceDetailsData.DeleteInvoiceDetail(this.InvoiceDetailID);
        }

        public static bool DeleteAllInvoiceDetails(int InvoiceID)
        {
            return clsInvoiceDetailsData.DeleteInvoiceDetailByInvoiceID(InvoiceID);
        }

        public  DataTable GetAllInvoiceDetails_1()
        {
            return clsInvoiceDetailsData.GetAllInvoiceDetailByInvoiceID_1(this.InvoiceID);
        }

        public static DataTable GetAllInvoiceDetails_1(int InvoiceID)
        {
            return clsInvoiceDetailsData.GetAllInvoiceDetailByInvoiceID_1(InvoiceID);
        }

        public static DataTable GetAllInvoiceDetails(int InvoiceID)
        {
            return clsInvoiceDetailsData.GetAllInvoiceDetailByInvoiceID(InvoiceID);
        }


    }
}
