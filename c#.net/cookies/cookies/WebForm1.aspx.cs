using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cookies
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
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