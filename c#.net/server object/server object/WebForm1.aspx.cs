using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace server_object
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("Hello from WebForm1 Page");
            Server.Execute("WebForm2.aspx");
            Response.Write("Welcome back to webform1 page");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Write("Hello from WebForm1 transfer Page");
            Server.Transfer("WebForm2.aspx");
            Response.Write("Welcome back to webform1 transfer page");

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Write(Server.HtmlEncode("<h1>is a example of heading tag </h1>"));
            Response.Write("<h1>is a example of heading tag </h1>");

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Write(Server.UrlEncode("http://localhost / code / map.aspx"));
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            String name = Server.UrlEncode("Yasmin Sheikh");

            Response.Redirect
            ("WebForm3.aspx?name=" + name);
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            String name = Server.UrlEncode("John Saunders");

            String password = Server.UrlEncode("king");

            Response.Redirect("WebForm3.aspx?name = " + name + " & password = " + password);
        }                                                                                                         
    }
}