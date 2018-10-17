using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DemoProject
{
    class DatabaseConnectionClass
    {

        private SqlConnection myConnection;
        private SqlCommand myCommand;

        public DatabaseConnectionClass()
        {
            try
            {
                // Build connection string
                string con = "Data Source=DESKTOP-GFHHCHP\\SQLEXPRESS;Initial Catalog=\"Fariha's School\";Persist Security Info=True;User ID=sa;Password=12345";
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = con; 
                builder.UserID = "sa";              // update me
                builder.Password = "12345";      // update me
                builder.InitialCatalog = "master";

                // Connect to SQL
                
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                }
            }
            catch (SqlException e)
            {
                
            }

        }

        public void ConnectWithDB()
        {
            myConnection.Open();
        }
        public void CloseConnection()
        {
            myConnection.Close();
        }

        public SqlDataReader GetData(string query)
        {
            myCommand = new SqlCommand(query, myConnection);
            //SqlDataReader sdr = myCommand.ExecuteReader();
            //return sdr;
            return myCommand.ExecuteReader();
        }
        public int ExecuteSQL(string query)
        {
            myCommand = new SqlCommand(query, myConnection);
            //int x= myCommand.ExecuteNonQuery();
            //return x;
            return myCommand.ExecuteNonQuery();
        }
    }
}
