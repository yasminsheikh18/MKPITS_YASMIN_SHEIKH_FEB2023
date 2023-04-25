using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movie_ticket
{
    internal class onlinebooking : moviename
    {
        private double discount;
        public double Discount { get; set; }

        public double calculateTicketprice(double price)
        {
            return price = price - discount;

        }
    }
}
