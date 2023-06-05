using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int age = Convert.ToInt32(TextBox1.Text);
            if (age <= 0)
            {
                Label1.Text = "You are not Eligible";
            }
            else if (age >= 21)
            {
                Label1.Text = "You are Eligible ";
            }
        }
    }
}