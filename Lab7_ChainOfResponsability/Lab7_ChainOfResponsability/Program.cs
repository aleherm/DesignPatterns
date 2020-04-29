using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_ChainOfResponsability
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee(new TeamLeader(new ProjectLeader(new DepartmentDirector(null))));
            VacationRequest request1 = new VacationRequest(new DateTime(2019, 10, 25), new DateTime(2019, 10, 30));
            employee1.ApplyVacationRequest(request1);

            Employee employee2 = new Employee(new TeamLeader(new ProjectLeader(new DepartmentDirector(null))));
            VacationRequest request2 = new VacationRequest(new DateTime(2019, 10, 21), new DateTime(2019, 10, 30));
            employee2.ApplyVacationRequest(request2);

            Employee employee3 = new Employee(new TeamLeader(new ProjectLeader(new DepartmentDirector(null))));
            VacationRequest request3 = new VacationRequest(new DateTime(2019, 10, 16), new DateTime(2019, 10, 30));
            employee3.ApplyVacationRequest(request3);

            Employee employee4 = new Employee(new TeamLeader(new ProjectLeader(new DepartmentDirector(null))));
            VacationRequest request4 = new VacationRequest(new DateTime(2019, 10, 10), new DateTime(2019, 10, 30));
            employee4.ApplyVacationRequest(request4);
        }
    }
}
