using ClassLibrary3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;



namespace trust2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                getitemid();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string res = ClassLibrary3.Item.insertItem_Master(TextBox1.Text, DropDownList1.SelectedValue, Convert.ToInt32(TextBox3.Text),
                Convert.ToInt32(TextBox2.Text));

            Label1.Text = res;
            getitemid();
            TextBox1.Text = "";
        }
        public void getitemid()
        {
            int res = Convert.ToInt32(ClassLibrary3.Item.getItem_Id());
            res = res + 1;
            TextBox4.Text = res.ToString();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string res = ClassLibrary3.Item.updateItem_Master( TextBox1.Text,Convert.ToInt32(TextBox3.Text));
                
            Label1.Text = res;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string res = ClassLibrary3.Item.deleteItem_Master(TextBox1.Text);
                
            Label1.Text = res;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = ClassLibrary3.Item.searchItem_Master(TextBox1.Text);
            if (ds.Tables[0].Rows.Count != 0)
            {
                TextBox4.Text = ds.Tables["Item_Master"].Rows[0].ItemArray[0].ToString();
            }
            else
            {
                Label1.Text = "no record exist";
            }
        }
    }
}