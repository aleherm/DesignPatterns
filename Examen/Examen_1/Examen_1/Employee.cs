using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_1
{
    class Employee
    {
        public Data PersonalData { get; set; }
        public Adress Adress { get; set; }

        public override string ToString()
        {
            return PersonalData + " | " + Adress;
        }
    }
}
