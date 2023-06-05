using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AaSP6
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int actno = Convert.ToInt32(TextBox1.Text);
            int amount = Convert.ToInt32(TextBox2.Text);
            int bal = 1000;
            string acttype = Convert.ToString(TextBox3.Text);

            if (amount == 0)
            {
                Label1.Text = "Enter proper Amount ";
            }

            if (acttype == "deposite")
            {
                bal = bal + amount;
            }
            if (acttype == "withdrawl")
            {
                bal = amount - bal;
            }

            Label1.Text = bal.ToString();


        }
    }
}