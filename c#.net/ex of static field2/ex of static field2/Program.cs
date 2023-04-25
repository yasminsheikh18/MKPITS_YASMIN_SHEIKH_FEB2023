using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_of_static_field
{
    class Employee
    {
        public int empno;
        public string name;
        public static string Company_name="TCS";

        public Employee(int empno, string name)
        {
            this.empno = empno;
            this.name = name;
        }
        public void display()
        {
            Console.WriteLine("actno " + empno);
            Console.WriteLine("name " + name);
            Console.WriteLine("company name " + Company_name );

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee(1, "yasmin");
            e1.display();
            Console.WriteLine("----------------------------------");
            Employee e2 = new Employee(2, "yashu");
            e2.display();
        }
    }
}

