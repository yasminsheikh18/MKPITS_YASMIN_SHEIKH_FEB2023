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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace movie_ticket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int price;
            price = Convert.ToInt32(comboBox4.Text);
            moviename obj = new moviename();
            obj.Name = Convert.ToString(comboBox1.Text);
            obj.Theater = Convert.ToString(comboBox2.Text);
            obj.Time = Convert.ToInt32(comboBox3.Text);
            obj.SeatNumber = Convert.ToInt32(textBox4.Text);
            obj.Ticketprice = Convert.ToInt32(comboBox4.Text);
            //obj.calculateTicketprice(Convert.ToInt32(price));
            //obj= new OnlineBooking();
            //obj = new BoxOffice();
            string name = obj.Name;
            string tname = obj.Theater;
            int time = obj.Time;
            int no = obj.SeatNumber;
            int res = obj.Ticketprice;
            label6.Text = "Movie Name:" + name
                          + "\n" + "Theater Name:" + tname
                          + "\n" + "Show Time:" + time
                          + "\n" + "Seat Number:" + no
                          + "\n" + "Ticket Price:" + res;
            //label7.Text = "hello";
        }

    }
    
}
