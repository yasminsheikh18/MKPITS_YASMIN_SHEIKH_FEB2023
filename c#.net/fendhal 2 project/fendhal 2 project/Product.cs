using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fendhal_2_project
{
    public static class Product
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
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(ds, "Product_Type_Name");
            return ds;
        }

        //2nd fill product name
        public static DataSet Getproduct(string Product_Type_Name)
        {
            SqlConnection con = GetConnection();
            string query = "select p.Product_Name from TableProduct p inner join TableProductCategory c on c.Product_Category_ID=p.ProductTypelD where Product_Type_Name=@Product_Type_Name";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@Product_Type_Name", Product_Type_Name);
            da.Fill(ds, "TableProduct");
            return ds;
        }

        public static DataSet Getprice(string Product_Name)
        {
            SqlConnection con = GetConnection();
            string query = "select prices from TableProduct where Product_Name=@Product_Name";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@Product_Name", Product_Name);
            da.Fill(ds, "TableProduct");
            return ds;
        }

        public static DataSet Getgst(string Product_Type_Name)
        {
            SqlConnection con = GetConnection();
            string query = "select a.cgst,a.sgst,a.igst from TableProductGSTDetails a inner join TableProductCategory b on\r\na.Product_Gst_ID=b.Product_Gst_ID where b.Product_Type_Name=@Product_Type_Name";
            DataSet ds1 = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@Product_Type_Name", Product_Type_Name);
            da.Fill(ds1, "TableProdut");
            return ds1;
        }


    }
}
