using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_1
{
    interface IEmployeeBuilder
    {
        void SetData(Data data);
        void SetAdress(Adress adress);

        Employee GetEmployee();
    }
}
