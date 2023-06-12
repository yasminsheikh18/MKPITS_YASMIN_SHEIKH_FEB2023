using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ADOex_2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("server=LAPTOP-ETMMI9QB\\SQLEXPRESS;integrated security=true;database=Productstore");
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        string str = null;
        protected void Page_Load(object sender, EventArgs e)
        { 

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        public void loaddata()
        {
            str = "select * from tableproduct";
            da = new SqlDataAdapter(str, con);
            da.Fill(ds, "tableproduct");
            GridView1.DataSource = ds.Tables["tableproduct"].DefaultView;
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            str = "insert into tableproduct values(@productid,@producttypeid,@product_name,@prices)";
            SqlCommand command = new SqlCommand(str, con);
            command.Parameters.AddWithValue("@productid", Convert.ToInt32(TextBox1.Text));
            command.Parameters.AddWithValue("@producttypeid", Convert.ToInt32(TextBox2.Text));
            command.Parameters.AddWithValue("@product_name", TextBox3.Text);
            command.Parameters.AddWithValue("@prices", Convert.ToInt32(TextBox4.Text));

            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            Label1.Text = "record saved ";
            TextBox1.Text = "";
            TextBox1.Focus();
             loaddata();
            clearall();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            str = "update tableproduct set ProductTypelD=@producttypeid,Product_Name=@product_name,prices=@prices where ProductlD=@productid";
            SqlCommand command = new SqlCommand(str, con);

            command.Parameters.AddWithValue("@producttypeid", Convert.ToInt32(TextBox2.Text));
            command.Parameters.AddWithValue("@product_name", TextBox3.Text);
            command.Parameters.AddWithValue("@prices", Convert.ToInt32(TextBox4.Text));
            command.Parameters.AddWithValue("@productid", Convert.ToInt32(TextBox1.Text));

            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            Label1.Text = "record updated ";
            TextBox1.Text = "";
            TextBox1.Focus();
            loaddata();
            clearall();

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            str = "delete from tableproduct  where  ProductlD=@productid";
            SqlCommand command = new SqlCommand(str, con);


            command.Parameters.AddWithValue("@productid", Convert.ToInt32(TextBox1.Text));

            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            Label1.Text = "record deleted ";
            TextBox1.Text = "";
            TextBox1.Focus();
            loaddata();

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            str = "select * from tableproduct where ProductlD=@productid";
            da = new SqlDataAdapter(str, con);
            da.SelectCommand.Parameters.AddWithValue("@productid", Convert.ToInt32(TextBox1.Text));
            da.Fill(ds, "tableproduct");

            TextBox2.Text = ds.Tables["tableproduct"].Rows[0].ItemArray[1].ToString();
            TextBox3.Text = ds.Tables["tableproduct"].Rows[0].ItemArray[2].ToString();
            TextBox4.Text = ds.Tables["tableproduct"].Rows[0].ItemArray[3].ToString();

            GridView1.DataSource = ds.Tables["tableproduct"].DefaultView;

            GridView1.DataBind();

        }

        public void clearall()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";

        
        }

    }  
}