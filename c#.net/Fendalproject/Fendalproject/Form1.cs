using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fendalproject
{
    public partial class Form1 : Form
    {
        enum Nationality { Indian,NRI}
        Nationality nationality;
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker1.MinDate = DateTime.Today;
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            { 
                e.Handled = true;   
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            nationality=Nationality.Indian;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            nationality= Nationality.NRI;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = productstore.Getcategory();
            comboBox1.DataSource= ds.Tables[0];
            comboBox1.DisplayMember = "Product_Type_Name";
            //comboBox1.ValueMember = "Product_Category_ID";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = productstore.Getproduct(comboBox1.Text);
            foreach(DataRow dr in ds.Tables[0].Rows)
            {
                comboBox2.Items.Add(dr["Product_Name"]);
            }
           // comboBox2.DataSource = ds.Tables[0];
            //comboBox2.DisplayMember = "Product_Name";

            //DataSet ds1 = productstore.Getprice(comboBox1.Text);
            //foreach (DataRow dr in ds1.Tables[0].Rows)
            //{
            //    textBox3.Text=( dr["cgst"].ToString());
            //    textBox4.Text=(dr["sgt"].ToString());
            //   textBox5.Text= (dr["igst"].ToString());

            //}

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = productstore.Getprice(comboBox2.Text);
            foreach(DataRow dr in ds.Tables[0].Rows)
            {
                textBox9.Text = dr["prices"].ToString();
            }

        }
    }
}
