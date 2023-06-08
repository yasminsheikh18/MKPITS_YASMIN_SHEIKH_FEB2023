using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace registration_assign
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["cook1"];
            if (cookie != null)
            {
                string name = cookie.Values["username"].ToString();
                string email = cookie.Values["email"].ToString();
                string password = cookie.Values["password"].ToString();
                Label1.Text = name;
                Label2.Text = email;
                Label3.Text = password;
            }
            else
            {
                Label1.Text = "no data";
            }
        }
    }
}