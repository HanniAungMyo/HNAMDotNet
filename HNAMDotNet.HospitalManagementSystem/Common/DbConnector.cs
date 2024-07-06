using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HNAMDotNet.HospitalManagementSystem.Common
{
    public class DbConnector
    {
        public static string ConnectionString = "";

        public static SqlConnection con = null;

        public DbConnector(string cs) 
        {
            con= new SqlConnection(cs); 
        }    

        public static SqlConnection Connect()
        {
            try
            {
                if (con != null)
                {
                    con.Close();
                    con = null;
                }
                if (con == null)
                    con = new SqlConnection(ConnectionString);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                return con;
            }

            catch (Exception ex)
            {
            }
            return null;
        }
    }
}
