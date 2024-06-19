using HNAMDotNet.ConsoleApp.AdoDotNetExamples.Common;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HNAMDotNet.ConsoleApp.AdoDotNetExamples
{
    public class AdoDotNetExamples
    {
        private readonly SqlConnectionStringBuilder _sqlConnectionStringBuilder = new SqlConnectionStringBuilder()
        {
            DataSource = "LAPTOP\\SQLSERVER",
            InitialCatalog = "DotNetTraning",
            UserID = "sa",
            Password = "sa@123",
            TrustServerCertificate = true
        };

        public void Read()
        {
            try
            {
                SqlConnection _sqlConnection = new SqlConnection(_sqlConnectionStringBuilder.ConnectionString);
                _sqlConnection.Open();
                Console.WriteLine("Connection Open");

                string query = ProcedureConstants.SP_GetAllBlog;
                SqlCommand cmd = new SqlCommand(query, _sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);

                _sqlConnection.Close();
                Console.WriteLine("Connection Close");

                foreach (DataRow dr in dt.Rows)
                {
                    Console.WriteLine("BlogId ==> " + dr["BlogId"]);
                    Console.WriteLine("BlogTitle ==> " + dr["BlogTitle"]);
                    Console.WriteLine("BlogAuthor ==> " + dr["BlogAuthor"]);
                    Console.WriteLine("BlogContent ==> " + dr["BlogContent"]);
                    Console.WriteLine("---------------------------------------------------");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void GetBlogDataById(int BlogId)
        {
            try
            {
                SqlConnection _sqlConnection = new SqlConnection(_sqlConnectionStringBuilder.ConnectionString);
                _sqlConnection.Open();
                Console.WriteLine("Connection Open");
                string query = "SP_GetAllBlogById";
                SqlCommand cmd = new SqlCommand(query, _sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BlogId", BlogId);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);

                _sqlConnection.Close();
                Console.WriteLine("Connection Close");
                Console.WriteLine("BlogId==> " + dt.Rows[0]["Blogid"]);
                Console.WriteLine("BlogTitle==> " + dt.Rows[0]["BlogTitle"]);
                Console.WriteLine("BlogAuthor==> " + dt.Rows[0]["BlogAuthor"]);
                Console.WriteLine("BlogContent==> " + dt.Rows[0]["BlogContent"]);
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
        }

        public void Update(int BlogId, string BlogTitle, string BlogContent)
        {
            try
            {
                SqlConnection _sqlConnection = new SqlConnection(_sqlConnectionStringBuilder.ConnectionString);
                _sqlConnection.Open();
                Console.WriteLine("Connection Open");
                string query = ProcedureConstants.SP_UpdateBlogById;
                SqlCommand cmd = new SqlCommand(query, _sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BlogId", BlogId);
                cmd.Parameters.AddWithValue("@BlogTitle", BlogTitle);
                cmd.Parameters.AddWithValue("@BlogContent", BlogContent);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);

                _sqlConnection.Close();
                Console.WriteLine("Connection Close");
                Console.WriteLine("BlogId==> " + dt.Rows[0]["Blogid"]);
                Console.WriteLine("BlogTitle==> " + dt.Rows[0]["BlogTitle"]);
                Console.WriteLine("BlogAuthor==> " + dt.Rows[0]["BlogAuthor"]);
                Console.WriteLine("BlogContent==> " + dt.Rows[0]["BlogContent"]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Delete(int BlogId)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(_sqlConnectionStringBuilder.ConnectionString);
                sqlConnection.Open();

                string query = ProcedureConstants.SP_DeleteBlogById;
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BlogId", BlogId);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Delete Success");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void Create(string BlogTitle, string BlogAuthor, string BlogContent)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(_sqlConnectionStringBuilder.ConnectionString);
                sqlConnection.Open();

                string query = ProcedureConstants.SP_InsertBlog;
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BlogTitle", BlogTitle);
                cmd.Parameters.AddWithValue("@BlogAuthor", BlogAuthor);
                cmd.Parameters.AddWithValue("@BlogContent", BlogContent);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Insert Successful");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
