using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIMS_DataAccessLayar
{
    public class clsInvoicesData
    {
        public static bool GetInvoiceInfoByInvoiceID(int InvoiceID, ref int CustomerID, ref DateTime InvoiceDate, ref byte InvoiceStatus, ref float TotalAmount, ref int CreatedByUserID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = "SELECT * FROM Invoices WHERE InvoiceID = @InvoiceID ;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@InvoiceID", InvoiceID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;

                    CustomerID      = (int)reader["CustomerID"];
                    InvoiceDate     = (DateTime)reader["InvoiceDate"];
                    InvoiceStatus   = (byte)reader["InvoiceStatus"];
                    TotalAmount     = (float)reader["TotalAmount"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];

                }


                reader.Close();
            }
            catch//(Exception e)
            {
                isFound = false;

            }
            finally
            {
                connection.Close();


            }

            return isFound;
        }

        public static bool GetInvoiceInfoByCustomerID(int CustomerID, ref int InvoiceID , ref DateTime InvoiceDate, ref byte InvoiceStatus, ref float TotalAmount, ref int CreatedByUserID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = "SELECT * FROM Invoices WHERE CustomerID = @CustomerID ;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CustomerID", CustomerID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;

                    InvoiceID = (int)reader["InvoiceID"];
                    InvoiceDate = (DateTime)reader["InvoiceDate"];
                    InvoiceStatus = (byte)reader["InvoiceStatus"];
                    TotalAmount = (float)reader["TotalAmount"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];

                }


                reader.Close();
            }
            catch//(Exception e)
            {
                isFound = false;

            }
            finally
            {
                connection.Close();


            }

            return isFound;
        }

        public static int AddNewInvoice(int CustomerID, DateTime InvoiceDate, byte InvoiceStatus, float TotalAmount, int CreatedByUserID)
        {
            int ID = -1;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);
            string query = "INSERT INTO Invoices VALUES (@CustomerID , @InvoiceDate , @InvoiceStatus ,@TotalAmount ,@CreatedByUserID );" +
                           "SELECT SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CustomerID"     ,CustomerID      );
            command.Parameters.AddWithValue("@InvoiceDate"    ,InvoiceDate     );
            command.Parameters.AddWithValue("@InvoiceStatus"  ,InvoiceStatus   );
            command.Parameters.AddWithValue("@TotalAmount"    ,TotalAmount     );
            command.Parameters.AddWithValue("@CreatedByUserID",CreatedByUserID );


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

        public static bool UpdateInvoice(int InvoiceID , int CustomerID, DateTime InvoiceDate, byte InvoiceStatus, float TotalAmount, int CreatedByUserID)
        {
            int RowAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);
            string query = "UPDATE Invoices SET CustomerID=@CustomerID ,InvoiceDate=@InvoiceDate ,InvoiceStatus=@InvoiceStatus ,TotalAmount=@TotalAmount , CreatedByUserID=@CreatedByUserID " +
                           "WHERE InvoiceID = @InvoiceID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@InvoiceID"      , InvoiceID);
            command.Parameters.AddWithValue("@CustomerID"     , CustomerID);
            command.Parameters.AddWithValue("@InvoiceDate"    , InvoiceDate);
            command.Parameters.AddWithValue("@InvoiceStatus"  , InvoiceStatus);
            command.Parameters.AddWithValue("@TotalAmount"    , TotalAmount);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

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

        public static bool DeleteInvoice(int InvoiceID)
        {
            int RowAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);
            string query = "DELETE FROM Invoices WHERE InvoiceID = @InvoiceID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@InvoiceID", InvoiceID);

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

        public static DataTable GetAllInvoices()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);
            string query = "SELECT * FROM Invoices_View;";

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

        public static DataTable GetInvoicesByCustomerID(int CustomerID)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);
            string query = @"SELECT * FROM Invoices_View WHERE [Full Name] = 
                            (SELECT P.FirstName+' '+ P.SecondName+' '+ P.ThirdName+' '+P.LastName as CustomerName
                            FROM Customers C JOIN People P ON C.PersonID = P.PersonID
                            WHERE C.CustomerID = @CustomerID)
                            ORDER BY [Invoice ID];";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CustomerID", CustomerID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                { dt.Load(reader); }
                   
                reader.Close();
            }
            catch { }
            finally { connection.Close(); }
            
            return dt;
        }


        public static bool SetTotalAmount(int InvoiceID, float TotalAmount)
        {
            int RowAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);
            string query = "UPDATE Invoices SET TotalAmount = @TotalAmount " +
                           "WHERE InvoiceID = @InvoiceID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@InvoiceID", InvoiceID);
            command.Parameters.AddWithValue("@TotalAmount", TotalAmount);

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

        public static bool SetStatus(int InvoiceID, byte InvoiceStatus)
        {
            int RowAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);
            string query = "UPDATE Invoices SET InvoiceStatus = @InvoiceStatus " +
                           "WHERE InvoiceID = @InvoiceID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@InvoiceID", InvoiceID);
            command.Parameters.AddWithValue("@InvoiceStatus", InvoiceStatus);

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

    }
}
