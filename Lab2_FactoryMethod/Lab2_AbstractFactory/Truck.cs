using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_AbstractFactory
{
    class Truck : Car
    {
        public Truck(int id, string brand, string color, int price) : base(id, brand, color, price) { }

        public override ECarType Type()
        {
            return ECarType.ETruck;
        }
    }
}
