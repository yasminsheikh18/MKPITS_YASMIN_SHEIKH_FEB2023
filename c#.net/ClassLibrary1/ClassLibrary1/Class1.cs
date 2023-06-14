using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ClassLibrary1
{
    public class Class1
    {
        public string addition(int n1, int n2)
        {
            int res = n1 + n2;
            return "addition is" + res.ToString();

        }

        public string subtraction(int n1, int n2)
        {
            int res = n1 - n2;
            return "subtraction is" + res.ToString();

        }

        public string multiplication(int n1, int n2)
        {
            int res = n1 * n2;
            return "multiplication is" + res.ToString();

        }

        public string division(int n1, int n2)
        {
            int res = n1 / n2;
            return "division is" + res.ToString();

        }


    }
}
