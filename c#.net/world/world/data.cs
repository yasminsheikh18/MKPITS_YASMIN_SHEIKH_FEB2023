using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace world
{
    internal class data
    {
            private static string connectionstring = "server=LAPTOP-ETMMI9QB\\SQLEXPRESS;integrated security=true;database=assignment;";
            public static SqlConnection GetConnection()
            {
                SqlConnection con = new SqlConnection(connectionstring);
                try
                {
                    con.Open();
                    return con;
                }
                catch
                {
                    return null;
                }



            }
            public static DataSet getcountry()
            {
                SqlConnection con = GetConnection();
                string query = "select * from country";
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(ds, "tablecountry");
                return ds;
            }
            public static DataSet getstate(string country)
            {
                SqlConnection con = GetConnection();
            string query = "select admin_name from sheet1$ where country=@country ";
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@country", country);
                da.Fill(ds, "tablestate");
                return ds;
            }

            public static DataSet getcity(string admin_name)
            {
                SqlConnection con = GetConnection();
            string query = " select city from sheet1$ where admin_name=@admin_name";
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@admin_name", admin_name);
                da.Fill(ds, "tablecity");
                return ds;
            }
        }
    }


