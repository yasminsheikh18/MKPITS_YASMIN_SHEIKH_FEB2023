using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movieshow
{

    abstract class Movie_Ticket
    {
        public string Movie_Name { get; set; }

        public string Theater_Name { get; set; }

        public string Show_Time { get; set; }

        public int No_Of_Seats { get; set; }

        public float Ticket_Price { get; set; }
        //method to calculate ticktet price
        public abstract string Calculate_Ticket_Price();

       
    }
    class Online_Booking : Movie_Ticket
    {
        public Online_Booking(int No_Of_Seat, float Ticket_Price)
        {

            this.No_Of_Seats = No_Of_Seats;
            this.Ticket_Price = Ticket_Price;
        }
        public float discount { get; set; }
        public override string Calculate_Ticket_Price()
        {
            float tp = No_Of_Seats * Ticket_Price;
            discount = tp * 0.10f;
            tp = tp - discount;

            return "Total Price : " + tp.ToString();

        }
    }


    class Box_Office : Movie_Ticket
    {
        public Box_Office(int No_Of_Seat, float Ticket_Price)
        {

            this.No_Of_Seats = No_Of_Seats;
            this.Ticket_Price = Ticket_Price;
        }
        public float Booking_Amount { get; set; }
        public override string Calculate_Ticket_Price()
        {
            float tp = No_Of_Seats * Ticket_Price;
            Booking_Amount = 20;
            tp = tp + Booking_Amount;
            return "Ticket Price:" + tp.ToString();

        }
    }
}
