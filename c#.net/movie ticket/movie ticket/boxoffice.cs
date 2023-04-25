using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movie_ticket
{
    internal class boxoffice : moviename
    {
        private double bookingfees;
        public double Bookingfees { get; set; }

        public double CalculateTicketPrice(double price)
        {
            int gst = 20;
            return price = gst + price;
        }
    }
}
