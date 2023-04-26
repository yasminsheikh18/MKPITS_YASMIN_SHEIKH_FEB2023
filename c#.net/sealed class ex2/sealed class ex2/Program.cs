using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sealed_class_ex2
{
    sealed class student
    { 
    public void ShowStudentData()
        {
            Console.WriteLine("Hello I am student");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            student s1 = new student();
            s1.ShowStudentData();
        }
    }
}
