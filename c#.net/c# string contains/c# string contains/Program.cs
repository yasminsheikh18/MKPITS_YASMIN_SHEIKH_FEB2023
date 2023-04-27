using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__string_contains
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Hello ";
            string s2 = "He";
            string s3 = "Hi";
            Console.WriteLine(s1.Contains(s2));
            Console.WriteLine(s1.Contains(s3));

        }
    }
}
