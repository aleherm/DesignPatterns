using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_1
{
    class Program
    {
        static void Main(string[] args)
        {
            HRDepartment hr = new HRDepartment(new EmployeeBuilder());
            hr.Employees.Add(hr.GetEmployee());
            hr.GenerateRaport();
        }
    }
}
