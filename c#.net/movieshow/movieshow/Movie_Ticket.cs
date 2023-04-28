using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movieshow
{

    abstract class MovieTicket
    {
        public string MovieName { get; set; }

        public string TheaterName { get; set; }

        public string ShowTime { get; set; }

        public int NoOfSeats { get; set; }

        public float TicketPrice { get; set; }
        //method to calculate ticktet price
        public abstract string CalculateTicketPrice();

       
    }
    class OnlineBooking : MovieTicket
    {
        public OnlineBooking(int NoOfSeats, float TicketPrice)
        {

            this.NoOfSeats = NoOfSeats;
            this.TicketPrice = TicketPrice;
        }
        public float discount { get; set; }
        public override string CalculateTicketPrice()
        {
            float tp = NoOfSeats * TicketPrice;
            discount = tp * 0.10f;
            tp = tp - discount;

            return "Total Price : " + tp;

        }
    }


    class BoxOffice : MovieTicket
    {
        public BoxOffice(int NoOfSeats, float TicketPrice)
        {

            this.NoOfSeats = NoOfSeats;
            this.TicketPrice = TicketPrice;
        }
        public float BookingAmount { get; set; }
        public override string CalculateTicketPrice()
        {
            float tp = NoOfSeats * TicketPrice;
            BookingAmount = 20;
            tp = tp + 20;
            return "Ticket Price:" + tp;

        }
    }
}
