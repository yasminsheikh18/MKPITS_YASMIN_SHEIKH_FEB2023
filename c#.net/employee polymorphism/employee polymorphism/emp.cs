using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_polymorphism
{
    internal class emp
    {
        public int sal;
        public virtual int calsalary(int bonus)
        {

            return bonus;
        }
    }
}
