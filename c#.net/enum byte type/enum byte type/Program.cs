using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum_byte_type
{ 
    enum button : byte 
    {
        // OFF will be assigned 0
        OFF,

        //ON will be assigned 1
        ON


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 0 or 1 to know the " + "state of electric switch!");

            byte i = Convert.ToByte(Console.ReadLine());

            if (i == (byte)button.OFF)
            {

                Console.WriteLine("The electric switch is Off");
            }

            else if (i == (byte)button.ON)
            {
                Console.WriteLine("The electric switch is ON");
            }

            else
            {
                Console.WriteLine("byte cannot hold such" + " large value");

            }

        }
    }
}
