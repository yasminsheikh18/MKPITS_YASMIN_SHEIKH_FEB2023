using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursion_table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("enter number");
            n=Convert.ToInt32(Console.ReadLine());
           int abc= table(n, 1);
        }
        static int table(int n,int i) 
        {
            if (i > 10)
            {
                return 1;
            }
            else
            {
                Console.WriteLine(n + " * " + i + " = " + n * i);
                return table(n, i + 1);
            }

            
           



        }
    }
}
