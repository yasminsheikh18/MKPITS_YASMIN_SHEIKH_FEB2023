using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
   
    public class Class1
    {
        int bal = 1000;
        public string deposite(int amount)
        {
            int total = bal + amount;
            return "bal is " + total.ToString();
        }

        public string withdrawl(int withdrawl)
        { 
            int total = bal - withdrawl;
            return "withdrawl is " + total.ToString();
        }
    }
}
