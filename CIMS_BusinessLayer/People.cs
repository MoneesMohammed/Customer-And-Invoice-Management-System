using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIMS_DataAccessLayar;

namespace CIMS_BusinessLayer
{
    public class clsPerson
    {

        public enum enMode { AddNew = 0, Update = 1 }
        protected enMode Mode = enMode.AddNew;

        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public byte Gender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int NationalityCountryID { get; set; }

        public clsCountry CountryInfo;

        private string _ImagePath;
        public string ImagePath
        {
            get { return _ImagePath; }
            set { _ImagePath = value; }
        }

        public string FullName
        {
            get
            {
                return (this.ThirdName == "") ?
                     $"{this.FirstName} {this.SecondName} {this.LastName}" :
                     $"{this.FirstName} {this.SecondName} {this.ThirdName} {this.LastName}";
            }

        }

        public clsPerson()
        {
            PersonID = -1;
            FirstName = "";
            SecondName = "";
            ThirdName = "";
            LastName = "";
            DateOfBirth = DateTime.Now;
            Gender = 0;
            Address = "";
            Phone = "";
            Email = "";
            NationalityCountryID = -1;
            ImagePath = "";

            Mode = enMode.AddNew;

        }

        private clsPerson(int PersonID, string FirstName, string SecondName, string ThirdName,
            string LastName, DateTime DateOfBirth, byte Gender, string Address, string Phone, string Email,
            int NationalityCountryID, string ImagePath)
        {
            this.PersonID             = PersonID;
            this.FirstName            = FirstName;
            this.SecondName           = SecondName;
            this.ThirdName            = ThirdName;
            this.LastName             = LastName;
            this.DateOfBirth          = DateOfBirth;
            this.Gender               = Gender;
            this.Address              = Address;
            this.Phone                = Phone;
            this.Email                = Email;
            this.NationalityCountryID = NationalityCountryID;
            this.ImagePath            = ImagePath;
            this.CountryInfo = clsCountry.Find(NationalityCountryID);

            Mode = enMode.Update;

        }

        public static clsPerson FindBasePerson(int PersonID)
        {
            int NationalityCountryID = -1;
            string  FirstName = "", SecondName = "", ThirdName = "", LastName = "", Address = "", Phone = "", Email = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now;
            byte Gendor = 0;

            if (clsPeopleData.GetPersonInfoByID(PersonID, ref FirstName, ref SecondName, ref ThirdName,
                ref LastName, ref DateOfBirth, ref Gendor, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath))
            {
                return new clsPerson(PersonID, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor,
                                      Address, Phone, Email, NationalityCountryID, ImagePath);
            }
            else
            {
                return null;
            }


        }



        private bool _AddNewPerson()
        {

            this.PersonID = clsPeopleData.AddNewPerson(FirstName, SecondName, ThirdName, LastName,
                                              DateOfBirth, Gender, Address, Phone, Email, NationalityCountryID, ImagePath);

            return (PersonID != -1);


        }

        private bool _UpdatePerson()
        {

            return clsPeopleData.UpdatePerson(this.PersonID, FirstName, SecondName, ThirdName, LastName,
                                              DateOfBirth, Gender, Address, Phone, Email, NationalityCountryID, ImagePath);


        }


        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                  
                   if (_AddNewPerson())
                   {
                       Mode = enMode.Update;
                       return true;

                   }
                   else
                   {
                       return false;
                   }

                case enMode.Update:
                   
                   return _UpdatePerson();

            }

            return false;
        }


        public bool Delete()
        {
            return clsPeopleData.DeletePerson(this.PersonID);
        }

        public static DataTable GetAllPeople()
        {
            return clsPeopleData.GetAllPeople();

        }

        public static bool IsPersonExists(int PersonID)
        {
            return clsPeopleData.IsPersonExists(PersonID);
        }

        public byte GetAge()
        {
            if (PersonID == -1)
                return 0;

            return (byte)(DateTime.Now.Year - DateOfBirth.Year);

        }

    }
}
