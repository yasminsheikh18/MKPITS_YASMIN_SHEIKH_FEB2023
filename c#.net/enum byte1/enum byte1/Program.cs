using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum_byte1
{
    enum Categories : byte
    {
        Electronics = 1,
        Food = 5,
        Automotive = 6,
        Arts = 10,
        BeautyCare = 11,
        Fashion = 15
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("the value of food " + (int)Categories.Food); 
        }
    }
}
