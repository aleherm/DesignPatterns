using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_ChainOfResponsability
{
    class DepartmentDirector : Employee
    {
        public DepartmentDirector(Employee employee) : base(employee)
        {

        }
        public override int GetMaxVacationDaysCanAprove()
        {
            return 15;
        }
    }
}
