using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace drivenit
{
    public partial class Transaction : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("server=LAPTOP-ETMMI9QB\\SQLEXPRESS;integrated security=true;database=drivenitdb");
        SqlCommand command = null;
        string query = null;
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                query = "insert into Transactions values(@ItemID,@TransType,@TransQty,@TransDate)";
                command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@ItemID", DropDownList1.SelectedValue);
                string transt = null;
                if (RadioButton1.Checked)
                {
                    transt = "I";
                }
                else if (RadioButton2.Checked)
                {
                    transt = "R";
                }
                command.Parameters.AddWithValue("@TransType", transt);
                command.Parameters.AddWithValue("@TransQty", Convert.ToInt32(TextBox1.Text));
                command.Parameters.AddWithValue("@TransDate", TextBox2.Text);
                con.Open();
                command.ExecuteNonQuery();

               // getting the balqty from itemmaster table for particular item id
                query = "select max(BaLQty) from ItemMaster where ItemID=@ItemID";
                command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@ItemID", DropDownList1.SelectedValue);
                int bq = Convert.ToInt32(command.ExecuteScalar());
                if (transt == "I")
                {
                    bq = bq - Convert.ToInt32(TextBox1.Text);
                }
                else if (transt == "R")
                {
                    bq = bq + Convert.ToInt32(TextBox1.Text);
                }

               // updating bal qty on item master table
                query = "update ItemMaster set BalQty=@BalQty where ItemID=@ItemID";
                command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@BalQty", bq);
                command.Parameters.AddWithValue("@ItemID", DropDownList1.SelectedValue);
                command.ExecuteNonQuery();

                Label1.Text = "record saved";
            }
            catch (Exception ex)
            {

                Label1.Text = ex.ToString();
            }
            finally
            {
                con.Close();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                query = "update Transactions set TransType=@TransType,TransQty=@TransQty,TransDate=@TransDate where ItemID = @ItemID";
                command = new SqlCommand(query, con);

                string transt = null;
                if (RadioButton1.Checked)
                {
                    transt = "I";
                }
                else if (RadioButton2.Checked)
                {

                    transt = "R";
                }
                command.Parameters.AddWithValue("@TransType", transt);
                command.Parameters.AddWithValue("@TransQty", Convert.ToInt32(TextBox1.Text));
                command.Parameters.AddWithValue("@TransDate", TextBox2.Text);
                command.Parameters.AddWithValue("@ItemID", DropDownList1.SelectedValue);
                con.Open();
                command.ExecuteNonQuery();

                //getting the balqty from itemmaster table for particular item id
                query = "select max(BalQty) from ItemMaster where ItemID=@ItemID";
                command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@ItemID", DropDownList1.SelectedValue);
                int bq = Convert.ToInt32(command.ExecuteScalar());
                if (transt == "I")
                {
                    bq = bq - Convert.ToInt32(TextBox1.Text);
                }
                else if (transt == "R")
                {
                    bq = bq + Convert.ToInt32(TextBox1.Text);
                }

                //updating bal qty on item master table
                query = "update ItemMaster set BalQty=@BalQty where ItemID=@ItemID";
                command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@BalQty", bq);
                command.Parameters.AddWithValue("@ItemID", DropDownList1.SelectedValue);
                command.ExecuteNonQuery();

                Label1.Text = "record updated successfully";
            }
            catch (Exception ex)
            {

                Label1.Text = ex.ToString();
            }

            finally
            {
                con.Close();
            }

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox1.Text = GridView1.SelectedRow.Cells[4].Text;

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
           query = "delete from Transactions where ItemID=@ItemID";
            SqlCommand command = new SqlCommand(query, con);


            command.Parameters.AddWithValue("ItemID", DropDownList1.SelectedValue);

            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            Label1.Text = "record deleted ";
            TextBox1.Text = "";
            TextBox1.Focus();
            
        }
    }
}