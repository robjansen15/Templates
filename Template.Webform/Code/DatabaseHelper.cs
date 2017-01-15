using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;

namespace Template.Webform.Code
{
    public class DatabaseHelper
    {
        public DatabaseHelper(DatabaseConnection dbConnection)
        {
            DBConnection = dbConnection;
        }

        public void ReadStoredProcedure()
        {            
            DBConnection.Connect();

            try
            {
                SqlDataReader reader = null;
                SqlCommand command = new SqlCommand("procedure here", DBConnection.Connection);
                command.CommandType = CommandType.StoredProcedure;

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    /*Do what you need to do here for reading*/
                }
            }
            catch(Exception e)
            {
                Variables.GetInstance.Log.Print(e.ToString());
            }
          
            DBConnection.Disconnect();
        }


        public void WriteStoredProcedure(string value, string value1)
        {
            DBConnection.Connect();

            try
            {
                SqlCommand command = new SqlCommand("procedure here", DBConnection.Connection);
                command.CommandType = CommandType.StoredProcedure;

                //Add as many parameters as you want
                command.Parameters.Add(new SqlParameter("@param", value));
                command.Parameters.Add(new SqlParameter("@param1", value1));

                command.ExecuteNonQuery();
            }           
            catch(Exception e)
            {
                Variables.GetInstance.Log.Print(e.ToString());
            }

            DBConnection.Disconnect();
        }

        public DatabaseConnection DBConnection { get; set; }
    }
}