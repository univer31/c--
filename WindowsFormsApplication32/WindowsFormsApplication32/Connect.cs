using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;


namespace WindowsFormsApplication32
{
    class Connect
    {
        public static string getconStr()
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = "DESKTOP-CHKORO1\\SQLEXPRESS";
            scsb.InitialCatalog = "assign";
            scsb.UserID = "sa";
            scsb.Password = "14778522508g";
            return scsb.ConnectionString;
        }
    }
}
