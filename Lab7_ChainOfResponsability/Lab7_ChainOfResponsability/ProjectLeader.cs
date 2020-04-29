using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_ChainOfResponsability
{
    class ProjectLeader : Employee
    {
        public ProjectLeader(Employee employee) : base(employee)
        {

        }

        public override int GetMaxVacationDaysCanAprove()
        {
            return 10;
        }
    }
}
