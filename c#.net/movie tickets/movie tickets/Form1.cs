using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace movie_tickets
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox2.Items.Clear();
            switch (comboBox1.Text)
            {
                case "Pathan":
                    pictureBox1.Show();
                    comboBox2.Items.Add("Vr");
                    comboBox2.Items.Add("Pvr");
                    comboBox2.Items.Add("Smruti");
                    pictureBox2.Hide();
                    break;
                case "KBKJ":
                    pictureBox2.Show();
                    comboBox2.Items.Add("Vr");
                    comboBox2.Items.Add("Pvr");
                    comboBox2.Items.Add("Smruti");

                    pictureBox1.Hide();
                    break;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            comboBox3.Items.Clear();
            switch (comboBox2.Text)
            {
                case "Vr":
                    comboBox3.Items.Add("9.00AM");
                    comboBox3.Items.Add("10.30AM");
                    comboBox3.Items.Add("1.30PM");
                    textBox1.Text = "420";
                    break;
                case "Pvr":
                    comboBox3.Items.Add("9.00AM");
                    comboBox3.Items.Add("10.30AM");
                    comboBox3.Items.Add("1.30PM");
                    textBox1.Text = "320";
                    break;
                case "Smuri":
                    comboBox3.Items.Add("9.00AM");
                    comboBox3.Items.Add("10.30AM");
                    comboBox3.Items.Add("1.30PM");
                    textBox1.Text = "250";
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Show();
            
            button2.Show();

            label6.Text = comboBox1.Text;
            label7.Text = comboBox2.Text;
            label8.Text = comboBox3.Text;
            label9.Text = numericUpDown1.Text;
            MovieTicket mt = null;
            if (radioButton1.Checked)
            {
                mt = new OnlineBooking(Convert.ToInt32(numericUpDown1.Value), Convert.ToSingle(textBox1.Text));

            }

            else if (radioButton2.Checked)
            {
                mt = new BoxOffice(Convert.ToInt32(numericUpDown1.Value), Convert.ToSingle(textBox1.Text));
            }
            label10.Text = mt.CalculateTicketPrice();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            pictureBox2.Hide();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Ticket Book Succesfully");
        }
    }

}


     
