using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace adoinsert
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //SqlDataReader dr = EmployeeDetails.GetCity();
            ////reading the records from sqldatareader
            //while(dr.Read())
            //{
            //    comboBox1.Items.Add(dr["cityname"].ToString());
            //}

            DataSet ds = EmployeeDetails.getEmployeeDetails();
            dataGridView1.DataSource = ds.Tables[0];



        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds = EmployeeDetails.searchemployee(Convert.ToInt32(textBox1.Text));
            dataGridView1.DataSource = ds.Tables[0];
            textBox2.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
            string gender = ds.Tables[0].Rows[0].ItemArray[2].ToString();
            if (gender == "male")
                radioButton1.Checked = true;
            else
                radioButton2.Checked = true;

        }
    }
}
