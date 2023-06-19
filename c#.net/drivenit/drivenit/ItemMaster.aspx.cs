using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace drivenit
{
    public partial class ItemMaster : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("server=LAPTOP-ETMMI9QB\\SQLEXPRESS;integrated security=true;database=drivenitdb");
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        string str = null;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            str = "insert into ItemMaster values(@ItemDescr,@BalQty,@CreatedOn )";
            SqlCommand command = new SqlCommand(str, con);
            command.Parameters.AddWithValue("@ItemDescr", TextBox1.Text);  
            command.Parameters.AddWithValue("@BalQty", Convert.ToInt32(TextBox2.Text));
            command.Parameters.AddWithValue("CreatedOn", TextBox3.Text);

            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            Label1.Text = "record saved ";
            TextBox1.Text = "";
            TextBox1.Focus();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            str = "update ItemMaster set ItemDescr=@ItemDescr,BalQty=@BalQty,CreatedOn=@CreatedOn where ItemID=@ItemID";
            SqlCommand command = new SqlCommand(str, con);
            command.Parameters.AddWithValue("@ItemDescr", TextBox1.Text);
            command.Parameters.AddWithValue("@BalQty", Convert.ToInt32(TextBox2.Text));
            command.Parameters.AddWithValue("CreatedOn", TextBox3.Text);
            command.Parameters.AddWithValue("ItemId", Convert.ToInt32(TextBox4.Text));




            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            Label1.Text = "record updated ";
            TextBox1.Text = "";
            TextBox1.Focus();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            str = "delete from ItemMaster  where ItemID=@ItemID";
            SqlCommand command = new SqlCommand(str, con);
            //command.Parameters.AddWithValue("@ItemDescr", TextBox1.Text);
            //command.Parameters.AddWithValue("@BalQty", Convert.ToInt32(TextBox2.Text));
            //command.Parameters.AddWithValue("CreatedOn", TextBox3.Text);
            command.Parameters.AddWithValue("ItemId", Convert.ToInt32(TextBox4.Text));


            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            Label1.Text = "record deleted ";

        }
    }
}