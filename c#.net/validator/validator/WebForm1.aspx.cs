using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace validator
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("first name : " + TextBox1.Text + "<br>");
            sb.Append("Age: " + TextBox4.Text + "<br>");
            sb.Append("Email: " + TextBox5.Text + "<br>");
            Label1.Text = sb.ToString();

        }
    }
}