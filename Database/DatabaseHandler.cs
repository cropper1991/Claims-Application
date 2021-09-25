using System;
using Microsoft.Data.SqlClient;
using Claims_Application.Structures;
using Microsoft.Extensions.Logging;

namespace Claims_Application.Database
{
    //Class Designed for all Database Handling
    public class DatabaseHandler
    {
        private static string ConnectionString; //Stores DB Connection String (to be used to connect to DB)

        //Method for Setting internal Connection String - Used to Connect to DB
        public static void SetConnectionString(string ConnectionString)
        {
            DatabaseHandler.ConnectionString = ConnectionString;
        }

        //Retrieves Account Structure based on Username Provided
        public static Account RetrieveAccountByUsername(string UserName, ILogger logger)
        {
            Account ReturnValue = new Account();

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString)) //Open DB Connection
                {
                    using (SqlCommand command = new SqlCommand("Select [UserID],[UserName],[Password],[DisplayName],[Active] From dbo.[Users] Where [UserName]=@Username;", connection))
                    {
                        command.Parameters.AddWithValue("@Username", UserName); //Use Parameterised Query to Prevent SQL Injection 
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader()) //Open DB Reader
                        {
                            if (reader.Read()) //Found Record - Parse into Account Structure
                            {
                                ReturnValue.UserID = reader.GetInt32(0);
                                ReturnValue.UserName = reader.GetString(1);
                                ReturnValue.Password = reader.GetString(2);
                                ReturnValue.DisplayName = reader.GetString(3);
                                ReturnValue.Active = reader.GetBoolean(4);
                            }
                        }
                    }
                }
            }
            catch (SqlException e) //Exception Occured - Notify User
            {
                logger.LogError(e, "Error during Account By Username Retrieve");
            }

            return ReturnValue; //Return Account Structure
        }

        //Retrieves all Loss Types from DB
        public static LossType[] RetrieveLossTypes(ILogger logger)
        {
            LossType[] ReturnValue = new LossType[127];
            int Count = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString)) //Open DB Connection
                {
                    using (SqlCommand command = new SqlCommand("Select [LossTypeID],[LossTypeCode],[LossTypeDescription] From dbo.[LossTypes];", connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader()) //Open DB Reader
                        {
                            while (reader.Read()) //While more records found, compile array of Loss Types
                            {
                                ReturnValue[Count].LossTypeID = reader.GetInt32(0);
                                ReturnValue[Count].LossTypeCode = reader.GetString(1);
                                ReturnValue[Count].LossTypeDescription = reader.GetString(2);
                                Count += 1;
                                if (Count == ReturnValue.Length) Array.Resize(ref ReturnValue, Count + 128); //Reached End of Array - Resize with 128 more cells than previous
                            }
                        }
                    }
                }

                if (Count == 0) //No Records found - Return Null
                {
                    return null;
                }
                else if (Count < ReturnValue.Length) //Need to Resize Array (Empty Cells)
                {
                    Array.Resize(ref ReturnValue, Count);
                    return ReturnValue;
                }
            }
            catch (SqlException e) //Exception Occured - Notify User
            {
                logger.LogError(e, "Error during Loss Type Retrieve");
            }

            return null;
        }
    }
}
