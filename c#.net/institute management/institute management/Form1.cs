using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static institute_management.institute;
using System.Data.SqlClient;

namespace institute_management
{
    public partial class Form1 : Form
    {
        enum Category { student, IT_Profession }
        Category category;
        enum Gender { male, female, other }
        Gender gender;
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker1.MinDate = DateTime.Today;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            DataSet ds = institute.getnation();
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "nationname";
            comboBox1.ValueMember = "nationid";
            textBox2.Text = "1000";



        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = institute.getcity(comboBox2.Text);
            comboBox3.DataSource = ds.Tables[0];
            comboBox3.DisplayMember = "cityname";
            comboBox3.ValueMember = "cityid";



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = institute.getstate(comboBox1.Text);
            comboBox2.DataSource = ds.Tables[0];

            comboBox2.DisplayMember = "statename";
            comboBox2.ValueMember = "stateid";

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                category = Category.student;
                textBox2.Text = "1000";
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            category = Category.IT_Profession;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            gender = Gender.male;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            gender = Gender.female;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            gender = Gender.other;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            radioButton1.Text = "";
            radioButton2.Text = "";
            radioButton3.Text = "";
            radioButton4.Text = "";
            radioButton5.Text = "";

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton2.Checked)
            {

                category = Category.student;
                textBox2.Text = "3000";
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            check_balance_amount();
        }
        double total = 0;
        double fiftypercent = 0;
        double bal_amount = 0;
        public void check_balance_amount()
        {
            total = Convert.ToDouble(textBox2.Text);
            double paid = Convert.ToDouble(textBox3.Text);
            fiftypercent = 0;
            if (category == 0)//student
            {
                fiftypercent = total * 0.5;
            }
            else
            {
                fiftypercent = total * 0.8;
            }
            if (Convert.ToDouble(textBox3.Text) < fiftypercent)
            {
                MessageBox.Show("paid amount should be atleast 50% for Student And 80% for ITProffessional ");

            }
            else if (paid > total)
            {
                MessageBox.Show("paid amount should not be greater than total amount ");
                textBox3.Clear();
            }

            else
            {

                bal_amount = Convert.ToDouble(textBox2.Text) - Convert.ToDouble(textBox3.Text);
                textBox4.Text = bal_amount.ToString();

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            savebutton();
        }

        public void savebutton()
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("pls fill the details");
            }
            else
            {

                string result = institute.savetablecourseregdetail(Convert.ToInt32(category), textBox1.Text, Convert.ToInt32(gender));
                MessageBox.Show(result);

                //5 th table

                result = institute.savetablereg(Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(comboBox2.SelectedValue), Convert.ToInt32(comboBox3.SelectedValue));
                MessageBox.Show(result);
            }
        }
    }
}
