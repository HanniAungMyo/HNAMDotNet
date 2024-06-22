using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HNAMDotNet.ConsoleApp.AdoDotNetExamples
{
    public class DbConnector
    {
        public static string ConnectionString = " DataSource = 'LAPTOP\\SQLSERVER',InitialCatalog = 'DotNetTraning',UserID = 'sa',Password = 'sa@123',TrustServerCertificate = true";
        SqlConnection _sqlConnection = null;

        public DbConnector(string connectionString)
        {
            _sqlConnection = new SqlConnection(connectionString);
        }
    }
}
