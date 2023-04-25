using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_of_static_constructor
{
    public class calculate
    {
        public static float pi;
        static calculate()
        {
            pi = 3.14f;
            Console.WriteLine("this constructor is called");
        
        }
        public void display()
        {

            Console.WriteLine("Rate of Interest " + pi);
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            calculate c1 =new calculate();
            calculate c2 = new calculate();
            c1.display();
            c2.display();


        }
    }
}
