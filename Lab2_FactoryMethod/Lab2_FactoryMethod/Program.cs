using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            CarDealer carDealer = new CarDealer();
            int id1 = carDealer.OrderCar("Mercedes - Benz", "red", 10000, ECarType.EAuto);
            int id2 = carDealer.OrderCar("Volvo", "blue", 20000, ECarType.ETruck);
            carDealer.OrderCar("Renault", "yellow", 30000, ECarType.EAuto);
            carDealer.OrderCar("Volkswagen", "black", 40000, ECarType.ETruck);

            carDealer.StockCar();

            carDealer.DriveTest(id1);
            carDealer.DriveTest(id2);
            carDealer.DriveTest(1000);

            carDealer.StockCar();
            carDealer.SellCar(id1);
        }
    }
}
