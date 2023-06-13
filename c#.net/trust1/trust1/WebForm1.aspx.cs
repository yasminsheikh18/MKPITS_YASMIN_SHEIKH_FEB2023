using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Reflection.Emit;

namespace trust1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("server=LAPTOP-ETMMI9QB\\SQLEXPRESS;integrated security=true;database=Trust");
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        string str = null;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            str = "insert into Item_Master values(@Item_Name,@Category,@Balance_Quantity,@rate )";
            SqlCommand command = new SqlCommand(str, con);
            command.Parameters.AddWithValue("@Item_Name", TextBox4.Text);
            command.Parameters.AddWithValue("@Category", (DropDownList1.Text));
            command.Parameters.AddWithValue("@Balance_Quantity", Convert.ToInt32(TextBox1.Text));
            command.Parameters.AddWithValue("@rate", Convert.ToInt32(TextBox3.Text));

            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            Label1.Text = "record saved ";
            TextBox1.Text = "";
            TextBox1.Focus();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            loaddata();
        }
        public void loaddata()
        {
            str = "select * from Item_Master ";
            da = new SqlDataAdapter(str, con);
            da.Fill(ds, "tableitem");
            GridView1.DataSource = ds.Tables["tableitem"].DefaultView;
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            str = "update Item_Master set Item_Name=@Item_Name,Category=@Category,Balance_Quantity=@Balance_Quantity,rate=@rate where Balance_Quantity=@Balance_Quantity";
            SqlCommand command = new SqlCommand(str, con);

            command.Parameters.AddWithValue("@Item_Name", TextBox4.Text);
            command.Parameters.AddWithValue("@Category", (DropDownList1.Text));
            command.Parameters.AddWithValue("@Balance_Quantity", Convert.ToInt32(TextBox1.Text));
            command.Parameters.AddWithValue("@rate", Convert.ToInt32(TextBox3.Text));

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
            str = "delete from Item_Master  where Balance_Quantity=@Balance_Quantity";
            SqlCommand command = new SqlCommand(str, con);


            command.Parameters.AddWithValue("@Balance_Quantity", Convert.ToInt32(TextBox1.Text));

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
            str = "select * from Item_Master where Balance_Quantity=@Balance_Quantity";
            da = new SqlDataAdapter(str, con);
            da.SelectCommand.Parameters.AddWithValue("@Balance_Quantity", Convert.ToInt32(TextBox1.Text));
            da.Fill(ds, "tableitem");

            TextBox4.Text = ds.Tables["tableitem"].Rows[0].ItemArray[1].ToString();
            TextBox1.Text = ds.Tables["tableitem"].Rows[0].ItemArray[2].ToString();
            TextBox3.Text = ds.Tables["tableitem"].Rows[0].ItemArray[3].ToString();

            GridView1.DataSource = ds.Tables["tableitem"].DefaultView;

            GridView1.DataBind();
        }
    }
}