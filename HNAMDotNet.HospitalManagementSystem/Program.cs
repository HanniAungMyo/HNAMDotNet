using HNAMDotNet.HospitalManagementSystem.Common;
using HNAMDotNet.HospitalManagementSystem.UI.Configuration;
using HNAMDotNet.HospitalManagementSystem.UI.Entry;

namespace HNAMDotNet.HospitalManagementSystem
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            DbConnector.ConnectionString = @"Data Source =LAPTOP\SQLSERVER;Initial Catalog =HMS;User ID =sa;Password =sa@123;TrustServerCertificate = true";
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmSpeciality());
        }
    }
}