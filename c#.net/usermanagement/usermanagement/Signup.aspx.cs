using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace usermanagement
{
    public partial class Signup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string email, psw;
            email = Request.QueryString["email"].ToString();
            psw = Request.QueryString["psw"].ToString();
            Response.Write("email :" + email + "<br>");
            Response.Write("password :" + psw + "<br>");
        }
    }
}