using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_no_with_recursion
{
    internal class Program
    {

        public static int Main()
        {
            int n1, number;
            Console.Write(" Input any  number : ");
            n1 = Convert.ToInt32(Console.ReadLine());
            number = checkForoddeven(n1, n1 / 2);//call the function checkForPrime

            if (number % 2 == 0)
            {
                Console.Write(" The number {0} is a even number. \n\n", n1);
            }
            else if (number % 2 != 0)
            {
                Console.WriteLine(" The number {0} is a odd number. \n\n", n1);
            }
            return 0;
        }

        static int checkForoddeven(int n1, int i)
        {
            if (i == 1)
            {
                return 1;
            }
            else
            {
                if (n1 % i == 0)
                    return 0;
                else
                    return checkForoddeven(n1, i - 1);//calling the function checkForPrime itself recursively
            }

        }

    }
}
