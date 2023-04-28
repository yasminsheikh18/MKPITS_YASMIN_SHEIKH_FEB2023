using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace movieshow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Text = "";
            comboBox3.Text = "";
            switch (comboBox1.Text)
            {
                case "KBKJ":
                    comboBox2.Items.Add("Liberty");
                    comboBox2.Items.Add("Cinemax");
                    break;
                case "Bhola":
                    comboBox2.Items.Add("Smruti");
                    comboBox2.Items.Add("Inox");
                    break;
                case "Pathan":
                    comboBox2.Items.Add("Pvr");
                    comboBox2.Items.Add("Sudama");
                    break;

            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            comboBox3.Items.Clear();
            switch (comboBox2.Text)
            {
                case "Liberty":
                    comboBox3.Items.Add("12.00 PM");
                    comboBox3.Items.Add("03.00 PM");
                    textBox1.Text = "120";
                    break;
                case "Cinemax":
                    comboBox3.Items.Add("10.30 AM");
                    comboBox3.Items.Add("01.30 PM");
                    textBox1.Text = "420";
                    break;
                case "Smruti":
                    comboBox3.Items.Add("12.30 PM");
                    comboBox3.Items.Add("06.30 PM");
                    textBox1.Text = "100";
                    break;

                case "Inox":
                    comboBox3.Items.Add("12.00 PM");
                    comboBox3.Items.Add("03.00 PM");
                    textBox1.Text = "150";
                    break;

                case "Pvr":
                    comboBox3.Items.Add("12.30 PM");
                    comboBox3.Items.Add("06.30 PM");
                    textBox1.Text = "250";
                    break;

                case "Sudama":
                    comboBox3.Items.Add("03.00 PM");
                    comboBox3.Items.Add("06.30 PM");
                    textBox1.Text = "300";
                    break;

            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MovieTicket mt = null;
            if (radioButton1.Checked)
            {
                mt = new OnlineBooking(Convert.ToInt32(numericUpDown1.Value), Convert.ToSingle(textBox1.Text));

            }
            else if (radioButton2.Checked)
            {
                mt = new BoxOffice(Convert.ToInt32(numericUpDown1.Value), Convert.ToSingle(textBox1.Text));


            }
            label8.Text = mt.CalculateTicketPrice();

        }
    }
}
