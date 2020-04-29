using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_1
{
    class HRDepartment
    {
        public List<Employee> Employees { get; set; }
        private IEmployeeBuilder builder;

        public HRDepartment(IEmployeeBuilder builder)
        {
            this.builder = builder;
            Employees = new List<Employee>();

            builder.SetAdress(new Adress("A", "A", "123"));
            builder.SetData(new Data("Ale", "Herme", new DateTime(1997, 7, 2)));
        }

        public void GenerateRaport()
        {
            if(Employees != null)
            foreach(Employee employee in Employees)
            {
                Console.WriteLine(employee.ToString());
            }
        }

        public Employee GetEmployee()
        {
            return builder.GetEmployee();
        }
    }
}
