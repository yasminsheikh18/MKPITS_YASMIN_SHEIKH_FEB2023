using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_of_throw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
           
            try 
            {
                Console.WriteLine("enter age");
                age = Convert.ToInt32(Console.ReadLine());
                if (age <= 0 || age > 100)
                {

                    throw new Exception("Enter Proper Age");
                }
                else
                {
                    Console.WriteLine("Your Age is " + age);
                
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.ToString());
            }
            Console.WriteLine("bye");
            Console.ReadLine();
                
        }
    }
}
