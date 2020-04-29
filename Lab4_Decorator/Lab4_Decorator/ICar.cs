using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Decorator
{
    interface ICar
    {
        ECarType Type { get; set; }
        string Color { get; set; }
        string Motorization { get; set; }
        int Accessories { get; set; }

        void Assemble(string color, string motorization);
        void SetAccessories();
        string ToString();
    }
}
