using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CIMS_DataAccessLayar
{
    public class clsInvoiceDetailsData
    {
        public static bool GetInvoiceDetailInfoByID(int InvoiceDetailID, ref int InvoiceID, ref int ProductID, ref int Quantity, ref float UnitPrice, ref float SubTotal)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = "SELECT * FROM InvoiceDetails WHERE InvoiceDetailID = @InvoiceDetailID ;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@InvoiceDetailID", InvoiceDetailID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;

                    InvoiceID = (int)reader["InvoiceID"];
                    ProductID = (int)reader["ProductID"];
                    Quantity  = (int)reader["Quantity"];
                    UnitPrice = (float)reader["UnitPrice"];
                    SubTotal  = (float)reader["SubTotal"];



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

        public static int AddNewInvoiceDetail(int InvoiceID, int ProductID, int Quantity, float UnitPrice, float SubTotal)
        {
            int ID = -1;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);
            string query = "INSERT INTO InvoiceDetails VALUES (@InvoiceID , @ProductID ,@Quantity ,@UnitPrice ,@SubTotal );" +
                           "SELECT SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@InvoiceID", InvoiceID);
            command.Parameters.AddWithValue("@ProductID", ProductID);
            command.Parameters.AddWithValue("@Quantity", Quantity);
            command.Parameters.AddWithValue("@UnitPrice", UnitPrice);
            command.Parameters.AddWithValue("@SubTotal", SubTotal);


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

        public static int AddNewInvoiceDetail_1(int InvoiceID, DataTable dtProductsAdded)
        {
            int lastID = -1;

            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);
            SqlCommand command;

            try
            {
                connection.Open();

                foreach (DataRow row in dtProductsAdded.Rows)
                {
                    string query = @"INSERT INTO InvoiceDetails (InvoiceID, ProductID, Quantity, UnitPrice, SubTotal)
                                   VALUES (@InvoiceID , @ProductID , @Quantity , @UnitPrice , @SubTotal);
                                   SELECT SCOPE_IDENTITY()";

                    command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@InvoiceID", InvoiceID);
                    command.Parameters.AddWithValue("@ProductID", Convert.ToInt32(row["ProductID"]));
                    command.Parameters.AddWithValue("@Quantity", Convert.ToInt32(row["Quantity"]));
                    command.Parameters.AddWithValue("@UnitPrice", Convert.ToDecimal(row["UnitPrice"]));
                    command.Parameters.AddWithValue("@SubTotal", Convert.ToDecimal(row["SubTotal"]));

                    object result = command.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    {
                        lastID = insertedID;
                    }

                    // مهم جداً: أغلق الـCommand بعد كل تنفيذ
                    command.Dispose();
                }
            }
            catch
            {
                lastID = -1;
            }
            finally
            {
                // مهم جداً: إغلاق الاتصال بعد انتهاء كل شيء
                if (connection.State == ConnectionState.Open)
                    connection.Close();

                connection.Dispose();
            }

            return lastID;

        }


        public static bool UpdateInvoiceDetail(int InvoiceDetailID, int InvoiceID, int ProductID, int Quantity, float UnitPrice, float SubTotal)
        {
            int RowAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);
            string query = "UPDATE InvoiceDetails SET InvoiceID=@InvoiceID ,ProductID=@ProductID ,Quantity=@Quantity ,UnitPrice=@UnitPrice ,SubTotal=@SubTotal " +
                           "WHERE InvoiceDetailID = @InvoiceDetailID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@InvoiceDetailID", InvoiceDetailID);
            command.Parameters.AddWithValue("@InvoiceID", InvoiceID);
            command.Parameters.AddWithValue("@ProductID", ProductID);
            command.Parameters.AddWithValue("@Quantity", Quantity);
            command.Parameters.AddWithValue("@UnitPrice", UnitPrice);
            command.Parameters.AddWithValue("@SubTotal", SubTotal);

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

        public static bool DeleteInvoiceDetail(int InvoiceDetailID)
        {
            int RowAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);
            string query = "DELETE FROM InvoiceDetails WHERE InvoiceDetailID = @InvoiceDetailID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@InvoiceDetailID", InvoiceDetailID);

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

        public static bool DeleteInvoiceDetailByInvoiceID(int InvoiceID)
        {
            int RowAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);
            string query = "DELETE FROM InvoiceDetails WHERE InvoiceID = @InvoiceID";

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

        public static DataTable GetAllInvoiceDetailByInvoiceID(int InvoiceID)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);
            string query = @"SELECT  InvoiceDetails.ProductID,Products.Name, InvoiceDetails.Quantity, InvoiceDetails.UnitPrice, InvoiceDetails.SubTotal 
                             FROM    Products INNER JOIN InvoiceDetails ON Products.ProductID = InvoiceDetails.ProductID
                             WHERE   InvoiceDetails.InvoiceID = @InvoiceID
							 Order By ProductID ASC;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@InvoiceID", InvoiceID);

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

        public static DataTable GetAllInvoiceDetailByInvoiceID_1(int InvoiceID)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);
            string query = @"SELECT  InvoiceDetails.InvoiceDetailID,Products.Name, InvoiceDetails.Quantity, InvoiceDetails.UnitPrice, InvoiceDetails.SubTotal 
                             FROM    Products INNER JOIN InvoiceDetails ON Products.ProductID = InvoiceDetails.ProductID
                             WHERE   InvoiceDetails.InvoiceID = @InvoiceID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@InvoiceID", InvoiceID);

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
