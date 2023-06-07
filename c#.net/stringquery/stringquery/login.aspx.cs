using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace stringquery
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string uname = Request.QueryString["t1"].ToString();
            Response.Write("UserName is :" + uname + "<br>");
            string password= Request.QueryString["t2"].ToString();
            Response.Write("password is :" + password + "<br>");

            if (uname == "admin" && password == "admin")
            {
                Response.Redirect("dashboard.aspx");

            }
            else 
            {
                Response.Redirect("Htmlpage1.html");
            }
        }
    }
}