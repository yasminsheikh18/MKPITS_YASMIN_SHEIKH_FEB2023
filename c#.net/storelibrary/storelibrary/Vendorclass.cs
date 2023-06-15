using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace storelibrary
{
    public static class Vendorclass
    {
        static SqlConnection con = DbConnection.GetConnection();
        static string query = null;
        static SqlCommand cmd = null;
        //method to insert record in vendor table
        public static string insertVendor_Master(string vendor_name)
        {
            string res = null;
            try
            {
                query = "insert into Vendor_Master values(@Vendor_Name)";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Vendor_Name", vendor_name);
                con.Open();
                cmd.ExecuteNonQuery();

                res = "record saved in vendor master successfully";
            }
            catch (Exception ex)
            {
                res = ex.ToString();
            }
            finally
            {
                con.Close();

            }
            return res;
        }
    }
}
