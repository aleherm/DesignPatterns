using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            CarDealer carDealer = new CarDealer();
            int id1 = carDealer.OrderCar("MercedesBenz", "red", 10000, ECarType.EAuto);
            int id2 = carDealer.OrderCar("Volvo", "blue", 20000, ECarType.ETruck);
            carDealer.OrderCar("Renault", "yellow", 30000, ECarType.EAuto);
            carDealer.OrderCar("Volkswagen", "black", 40000, ECarType.ETruck);

            carDealer.StockCar();

            carDealer.DriveTest(id1);
            carDealer.DriveTest(id2);
            carDealer.DriveTest(2000);

            carDealer.StockCar();
            carDealer.SellCar(id1);
        }
    }
}

/*
 * id si kilometraj publice
cheie id, value car

order car - brand, color, pret, type
sell car - id
drive test - id
se scoate din dictionar daca se vinde etc (se muta din ordered in testDrive)
50-100 km
driveTest - returneaza nr de km din testDrive
dealer, car - ToString()
StockDrive - se afiseaza si ordered si testDrive
 */
