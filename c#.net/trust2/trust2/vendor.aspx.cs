using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary3;
using System.Data;



namespace trust2
{
    public partial class vendor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                getvendorid();
            }
        }
        

        protected void Button1_Click(object sender, EventArgs e)
        {
            string res = Vendor.insertVendor_Master(TextBox1.Text);

            Label1.Text = res;
            getvendorid();
            TextBox1.Text = "";
        }
        public void getvendorid()
        {
            int res = Convert.ToInt32(Vendor.getVendor_Id());
            res = res + 1;
            TextBox2.Text = res.ToString();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string res = Vendor.updateVendor_Master(TextBox1.Text, Convert.ToInt32(TextBox2.Text));
            Label1.Text = res;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string res = Vendor.deleteVendor_Master(Convert.ToInt32(TextBox2.Text));
            Label1.Text = res;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = Vendor.searcVendor_Master(Convert.ToInt32(TextBox2.Text));
            if (ds.Tables[0].Rows.Count != 0)
            {
                TextBox1.Text = ds.Tables["Vendor_Master"].Rows[0].ItemArray[1].ToString();
            }
            else
            {
                Label1.Text = "no record exist";
            }
        }
    }
}