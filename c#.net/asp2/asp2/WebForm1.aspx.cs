using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int s1, s2, s3, total;
            float per;
            string grade = "";
            s1 = Convert.ToInt32(TextBox1.Text);
            s2 = Convert.ToInt32(TextBox3.Text);
            s3 = Convert.ToInt32(TextBox3.Text);

            total = s1+s2+s3;
            Label1.Text = total.ToString();

            per = (total / 300.0f) * 100.0f;
            Label2.Text = per.ToString();

            if (per >= 75)
            {
                grade = "distinction";

            }
            else if (per >= 60 && per < 75)
            {
                grade = "first";
            }
            else 
            {
                grade = "fail";
            }
            Label3.Text = grade.ToString();
        }
    }
}