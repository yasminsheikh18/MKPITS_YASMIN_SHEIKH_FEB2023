﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__string_spilt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Hello C Sharp";
            string[] s2 = s1.Split(' ');
            foreach (string s3 in s2)
            {
                Console.WriteLine(s3);
            }

        }
    }
}
