using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_AbstractFactory
{
    class VolvoCarFactory : AbstractCarFactory
    {
        public override Car GetAutomobile(string color, int price)
        {
            LastId++;
            return new Automobil(LastId, "Volvo", color, price);
        }

        public override Car GetTruck(string color, int price)
        {
            LastId++;
            return new Truck(LastId, "Volvo", color, price);
        }
    }
}
