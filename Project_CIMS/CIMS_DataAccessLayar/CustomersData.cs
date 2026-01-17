using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIMS_DataAccessLayar
{
    public class clsCustomersData
    {
        public static bool GetCustomerInfoByID(int CustomerID, ref int PersonID, ref DateTime CreateDate)
        {
            bool Isfound = false;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);
            string query = "SELECT * FROM Customers WHERE CustomerID = @CustomerID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CustomerID", CustomerID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Isfound = true;

                    PersonID = (int)reader["PersonID"];
                    CreateDate = (DateTime)reader["CreateDate"];



                }

                reader.Close();

            }
            catch
            {
                Isfound = false;
            }
            finally
            {
                connection.Close();
            }

            return Isfound;
        }

        public static int AddNewCustomer(int PersonID, DateTime CreateDate)
        {
            int ID = -1;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);
            string query = "INSERT INTO Customers VALUES (@PersonID , @CreateDate );" +
                           "SELECT SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@CreateDate", CreateDate);
            

            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int insertedID))
                {
                    ID = insertedID;
                }

            }
            catch
            {
                ID = -1;

            }
            finally
            {

                connection.Close();
            }

            return ID;

        }


        public static bool UpdateCustomer(int CustomerID, int PersonID, DateTime CreateDate)
        {
            int RowAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);
            string query = "UPDATE Customers SET PersonID=@PersonID , CreateDate=@CreateDate " +
                           "WHERE CustomerID = @CustomerID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CustomerID", CustomerID);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@CreateDate", CreateDate);
            

            try
            {
                connection.Open();

                RowAffected = command.ExecuteNonQuery();


            }
            catch//(Exception e)
            {

                return false;

            }
            finally
            {
                connection.Close();
            }

            return (RowAffected > 0);
        }


        public static bool DeleteCustomer(int CustomerID)
        {
            int RowAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);
            string query = "DELETE FROM Customers WHERE CustomerID = @CustomerID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CustomerID", CustomerID);

            try
            {
                connection.Open();

                RowAffected = command.ExecuteNonQuery();


            }
            catch
            {

                return false;

            }
            finally
            {
                connection.Close();


            }

            return (RowAffected > 0);

        }

        public static DataTable GetAllCustomers()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);
            string query = "SELECT * FROM Customers_View;"; 

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {

                    dt.Load(reader);

                }

                reader.Close();
            }
            catch
            {



            }
            finally
            {
                connection.Close();


            }


            return dt;

        }




    }
}
