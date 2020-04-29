using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_ChainOfResponsability
{
    class TeamLeader : Employee
    {
        public TeamLeader(Employee employee) : base(employee)
        {

        }
        public override int GetMaxVacationDaysCanAprove()
        {
            return 5;
        }
    }
}
