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
        enum Nationality { Indian, NRI }
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
            comboBox1.ValueMember = "Product_Category_ID";
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
            comboBox2.ValueMember = "ProductlD";

            DataSet ds3 = Product.Getgst(comboBox1.Text);
            foreach (DataRow dr in ds3.Tables[0].Rows)
            {
                cgst = Convert.ToInt32(dr["cgst"].ToString());
                sgst = Convert.ToInt32(dr["sgst"].ToString());
                igst = Convert.ToInt32(dr["igst"].ToString());

            }
            if (nationality == 0)
            {
                tgst = cgst + sgst;
            }
            else
            {
                tgst = igst;
            }
            textBox3.Text = cgst.ToString();
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
            textBox5.Text = Convert.ToString(Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox4.Text));
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

        private void button1_Click(object sender, EventArgs e)
        {
            checkuserdetails();
        }

        public void checkuserdetails()
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("please fill all the details");
            }
            else if (textBox10.Text == "0")
            {
                MessageBox.Show("Quantity cannot be zero");
            }
            else
            {
                string result = Product.savetableinvoicedetails(textBox1.Text, textBox2.Text, Convert.ToInt32(comboBox1.SelectedValue),
                    Convert.ToInt32(comboBox2.SelectedValue), Convert.ToInt32(nationality), dateTimePicker1.Value,
                    Convert.ToDecimal(textBox10.Text), Convert.ToDecimal(textBox9.Text), Convert.ToDecimal(textBox3.Text),
                    Convert.ToDecimal(textBox4.Text), Convert.ToDecimal(textBox5.Text), Convert.ToDecimal(textBox6.Text),
                    Convert.ToDecimal(textBox7.Text), Convert.ToDecimal(textBox8.Text), Convert.ToDecimal(textBox11.Text));
                MessageBox.Show(result);



                //textbox1=====full name
                // textBox2======contact number
                //comboBox1.SelectedValue=====productcategoryid(Product type name)
                //comboBox2.SelectedValue=====productid(Product name)
                //nationality ( RADIO BUTTON)
                //  dateTimePicker1.Value(INVOICE DATE)
                //textbox10=======QUANTITY
                //textbox9========price
                //textbox3=========CGST
                //textbox4========SGST
                //textbox5===========IGST
                //textbox6========CGST_VAluE
                //textbox7========sGST_VAluE
                //textbox8========iGST_VAluE
                //textbox11========totalamount
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearall();
        }
        public void clearall()//method
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox10.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox11.Clear();
            textBox12.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            dateTimePicker1.Value = DateTime.Now;
        }
    }
}

