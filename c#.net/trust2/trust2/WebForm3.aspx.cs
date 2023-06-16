using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace trust2
{
    public partial class WebForm3 : System.Web.UI.Page
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

        protected void Button1_Click1(object sender, EventArgs e)
        {
            if (RadioButton1.Checked)
            {


                string res = ClassLibrary3.Transaction.insertTransaction_Details(Convert.ToInt32(DropDownList1.Text), DateTime.Now,
                    Convert.ToInt32(DropDownList2.Text), Convert.ToInt32(TextBox2.Text));


                Label1.Text = "Successfully";

                TextBox1.Text = "";
            }
            if (RadioButton2.Checked)
            {


                string res = ClassLibrary3.Transaction.insertven_Details(Convert.ToInt32(DropDownList1.Text), DateTime.Now,
                    Convert.ToInt32(DropDownList3.Text), Convert.ToInt32(TextBox2.Text));


                Label1.Text = "Successfully";

                TextBox1.Text = "";
            }
        }
    }
}