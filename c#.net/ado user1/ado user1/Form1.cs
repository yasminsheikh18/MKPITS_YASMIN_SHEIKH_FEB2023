using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ado_user1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constr = "server=LAPTOP-ETMMI9QB\\SQLEXPRESS;integrated security=true;database=adocivica";
            SqlConnection conn = new SqlConnection(constr);
            try
            {

                conn.Open();
                label1.Text = "successfull";

            }
            catch (Exception ex)
            {
                label1.Text =ex.ToString();
            }
            finally
            { 
                 conn.Close();
            }


        }
    }
}
