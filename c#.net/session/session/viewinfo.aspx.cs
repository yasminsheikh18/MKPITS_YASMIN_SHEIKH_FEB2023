using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace session
{
    public partial class viewinfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = (string)Session["UserName"];
            Label2.Text = (string)Session["Email"];

        }
    }
}