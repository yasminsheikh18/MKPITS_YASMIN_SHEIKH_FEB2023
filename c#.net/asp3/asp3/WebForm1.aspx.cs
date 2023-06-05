using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            int result = 0;
            string opt;
            num1 = Convert.ToInt32(TextBox1.Text);
            num2 = Convert.ToInt32(TextBox2.Text);
            opt = TextBox3.Text;
            if (opt == "+")
            {
                result = num1 + num2;
            }
            else if (opt == "-")
            {
                result = num1 - num2;
            }
            else if (opt == "*")
            {
                result = num1 * num2;
            }
            else if (opt == "/")
            {
                result = num1 / num2;
            }
            Label1.Text = result.ToString();
        }
    }
}
