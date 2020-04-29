using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_FactoryMethod
{
    class AutomobilFactory : CarFactory
    {
        public override Car GetCar(string brand, string color, int price)
        {
            LastId++;
            return new Automobil(LastId, brand, color, price);
        }
    }
}
