using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace trust1
{
    public partial class Transaction : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (RadioButton1.Checked)
            {
                Panel2.Visible = false;
            }

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton1.Checked)
            {
                Panel2.Visible = false;
                Panel1.Visible = true;
            }

        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton2.Checked)
            {
                Panel1.Visible = false;
                Panel2.Visible = true;
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string query = null;
            SqlConnection con = new SqlConnection("server=LAPTOP-ETMMI9QB\\SQLEXPRESS;integrated security=true;database=Trust");
            SqlCommand command;
            if (RadioButton1.Checked)
            {
                try
                {
                    query = "insert into Transaction_Details(Item_Id,Transaction_Date,Department_Id,Quantity) values(@Item_Id,@Transaction_Date,@Department_Id,@Quantity)";
                    command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@Item_id", DropDownList1.SelectedValue);
                    command.Parameters.AddWithValue("@Transaction_Date", TextBox1.Text);
                    command.Parameters.AddWithValue("@Department_Id", DropDownList2.SelectedValue);
                    command.Parameters.AddWithValue("@Quantity", TextBox2.Text);
                    con.Open();
                    command.ExecuteNonQuery();
                    con.Close();

                    //code to get balance_quantity from item_master table
                    int bal_qty = 0;
                    query = "select Balance_Quantity from Item_Master where Item_Id=@Item_Id";
                    command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@Item_Id", DropDownList1.SelectedValue);
                    con.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        bal_qty = Convert.ToInt32(reader[0].ToString());
                    }
                    reader.Close();
                    con.Close();
                    Response.Write("bal qty " + bal_qty.ToString());
                    int qty = bal_qty - Convert.ToInt32(TextBox2.Text);

                    query = "update Item_Master set Balance_Quantity=@Balance_Quantity where Item_Id=@Item_Id";

                    command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@Balance_Quantity", qty);
                    command.Parameters.AddWithValue("@Item_Id", DropDownList1.SelectedValue);
                    con.Open();
                    command.ExecuteNonQuery();
                    //con.Close();
                    Label1.Text = "item issued to department successfully";


                }
                catch (Exception ee)
                {
                    Label1.Text = ee.ToString();
                }
                finally
                {
                    con.Close();
                }

            }
            else if (RadioButton2.Checked)
            {
                try
                {
                    query = "insert into Transaction_Details(Item_Id,Transaction_Date,Vendor_Id,Quantity) values(@Item_Id,@Transaction_Date,@Vendor_Id,@Quantity)";
                    command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@Item_id", DropDownList1.SelectedValue);
                    command.Parameters.AddWithValue("@Transaction_Date", TextBox1.Text);
                    command.Parameters.AddWithValue("@Vendor_Id", DropDownList3.SelectedValue);
                    command.Parameters.AddWithValue("@Quantity", TextBox2.Text);
                    con.Open();
                    command.ExecuteNonQuery();
                    con.Close();

                    //code to get balance_quantity from item_master table
                    int bal_qty = 0;
                    query = "select Balance_Quantity from Item_Master where Item_Id=@Item_Id";
                    command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@Item_Id", DropDownList1.SelectedValue);
                    con.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        bal_qty = Convert.ToInt32(reader[0].ToString());
                    }
                    reader.Close();
                    con.Close();
                    Response.Write("bal qty " + bal_qty.ToString());
                    int qty = bal_qty + Convert.ToInt32(TextBox2.Text);

                    query = "update Item_Master set Balance_Quantity=@Balance_Quantity where Item_Id=@Item_Id";

                    command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@Balance_Quantity", qty);
                    command.Parameters.AddWithValue("@Item_Id", DropDownList1.SelectedValue);
                    con.Open();
                    command.ExecuteNonQuery();
                    //con.Close();
                    Label1.Text = "item issued to Vendor successfully";


                }
                catch (Exception ee)
                {
                    Label1.Text = ee.ToString();
                }
                finally
                {
                    con.Close();
                }


            }

        }
    }
}