using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace storelibrary
{
    internal static class Dbconnection
    {
        public static SqlConnection con;
        public static SqlConnection getConnection()
        {
            con = new SqlConnection("server=LAPTOP-ETMMI9QB\\SQLEXPRESS;integrated security=true;database=Trust");

            return con;
        }
    }
}
