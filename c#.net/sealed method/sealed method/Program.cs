using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sealed_method
{
    class person
    { 
    
        public virtual void display()
        {
            Console.WriteLine("hello from person");
        }
    
    }
    class student : person 
    {
        public sealed override void display() 
        {
        Console.WriteLine("Hello from student");
        }
    }  
    class perstudent : student
    {
        //public override void display()
        //{
        //  Console.WriteLine("");
        //}
        public void pshow()
        {

            Console.WriteLine("hello from perstudent");
                }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            perstudent p = new perstudent();
            p.display();
            p.pshow();

        }
    }
}
