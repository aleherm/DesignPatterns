using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_1
{
    class EmployeeBuilder : IEmployeeBuilder
    {
        Employee employee;

        public EmployeeBuilder()
        {
            employee = new Employee();
        }

        public void SetAdress(Adress adress)
        {
            employee.Adress = adress;
        }

        public void SetData(Data data)
        {
            employee.PersonalData = data;
        }

        public Employee GetEmployee()
        {
            return employee;
        }
    }
}
