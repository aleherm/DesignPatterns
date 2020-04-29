using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_AbstractFactory
{
    class MercedesBenzCarFactory : AbstractCarFactory
    {
        public override Car GetAutomobile(string color, int price)
        {
            LastId++;
            return new Automobil(LastId, "Mercedes-Benz", color, price);
        }

        public override Car GetTruck(string color, int price)
        {
            LastId++;
            return new Truck(LastId, "Mercedes-Benz", color, price);
        }
    }
}
