using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIMS_DataAccessLayar;

namespace CIMS_BusinessLayer
{
    public class clsUser : clsPerson
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode Mode = enMode.AddNew;

        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }

        public string UserFullName
        {
            get
            {
                return base.FullName;
            }

        }

        public clsUser()
        {
            UserID = -1;
            PersonID = -1;
            UserName = "";
            Password = "";
            IsActive = true;

            Mode = enMode.AddNew;
        }

        private clsUser(int UserID, int PersonID, string UserName, string Password, bool IsActive, string FirstName, string SecondName, string ThirdName,
            string LastName, DateTime DateOfBirth, byte Gender, string Address, string Phone, string Email,
            int NationalityCountryID, string ImagePath)
        {
            this.UserID = UserID;
            base.PersonID = PersonID;
            this.UserName = UserName;
            this.Password = Password;
            this.IsActive = IsActive;

            base.FirstName = FirstName;
            base.SecondName = SecondName;
            base.ThirdName = ThirdName;
            base.LastName = LastName;
            base.DateOfBirth = DateOfBirth;
            base.Gender = Gender;
            base.Address = Address;
            base.Phone = Phone;
            base.Email = Email;
            base.NationalityCountryID = NationalityCountryID;
            base.ImagePath = ImagePath;

            base.CountryInfo = clsCountry.Find(NationalityCountryID);


            Mode = enMode.Update;
        }



        public static clsUser Find(int UserID)
        {
            int PersonID = -1;
            string UserName = "", Password = "";
            bool IsActive = false;

            bool IsFonud = clsUsersData.GetUserInfoByUserID(UserID, ref PersonID, ref UserName, ref Password, ref IsActive);

            if (IsFonud)
            {
                clsPerson Person = clsPerson.FindBasePerson(PersonID);

                return new clsUser(UserID, PersonID, UserName, Password, IsActive,Person.FirstName, Person.SecondName, Person.ThirdName, Person.LastName, Person.DateOfBirth, Person.Gender,
                                      Person.Address, Person.Phone, Person.Email, Person.NationalityCountryID, Person.ImagePath);
            }
            else
                return null;

        }

        public static clsUser FindByUserNameAndPassword(string UserName, string Password)
        {
            int UserID = -1, PersonID = -1;
            bool IsActive = false;


            bool IsFonud = clsUsersData.GetUserInfoByUserNameAndPassword(UserName, Password, ref UserID, ref PersonID, ref IsActive);

            if (IsFonud)
            {
                clsPerson Person = clsPerson.FindBasePerson(PersonID);

                return new clsUser(UserID, PersonID, UserName, Password, IsActive, Person.FirstName, Person.SecondName, Person.ThirdName, Person.LastName, Person.DateOfBirth, Person.Gender,
                                      Person.Address, Person.Phone, Person.Email, Person.NationalityCountryID, Person.ImagePath);
            }
            else
                return null;



        }


        private bool _AddNewUser()
        {

            this.UserID = clsUsersData.AddNewUser(base.PersonID, this.UserName, this.Password, this.IsActive);
            return (UserID != -1);


        }

        private bool _UpdateUser()
        {

            return clsUsersData.UpdateUser(this.UserID, base.PersonID, this.UserName, this.Password, this.IsActive);


        }

        public bool Save()
        {
            base.Mode = (clsPerson.enMode)Mode;
            if (!base.Save())
                return false;

            switch (Mode)
            {
                case enMode.AddNew:
                  
                   if (_AddNewUser())
                   {
                       Mode = enMode.Update;
                       return true;

                   }
                   else
                   {
                       return false;
                   }

                  
                case enMode.Update:
                  
                    return (_UpdateUser());
                    

            }

            return false;
        }



        public bool Delete()
        {
            if (!clsUsersData.DeleteUser(this.UserID))
                return false;

            return base.Delete();
        }

        public static DataTable GetAllUsers()
        {
            return clsUsersData.GetAllUsers();

        }

        public static bool IsUserExists(int UserID)
        {
            return clsUsersData.IsUserExists(UserID);
        }

        public static bool IsUserExists(string UserName)
        {
            return clsUsersData.IsUserExists(UserName);

        }


        public bool ChangePassword(string NewPassword)
        {
            return clsUsersData.ChangePassword(this.UserID, NewPassword);
        }



    }
}
