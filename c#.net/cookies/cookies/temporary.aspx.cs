using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cookies
{
    public partial class temporary : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //code to create temporary cookie
            HttpCookie cookie1 = new HttpCookie("cook");
            cookie1.Values.Add("username", TextBox1.Text);
            Response.Cookies.Add(cookie1);
            Label1.Text = "temporary cookie added to client machine";


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //code to retrieve cookie from client machine

            HttpCookie cookie1 = Request.Cookies["cook"];
            if (cookie1 != null)
            {
                string uname = cookie1.Values["username"].ToString();
                Label1.Text = "username : " + uname;
            }
            else
            {
                Label1.Text = "no cookie exist";
            }

        }
    }
}