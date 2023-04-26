using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__String_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "hello";

            char[] ch = { 'c', 's', 'h', 'a', 'r', 'p' };
            string s2 = new string(ch);

            Console.WriteLine(s1);
            Console.WriteLine(s2);

        }
    }
}
