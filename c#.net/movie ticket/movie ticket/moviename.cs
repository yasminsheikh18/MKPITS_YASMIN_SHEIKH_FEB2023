using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movie_ticket
{
    internal class moviename
    {
        private string name;
        private string theater;
        private int time;
        private int seatnumber;
        private int ticketprice;
        private int calculateticketprice;

        public string Name { get; set; }
        public string Theater { get; set; }
        public int Time { get; set; }
        public int SeatNumber { get; set; }
        public int Ticketprice { get; set; }

        public int Calculateticketprice { get;  set; }
    }
   
}
