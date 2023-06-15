using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ClassLibrary3
{
    public static class Department1
    {
        static SqlConnection con = Dbconnection.getConnection();
        static string query = null;
        static SqlCommand cmd = null;
        //method to insert record in Department table
        public static string insertDepartment_Master(string Department_Name)
        {
            string res = null;
            try
            {
                query = "insert into Department_Master values(@Department_Name)";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Department_Name", Department_Name);
                con.Open();
                cmd.ExecuteNonQuery();

                res = "record saved in Department master successfully";
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
        public static string getDepartment_Id()
        {
            string res = null;
            try
            {
                query = "select max(Department_Id) from Department_Master";

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
        public static string updateDepartment_Master(string Department_Name, int Department_Id)
        {
            string res = null;

            //checking whether vendorid exists or not
            query = "select count(*) from Department_Master where Department_Id=@Department_Id";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Department_Id", Department_Id);
            con.Open();
            int cnt = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();

            if (cnt > 0)
            {

                try

                {
                    query = "update Department_Master set Department_Name=@Department_Name where Department_Id=@Department_Id";
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Department_Name", Department_Name);
                    cmd.Parameters.AddWithValue("@Department_Id", Department_Id);
                    con.Open();
                    cmd.ExecuteNonQuery();

                    res = "record updated in Department master successfully";
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

        public static string deleteDepartment_Master(int Department_Id)
        {
            string res = null;

            //checking whether vendorid exists or not
            query = "select count(*) from Department_Master where Department_Id=@Department_Id";
            cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Department_Id", Department_Id);
            con.Open();
            int cnt = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();

            if (cnt > 0)
            {

                try
                {
                    query = "delete from Department_Master where Department_Id=@Department_Id";
                    cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@Department_Id", Department_Id);
                    con.Open();
                    cmd.ExecuteNonQuery();

                    res = "record deleted in Department master successfully";
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

        public static DataSet searchDepartment_Master(int Department_Id)
        {
        

            query = "select * from Department_Master where Department_Id=@Department_Id";

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@Department_Id", Department_Id);
            da.Fill(ds, "Department_Master");
            return ds;

        }
    }
}
