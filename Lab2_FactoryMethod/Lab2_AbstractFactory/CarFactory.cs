using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_AbstractFactory
{
    abstract class CarFactory
    {
        public static int LastId = 0;

        public abstract Car GetCar(string brand, string color, int price);
    }
}
