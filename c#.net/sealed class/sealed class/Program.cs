using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sealed_class
{
    sealed class employee
    {

        public void showdata()
        {
            Console.WriteLine("hello");
        }
    }
   // class emp : employee
    //{
     //   public void showdata()
       // { 
       // Console.Write("hello");
        //}
   // }
    internal class Program
    {
        static void Main(string[] args)
        {
            employee employee = new employee();
            employee.showdata();

        }
    }
}
