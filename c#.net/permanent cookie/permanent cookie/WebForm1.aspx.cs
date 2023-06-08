using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace permanent_cookie
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //code to retrieve cookie from client machine

            HttpCookie cookie12 = Request.Cookies["cook1"];
            if (cookie12 != null)
            {
                string uname = cookie12.Values["username"].ToString();
                string uemail = cookie12.Values["email"].ToString();
                Label1.Text = "username : " + uname;
                Label2.Text = "email : " + uemail;
            }
            else
            {
                Label1.Text = "no permanent cookie exist";
            }
        }
    }
}