using CIMS_DataAccessLayar;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CIMS_BusinessLayer
{
    public class clsProduct
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode Mode = enMode.AddNew;
        
        public int    ProductID       { get; set; }
        public string Name            { get; set; }
        public string Description     { get; set; }
        public float Price           { get; set; }
        public int    QuantityInStock { get; set; }
        public string ImagePath       { get; set; }

        public clsProduct()
        {
            ProductID = -1;
            Name = "";
            Description = "";
            Price = 0;
            QuantityInStock = 0;
            ImagePath = "";

            Mode = enMode.AddNew;
        }

        private clsProduct(int ProductID, string Name, string Description, float Price, int QuantityInStock, string ImagePath)
        {
            this.ProductID = ProductID;
            this.Name = Name;
            this.Description = Description;
            this.Price = Price;
            this.QuantityInStock = QuantityInStock;
            this.ImagePath = ImagePath;

            Mode = enMode.Update;
        }

        public static clsProduct Find(int ProductID)
        {
            int QuantityInStock = 0;
            string Name = "", Description = "" , ImagePath="";
            float Price = 0;

            if (clsProductsData.GetProductInfoByProductID(ProductID ,ref Name ,ref Description , ref Price , ref QuantityInStock , ref ImagePath))
            {
                return new clsProduct(ProductID, Name, Description, Price, QuantityInStock, ImagePath);
            }
            else
                return null;
        }

        public static clsProduct FindByName(string Name)
        {
            int QuantityInStock = 0 , ProductID =-1;
            string Description = "", ImagePath = "";
            float Price = 0;

            if (clsProductsData.GetProductInfoByProductName(Name, ref ProductID, ref Description, ref Price, ref QuantityInStock, ref ImagePath))
            {
                return new clsProduct(ProductID, Name, Description, Price, QuantityInStock, ImagePath);
            }
            else
                return null;
        }


        private bool _AddNewProduct()
        {

            this.ProductID = clsProductsData.AddNewProduct(this.Name, this.Description, this.Price, this.QuantityInStock, this.ImagePath);
            return (ProductID != -1);

        }

        private bool _UpdateProduct()
        {

            return clsProductsData.UpdateProduct(this.ProductID, this.Name, this.Description, this.Price, this.QuantityInStock, this.ImagePath);


        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (_AddNewProduct())
                    {
                        Mode = enMode.Update;
                        return true;

                    }
                    else
                    {
                        return false;
                    }


                case enMode.Update:

                    return (_UpdateProduct());


            }

            return false;
        }

        public bool Delete()
        {
          return clsProductsData.DeleteProduct(this.ProductID);
        }

        public static DataTable GetAllProducts()
        {

            return clsProductsData.GetAllProducts();
        }


        public bool DecreaseStock(int Quantity)
        {
            return clsProductsData.UpdateQuantityInStock(this.ProductID , this.QuantityInStock - Quantity);
        }

        public bool IncreaseStock(int Quantity)
        {
            return clsProductsData.UpdateQuantityInStock(this.ProductID, this.QuantityInStock + Quantity);
        }

        public static int GetProductIDByProductName(string ProductName)
        {
            return clsProductsData.GetProductIDByProductName(ProductName);
        }
    }
}
