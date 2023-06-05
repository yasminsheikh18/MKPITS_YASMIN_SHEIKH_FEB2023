using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp7
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string custname = TextBox1.Text;
            string proudname = TextBox2.Text;
            double price = Convert.ToDouble(TextBox3.Text);
            double qty = Convert.ToDouble(TextBox4.Text);

            double total = 0;
            if (RadioButton1.Checked)
            {
                total = price * qty;
            }
            else
            {
                total = (price * qty) / 3;
            }
            Label1.Text = total.ToString();
        }
    }
}