using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_inheritance
{
    interface interface1
    {
        void method1();
    }
    interface interface2 : interface1
    { 
     void method2();
    }

    class class1 :interface2 
    
    {
        public void method1()
        {
            Console.WriteLine("hello from method1");
        
        }
        public void method2()
        { 
         Console.WriteLine("hello from method 2");

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            class1 class1 = new class1();
            class1.method1();
            class1.method2();
        }
    }
}
