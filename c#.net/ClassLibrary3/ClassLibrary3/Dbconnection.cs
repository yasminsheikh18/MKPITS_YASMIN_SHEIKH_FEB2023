using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ClassLibrary3
{
    public static class Dbconnection
    {
        public static SqlConnection con;
        public static SqlConnection getConnection()
        {
            con = new SqlConnection("server=LAPTOP-ETMMI9QB\\SQLEXPRESS;integrated security=true;database=Trust");

            return con;
        }
    }
}
