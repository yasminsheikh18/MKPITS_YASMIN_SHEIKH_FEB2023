using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_polymorphism
{
    internal class manager : emp
    {
        public int bonus = 1000;
        public override int calsalary(int sal)
        {
            sal = bonus + sal;
            return sal;
        }
    }
}
