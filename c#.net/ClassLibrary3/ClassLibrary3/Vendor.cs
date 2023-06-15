using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ClassLibrary3
{
    public static class Vendor
    {
        static SqlConnection con = Dbconnection.getConnection();
        static string query = null;
        static SqlCommand cmd = null;
        //method to insert record in vendor table
        public static string insertVendor_Master(string Vendor_Name)
        {
            string res = null;
            try
            {
                query = "insert into Vendor_Master values(@Vendor_Name)";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Vendor_Name", Vendor_Name);
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
        //method to return vendor_id
        public static string getVendor_Id()
        {
            string res = null;
            try
            {
                query = "select max(Vendor_Id) from Vendor_Master";

                cmd = new SqlCommand(query, con);
                con.Open();
                int vid = Convert.ToInt32(cmd.ExecuteScalar());

                res = vid.ToString();
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
        //method to update record in vendor table
        public static string updateVendor_Master(string Vendor_Name, int Vendor_Id)
        {
            string res = null;

            //checking whether vendorid exists or not
            query = "select count(*) from Vendor_Master where Vendor_Id=@Vendor_Id";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Vendor_Id", Vendor_Id);
            con.Open();
            int cnt = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();

            if (cnt > 0)
            {

                try

                {
                    query = "update Vendor_Master set Vendor_Name=@Vendor_Name where Vendor_Id=@Vendor_Id";
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Vendor_Name", Vendor_Name);
                    cmd.Parameters.AddWithValue("@Vendor_Id", Vendor_Id);
                    con.Open();
                    cmd.ExecuteNonQuery();

                    res = "record updated in vendor master successfully";
                }
                catch (Exception ex)
                {
                    res = ex.ToString();
                }
                finally
                {
                    con.Close();

                }

            }
            else
            {
                res = "no record exist ";
            }
            return res;
        }

        //method to delete record in vendor master

        public static string deleteVendor_Master(int Vendor_Id)
        {
            string res = null;

            //checking whether vendorid exists or not
            query = "select count(*) from Vendor_Master where Vendor_Id=@Vendor_Id";
            cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Vendor_Id", Vendor_Id);
            con.Open();
            int cnt = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();

            if (cnt > 0)
            {

                try
                {
                    query = "delete from Vendor_Master where Vendor_Id=@Vendor_Id";
                    cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@Vendor_Id", Vendor_Id);
                    con.Open();
                    cmd.ExecuteNonQuery();

                    res = "record deleted in vendor master successfully";
                }
                catch (Exception ex)
                {
                    res = ex.ToString();
                }
                finally
                {
                    con.Close();

                }

            }
            else
            {
                res = "no record exist ";
            }
            return res;
        }

        //method to search record in vendor master

        public static DataSet searcVendor_Master(int Vendor_Id)
        {

            query = "select * from Vendor_Master where Vendor_Id=@Vendor_Id";

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@Vendor_Id", Vendor_Id);
            da.Fill(ds, "Vendor_Master");
            return ds;

        }
    }
}
