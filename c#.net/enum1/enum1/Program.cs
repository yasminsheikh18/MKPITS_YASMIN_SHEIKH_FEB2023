using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum1
{
    // making an enumerator 'month'
    enum Month
    {
        // following are the data members
        jan, feb,mar,apr,may,
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("the value of jan is " + " enum is " + (int)Month.jan);
            Console.WriteLine("the value of feb is " + " enum is " + (int)Month.feb);
            Console.WriteLine("the value of mar is " + " enum is " + (int)Month.mar);
            Console.WriteLine("the value of apr is " + " enum is " + (int)Month.apr);
            Console.WriteLine("the value of may is " + " enum is " + (int)Month.may);
        }
    }
}
