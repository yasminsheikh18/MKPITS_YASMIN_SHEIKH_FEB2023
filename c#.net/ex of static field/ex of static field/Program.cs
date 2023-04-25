using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_of_static_field
{
    class Account
    {
        public int actno;
        public string name;
        public static float Rate_of_Interest=4.5f;

        public Account(int actno, string name)
        {
            this.actno = actno;
            this.name = name;
        }
        public void display()
        { 
        Console.WriteLine("actno " +  actno);
            Console.WriteLine("name " +  name);
            Console.WriteLine("rate of interest " +  Rate_of_Interest);
        
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account(123, "yasmin");
            Account a2 = new Account(456, "yashu");
            Account.Rate_of_Interest = 33.4f;
            a1.display();
            a2.display();
        }
    }
}
