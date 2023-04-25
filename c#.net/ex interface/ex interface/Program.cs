using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_interface
{
    interface interface1
    {
        void method();

    }
    class class1 : interface1
    {

        public void method()
        {
            Console.WriteLine("hello from method");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            interface1 a1 = new class1();
            a1.method();
        }
    }
}
