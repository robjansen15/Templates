using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Template.Webform.Code
{
    public class DatabaseConnection
    {
        public DatabaseConnection(string databaseConfigString)
        {
            Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        }


        public void Connect()
        {
            try
            {
                Connection.Open();
            }
            catch(Exception e)
            {
                Variables.GetInstance.Log.Print(e.ToString());
            }
        }


        public void Disconnect()
        {
            try
            {
                Connection.Close();
            }
            catch (Exception e)
            {
                Variables.GetInstance.Log.Print(e.ToString());
            }
        }


        public SqlConnection Connection { get; private set; }
    }
}