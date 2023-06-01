﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fendalproject
{
    public static class productstore
    {
        private static string connectionstring = "server=LAPTOP-ETMMI9QB\\SQLEXPRESS;integrated security=true;database=Productstore;";
        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection(connectionstring);
            try
            {
                con.Open();
                return con;
            }
            catch { return null; }



        }
        public static DataSet Getcategory()
        {
            SqlConnection con = GetConnection();
            string query = "select Product_Type_Name from TableProductCategory";
            DataSet ds = new DataSet();
            SqlDataAdapter da= new SqlDataAdapter(query, con);
            da.Fill(ds, "Product_Type_Name");
            return ds;
        }
        public static DataSet Getproduct( string Product_Type_Name)
        {
            SqlConnection con = GetConnection();
            string query = "select p.Product_Name from TableProduct p inner join TableProductCategory c on c.Product_Category_ID=p.ProductTypelD where Product_Type_Name=@Product_Type_Name";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@Product_Type_Name", Product_Type_Name);
            da.Fill(ds, "TableProdut");
            return ds;
        }
        public static DataSet Getprice(string Product_Type_Name)
        {
            SqlConnection con = GetConnection();
            string query = "select prices from TableProduct where Product_Type_Name=@Product_Type_Name";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@Product_Type_Name", Product_Type_Name);
            da.Fill(ds, "TableProdut");
            return ds;
        }
    } 
}
