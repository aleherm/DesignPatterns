using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_ChainOfResponsability
{
    class Employee
    {
        public Employee Supervisor { get; set; }

        public Employee(Employee employee)
        {
            Supervisor = employee;
        }

        public void ApplyVacationRequest(VacationRequest request)
        {
            if (Supervisor != null)
            {
                if (Supervisor.ApproveVacation(request))
                    return;
                Supervisor.ApplyVacationRequest(request);
            }
            else
            {
                Console.WriteLine("HR approval needed.");
            }
        }

        protected bool ApproveVacation(VacationRequest request)
        {
            int daysOff = request.GetNumberOfDaysOff();
            if(daysOff <= GetMaxVacationDaysCanAprove())
            {
                Console.WriteLine("It's ok! " + this.GetType());
                return true;
            }
            return false;
        }

        public virtual int GetMaxVacationDaysCanAprove()
        {
            return 0;
        }
    }
}
