using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__program_to_illustrate_the_Enum2
{
    class Perimeter
    {
      public  enum shape
        { 
        circle,square
        
        }

        public void peri(int val, shape s1)
        {
            // checking for shape to be circle

            if (s1 == 0)
            {
                // Output the circumference
                Console.WriteLine("Circumference of the circle is " + 2 * 3.14 * val);

            }

            else
            {
                // else output the perimeter of the square
                Console.WriteLine("Perimeter of the square is " + 4 * val);

            }

        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Perimeter a1 = new Perimeter();
            a1.peri(3, Perimeter.shape.circle);
            a1.peri(4, Perimeter.shape.square);
        }
    }
}
