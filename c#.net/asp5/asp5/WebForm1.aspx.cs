using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name;
            int qty;
            double price;
            double res = 0;

            name = Convert.ToString(TextBox1.Text);
            qty = Convert.ToInt32(TextBox3.Text);
            price = Convert.ToDouble(TextBox2.Text);
            res = qty * price;
            Label1.Text = res.ToString();
        }
    }
}