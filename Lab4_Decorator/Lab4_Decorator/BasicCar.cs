using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Decorator
{
    class BasicCar : ICar
    {
        public ECarType Type { get; set; }
        public string Color { get; set; }
        public string Motorization { get; set; }
        public int Accessories { get; set; }

        public BasicCar()
        {
            Type = ECarType.BASIC;
        }

        public void Assemble(string a, string b)
        {
            Accessories = 7800;
        }

        public void SetAccessories()
        {
            Accessories = 7800;
        }

        public override string ToString()
        {
            return "Type: " + Type + " | Color: " + Color + " | Motorization: " + Motorization + " | Accessories: " + Accessories;
        }
    }
}
