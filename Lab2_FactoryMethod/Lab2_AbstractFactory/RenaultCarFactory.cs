using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_AbstractFactory
{
    class RenaultCarFactory : AbstractCarFactory
    {
        public override Car GetAutomobile(string color, int price)
        {
            LastId++;
            return new Automobil(LastId, "Renault", color, price);
        }

        public override Car GetTruck(string color, int price)
        {
            LastId++;
            return new Truck(LastId, "Renault", color, price);
        }
    }
}
