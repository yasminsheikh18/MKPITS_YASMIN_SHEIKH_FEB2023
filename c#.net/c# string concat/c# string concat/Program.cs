using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__string_concat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Hello ";
            string s2 = "C#";
            Console.WriteLine(string.Concat(s1, s2));

        }
    }
}
