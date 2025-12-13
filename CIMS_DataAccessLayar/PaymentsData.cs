using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIMS_DataAccessLayar
{
    public class clsPaymentsData
    {
        public static bool GetPaymentInfoByID(int PaymentID, ref int InvoiceID, ref byte PaymentMethod, ref DateTime PaymentDate, ref float AmountPaid)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = "SELECT * FROM Payments WHERE PaymentID = @PaymentID ;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PaymentID", PaymentID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;

                    InvoiceID = (int)reader["InvoiceID"];
                    PaymentDate = (DateTime)reader["PaymentDate"];
                    PaymentMethod = (byte)reader["PaymentMethod"];
                    AmountPaid = (float)reader["AmountPaid"];
                    

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

        public static int AddNewPayment(int InvoiceID, byte PaymentMethod,  DateTime PaymentDate, float AmountPaid)
        {
            int ID = -1;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);
            string query = "INSERT INTO Payments VALUES (@InvoiceID , @PaymentMethod ,@PaymentDate ,@AmountPaid );" +
                           "SELECT SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@InvoiceID", InvoiceID);
            command.Parameters.AddWithValue("@PaymentMethod", PaymentMethod);
            command.Parameters.AddWithValue("@PaymentDate", PaymentDate);
            command.Parameters.AddWithValue("@AmountPaid", AmountPaid);
            


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

        public static bool UpdatePayment(int PaymentID, int InvoiceID, byte PaymentMethod, DateTime PaymentDate, float AmountPaid)
        {
            int RowAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);
            string query = "UPDATE Payments SET InvoiceID=@InvoiceID , PaymentMethod=@PaymentMethod , PaymentDate=@PaymentDate , AmountPaid=@AmountPaid " +
                           "WHERE PaymentID = @PaymentID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PaymentID"    , PaymentID);
            command.Parameters.AddWithValue("@InvoiceID"    , InvoiceID);
            command.Parameters.AddWithValue("@PaymentMethod", PaymentMethod);
            command.Parameters.AddWithValue("@PaymentDate"  , PaymentDate);
            command.Parameters.AddWithValue("@AmountPaid"   , AmountPaid);

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

        public static bool DeletePayment(int PaymentID)
        {
            int RowAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);
            string query = "DELETE FROM Payments WHERE PaymentID = @PaymentID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PaymentID", PaymentID);

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

        public static DataTable GetAllPayments()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);
            string query = "SELECT * FROM Payments_View;";

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

        public static float GetTotalPaidByInvoiceID(int InvoiceID )
        {
            float TotalPaid = 0;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);
            string query = "SELECT SUM(AmountPaid) as TotalPaid FROM Payments WHERE InvoiceID = @InvoiceID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@InvoiceID", InvoiceID);
            
            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();

                if (Result != null)
                {
                    TotalPaid = Convert.ToSingle(Result.ToString());
                }

            }
            catch
            {
                TotalPaid = 0;

            }
            finally
            {

                connection.Close();
            }

            return TotalPaid;

        }

    }
}
