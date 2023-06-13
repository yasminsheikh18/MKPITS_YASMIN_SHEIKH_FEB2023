using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace trust1
{
    public partial class vendor : System.Web.UI.Page
    {

        SqlConnection con = new SqlConnection("server=LAPTOP-ETMMI9QB\\SQLEXPRESS;integrated security=true;database=Trust");
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        string str = null;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            loaddata();
        }
        public void loaddata()
        {
            str = "select * from Vendor_Master ";
            da = new SqlDataAdapter(str, con);
            da.Fill(ds, "tableitem");
            GridView1.DataSource = ds.Tables["tableitem"].DefaultView;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            str = "insert into Vendor_Master values(@Vendor_Name )";
            SqlCommand command = new SqlCommand(str, con);
            ;
            command.Parameters.AddWithValue("@Vendor_Name ", TextBox1.Text);

            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            Label1.Text = "record saved ";
            TextBox1.Text = "";
            TextBox1.Focus();
            loaddata();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            str = "update Vendor_Master set Vendor_Name=@Vendor_Name  where Vendor_Id=@Vendor_Id";
            SqlCommand command = new SqlCommand(str, con);


            command.Parameters.AddWithValue("@Vendor_Name", TextBox1.Text);

            command.Parameters.AddWithValue("@Vendor_Id",Convert.ToInt32( TextBox2.Text));

            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            Label1.Text = "record updated ";
            TextBox1.Text = "";
            TextBox1.Focus();
            loaddata();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            str = "delete from Vendor_Master  where Vendor_Name=@Vendor_Name";
            SqlCommand command = new SqlCommand(str, con);


            command.Parameters.AddWithValue("@Vendor_Name", (TextBox1.Text));

            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            Label1.Text = "record deleted ";
            TextBox1.Text = "";
            TextBox1.Focus();
            loaddata();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            str = "select * from Vendor_Master where Vendor_Name=@Vendor_Name";
            da = new SqlDataAdapter(str, con);
            da.SelectCommand.Parameters.AddWithValue("@Vendor_Name", TextBox1.Text);
            da.Fill(ds, "tableitem");


            TextBox1.Text = ds.Tables["tableitem"].Rows[0].ItemArray[1].ToString();

            GridView1.DataSource = ds.Tables["tableitem"].DefaultView;

            GridView1.DataBind();
        }
    }
}