using CIMS_DataAccessLayar;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIMS_BusinessLayer
{
    public class clsCustomer : clsPerson
    {
        public enum enMode { AddNew = 0, Update = 1 }
        private enMode Mode = enMode.AddNew;

        public int CustomerID { get; set; }
        public DateTime CreateDate { get; set; }

        public string CustomerFullName
        {
            get
            {
                return base.FullName;
            }


        }

        public clsCustomer()
        {
            this.CustomerID = -1;
            this.CreateDate = DateTime.Now;

            Mode = enMode.AddNew;
        }


        private clsCustomer(int CustomerID, DateTime CreateDate , int PersonID, string FirstName, string SecondName, string ThirdName,
            string LastName, DateTime DateOfBirth, byte Gender, string Address, string Phone, string Email,
            int NationalityCountryID, string ImagePath)
        {
            this.CustomerID = CustomerID;
            this.CreateDate = CreateDate;

            base.PersonID             = PersonID;
            base.FirstName            = FirstName;
            base.SecondName           = SecondName;
            base.ThirdName            = ThirdName;
            base.LastName             = LastName;
            base.DateOfBirth          = DateOfBirth;
            base.Gender               = Gender;
            base.Address              = Address;
            base.Phone                = Phone;
            base.Email                = Email;
            base.NationalityCountryID = NationalityCountryID;
            base.ImagePath = ImagePath;

            base.CountryInfo = clsCountry.Find(NationalityCountryID);

            Mode = enMode.Update;

        }


        public static clsCustomer Find(int CustomerID)
        {
            int PersonID = -1;
            
            DateTime CreateDate = DateTime.Now;
           

            bool IsFonud = clsCustomersData.GetCustomerInfoByID(CustomerID, ref PersonID, ref CreateDate);

            if (IsFonud)
            {

                clsPerson Person = clsPerson.FindBasePerson(PersonID);

                return new clsCustomer(CustomerID, CreateDate, Person.PersonID, Person.FirstName, Person.SecondName, Person.ThirdName, Person.LastName, Person.DateOfBirth, Person.Gender,
                                      Person.Address, Person.Phone, Person.Email, Person.NationalityCountryID, Person.ImagePath);
            }
            else
            {
                return null;
            }


        }


        private bool _AddNewCustomer()
        {
            this.CustomerID = clsCustomersData.AddNewCustomer(base.PersonID, this.CreateDate);

            return (this.CustomerID != -1);
        }

        private bool _UpdateCustomer()
        {

            return clsCustomersData.UpdateCustomer(this.CustomerID, this.PersonID, this.CreateDate);


        }



        public bool Save()
        {
            base.Mode = (clsPerson.enMode)Mode;
            if (!base.Save())
                return false;

            switch (Mode)
            {
                case enMode.AddNew:

                    if (_AddNewCustomer())
                    {
                        Mode = enMode.Update;
                        return true;

                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateCustomer();

            }

            return false;
        }

        public bool Delete()
        {
            if (!clsCustomersData.DeleteCustomer(this.CustomerID)) 
                return false;

            return base.Delete();
        }

        public static DataTable GetAllCustomers()
        {
            return clsCustomersData.GetAllCustomers();
        }


    }
}
