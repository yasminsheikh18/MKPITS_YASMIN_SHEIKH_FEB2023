using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3
{
   public static class Transaction
    {
        static SqlConnection con = Dbconnection.getConnection();
        static string query = null;
        static SqlCommand cmd = null;

        public static string insertTransaction_Details(int Item_Id,
            DateTime Transaction_Date, int Department_Id,int Quantity)
        {
            string res = null;
            try
            {
                query = "insert into Transaction_Details(Item_Id,Transaction_Date,Department_Id,Quantity) values(@Item_Id,@Transaction_Date,@Department_Id,@Quantity)";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Item_Id", Item_Id);
                cmd.Parameters.AddWithValue("@Transaction_Date",Transaction_Date);
                cmd.Parameters.AddWithValue("@Department_Id", Department_Id);
                //cmd.Parameters.AddWithValue("@Vendor_Name",Vendor_Name);
                cmd.Parameters.AddWithValue("@Quantity", Quantity);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                int bal_qty = 0;
                query = "select Balance_Quantity from Item_Master where Item_Id=@Item_Id ";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Item_Id", Item_Id);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())//dr open
                {
                    bal_qty = Convert.ToInt32(dr[0].ToString());

                }
                dr.Close();//datareader closed
                con.Close();//connection close
                int qty = bal_qty - Quantity;
                query = "update Item_Master set Balance_Quantity=@Balance_Quantity where Item_Id=@Item_Id";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Balance_Quantity", qty);
                cmd.Parameters.AddWithValue("@Item_Id", Item_Id);
                con.Open();
                cmd.ExecuteNonQuery();
                res = "item issued to department successfully";
            }
            catch (Exception ex)
            {
                res = ex.ToString();
            }
            finally { con.Close(); }

            return res;





        }
        public static string insertven_Details(int Item_Id,
           DateTime Transaction_Date, int Vendor_Id, int Quantity)
        {
            string res = null;
            try
            {
                query = "insert into Transaction_Details(Item_Id,Transaction_Date,Department_Id,Quantity) values(@Item_Id,@Transaction_Date,@Department_Id,@Quantity)";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Item_Id", Item_Id);
                cmd.Parameters.AddWithValue("@Transaction_Date", Transaction_Date);
                cmd.Parameters.AddWithValue("@Vendor_Id", Vendor_Id);
                //cmd.Parameters.AddWithValue("@Vendor_Name",Vendor_Name);
                cmd.Parameters.AddWithValue("@Quantity", Quantity);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                int bal_qty = 0;
                query = "select Balance_Quantity from Item_Master where Item_Id=@Item_Id ";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Item_Id", Item_Id);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())//dr open
                {
                    bal_qty = Convert.ToInt32(dr[0].ToString());

                }
                dr.Close();//datareader closed
                con.Close();//connection close
                int qty = bal_qty + Quantity;
                query = "update Item_Master set Balance_Quantity=@Balance_Quantity where Item_Id=@Item_Id";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Balance_Quantity", qty);
                cmd.Parameters.AddWithValue("@Item_Id", Item_Id);
                con.Open();
                cmd.ExecuteNonQuery();
                res = "item issued to department successfully";
            }
            catch (Exception ex)
            {
                res = ex.ToString();
            }
            finally { con.Close(); }

            return res;





        }



    }


}


    

