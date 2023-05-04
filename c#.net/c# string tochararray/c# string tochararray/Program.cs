using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__string_tochararray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Hello C#";
            char[] ch = s1.ToCharArray();
            foreach (char c in ch)
            {
                Console.WriteLine(c);
            }

        }
    }
}
