using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ClassLibrary3
{
    public static class Item

    {
        static SqlConnection con = Dbconnection.getConnection();
        static string query = null;
        static SqlCommand cmd = null;
        //method to insert record in item table
        public static string insertItem_Master(string Item_Name,
            string Category, int Balance_Quantity, int rate)
        {
            string res = null;
            try
            {
                query = "insert into Item_Master values(@Item_Name,@Category,@Balance_Quantity,@rate)";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Item_Name",Item_Name);
                cmd.Parameters.AddWithValue("@Category", Category);
                cmd.Parameters.AddWithValue("@Balance_Quantity", Balance_Quantity);
                cmd.Parameters.AddWithValue("@rate", rate);


                con.Open();
                cmd.ExecuteNonQuery();

                res = "record saved in Item master successfully";
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
        public static string getItem_Id()
        {
            string res = null;
            try
            {
                query = "select max(Item_Id) from Item_Master";

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
        public static string updateItem_Master(string Item_Name,
             int Balance_Quantity)
        {
            string res = null;

            //checking whether vendorid exists or not
            query = "select count(*) from Item_Master where Item_Name=@Item_Name";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Item_Name", Item_Name);
            con.Open();
            int cnt = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();

            if (cnt > 0)
            {

                try

                {
                    query = "update Item_Master set Balance_Quantity=@Balance_Quantity where Item_Name=@Item_Name";
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Balance_Quantity", Balance_Quantity);
                    cmd.Parameters.AddWithValue("@Item_Name", Item_Name);
                    con.Open();
                    cmd.ExecuteNonQuery();

                    res = "record updated in item master successfully";
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

        public static string deleteItem_Master(string Item_Name)
        {
            string res = null;

            //checking whether vendorid exists or not
            query = "select count(*) from Item_Master where Item_Name=@Item_Name";
            cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Item_Name", Item_Name);
            con.Open();
            int cnt = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();

            if (cnt > 0)
            {

                try
                {
                    query = "delete from Item_Master where Item_Name=@Item_Name";
                    cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@Item_Name", Item_Name);
                    con.Open();
                    cmd.ExecuteNonQuery();

                    res = "record deleted in item master successfully";
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

        public static DataSet searchItem_Master(string Item_Name)
        {

            query = "select * from Item_Master where Item_Name=@Item_Name";

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@Item_Name", Item_Name);
            da.Fill(ds, "Item_Master");
            return ds;

        }


    }

}
