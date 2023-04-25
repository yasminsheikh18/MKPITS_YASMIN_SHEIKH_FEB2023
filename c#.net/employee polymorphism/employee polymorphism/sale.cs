using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_polymorphism
{
    internal class sale:emp
    {
        public int bonus = 500;
        public override int calsalary(int sal)
        {
            sal = bonus + sal;
            return sal;
        }
    }
}
