using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fendhal_2_project
{
    public partial class Form1 : Form
    {
        enum  Nationality{ Indian,NRI}
        Nationality nationality;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = Product.Getcategory();
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "Product_Type_Name";
        }
        int cgst = 0;
        int sgst = 0;
        int igst = 0;
        int tgst = 0;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds2 = Product.Getproduct(comboBox1.Text);
            comboBox2.DataSource = ds2.Tables[0];
            comboBox2.DisplayMember = "Product_Name";

            DataSet ds3 = Product.Getgst(comboBox1.Text);
            foreach(DataRow dr in ds3.Tables[0].Rows)
            {
                cgst = Convert.ToInt32(dr["cgst"].ToString());
                sgst = Convert.ToInt32(dr["sgst"].ToString());
                igst = Convert.ToInt32(dr["igst"].ToString());

            }
            if(nationality==0)
            {
                tgst = cgst + sgst;
            }
            else
            {
                tgst = igst;
            }
            textBox3.Text=cgst.ToString();
            textBox4.Text = sgst.ToString();
            textBox5.Text = igst.ToString();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = Product.Getprice(comboBox2.Text);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                textBox9.Text = dr["prices"].ToString();
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            nationality = Nationality.Indian;
            textBox3.Text = cgst.ToString();
            textBox4.Text = sgst.ToString();
            textBox5.Text=Convert.ToString(Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox4.Text));
            calculate_total();


        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            nationality = Nationality.NRI;
            textBox3.Text = cgst.ToString();
            textBox4.Text = sgst.ToString();
            textBox5.Text = igst.ToString();
            calculate_total();

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
            //fill quantity * price
        {

            if (textBox10.Text == "")
            {

            }
            else
            {
                calculate_total();
            }
        }
        public void calculate_total()
        {
            //price * qquantity

            double totalamount = Convert.ToDouble(textBox9.Text) * Convert.ToDouble(textBox10.Text);
            textBox11.Text = totalamount.ToString();

            //price*cgst/100
            double CGSTamount = Convert.ToDouble(textBox9.Text) * (Convert.ToDouble(textBox3.Text) / 100.0);
            textBox6.Text = CGSTamount.ToString();

            double SGSamount = Convert.ToDouble(textBox9.Text) * (Convert.ToDouble(textBox4.Text) / 100.0);
            textBox7.Text = SGSamount.ToString();

            double IGSTamount = Convert.ToDouble(textBox9.Text) * (Convert.ToDouble(textBox5.Text) / 100.0);
            textBox8.Text = IGSTamount.ToString();
            //find netamount

            double netamount = Convert.ToDouble(textBox11.Text) + Convert.ToDouble(textBox8.Text);
            textBox12.Text = netamount.ToString();
        }


    }
}

