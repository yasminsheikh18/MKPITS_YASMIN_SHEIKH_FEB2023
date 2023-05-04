using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__string_indexof
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Hello C#";
            int index = s1.IndexOf('o');
            Console.WriteLine(index);

        }
    }
}
