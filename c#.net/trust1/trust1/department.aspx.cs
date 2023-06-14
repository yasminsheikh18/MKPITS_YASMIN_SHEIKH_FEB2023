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
    public partial class department : System.Web.UI.Page
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
            str = "select * from Department_Master ";
            da = new SqlDataAdapter(str, con);
            da.Fill(ds, "tableitem");
            GridView1.DataSource = ds.Tables["tableitem"].DefaultView;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            str = "insert into Department_Master values(@Department_Name )";
            SqlCommand command = new SqlCommand(str, con);
            ;
            command.Parameters.AddWithValue("@Department_Name ",TextBox1.Text);

            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            Label1.Text = "record saved ";
            TextBox1.Text = "";
            TextBox1.Focus();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            str = "update Department_Master set Department_Name=@Department_Name  where Department_Id=@Department_Id";
            SqlCommand command = new SqlCommand(str, con);

            
            command.Parameters.AddWithValue("@Department_Name",TextBox1.Text);
            command.Parameters.AddWithValue("@Department_Id",Convert.ToInt32( TextBox2.Text));
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
            str = "delete from Department_Master  where Department_Name=@Department_Name";
            SqlCommand command = new SqlCommand(str, con);


            command.Parameters.AddWithValue("@Department_Name", (TextBox1.Text));

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
            str = "select * from Department_Master where Department_Name=@Department_Name";
            da = new SqlDataAdapter(str, con);
            da.SelectCommand.Parameters.AddWithValue("@Department_Name", TextBox1.Text);
            da.Fill(ds, "tableitem");

            
            TextBox1.Text = ds.Tables["tableitem"].Rows[0].ItemArray[1].ToString();
            //TextBox2.Text = ds.Tables["tableitem"].Rows[0].ItemArray[2].ToString();

            GridView1.DataSource = ds.Tables["tableitem"].DefaultView;

            GridView1.DataBind();
        }
    }
}