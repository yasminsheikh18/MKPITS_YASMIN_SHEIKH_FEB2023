using ClassLibrary3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Net.NetworkInformation;

namespace trust2
{
    public partial class Department : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                getdepartmentid();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string res = Department1.insertDepartment_Master(TextBox1.Text);

            Label1.Text = res;
            getdepartmentid();
            TextBox1.Text = "";


        }

        public void getdepartmentid()
        {
            int res = Convert.ToInt32(Department1.getDepartment_Id());
            res = res + 1;
            TextBox2.Text = res.ToString();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string res = Department1.updateDepartment_Master(TextBox1.Text, Convert.ToInt32(TextBox2.Text));
            Label1.Text = res;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string res = Department1.deleteDepartment_Master(Convert.ToInt32(TextBox2.Text));
            Label1.Text = res;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = Department1.searchDepartment_Master(Convert.ToInt32(TextBox2.Text));
            if (ds.Tables[0].Rows.Count != 0)
            {
                TextBox1.Text = ds.Tables["Department_Master"].Rows[0].ItemArray[1].ToString();
            }
            else
            {
                Label1.Text = "no record exist";
            }
        }
    }
}