using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab2_FactoryMethod
{
    class CarDealer
    {
        private Dictionary<int, Car> orderedCars;
        private Dictionary<int, Car> testDrive;

        private const int EMPTY_DICTIONARY = 0;

        public CarDealer()
        {
            orderedCars = new Dictionary<int, Car>();
            testDrive = new Dictionary<int, Car>();
        }

        public int OrderCar(string brand, string color, int price, ECarType type)
        {
            CarFactory carFactory;
            Car car = null;
            switch (type)
            {
                case ECarType.EAuto:
                    carFactory = new AutomobilFactory();
                    car = carFactory.GetCar(brand, color, price);
                    orderedCars.Add(car.ID, car);
                    break;
                case ECarType.ETruck:
                    carFactory = new TruckFactory();
                    car = carFactory.GetCar(brand, color, price);
                    orderedCars.Add(car.ID, car);
                    break;
            }
            return car.ID;
        }

        public Car SellCar(int id)
        {
            Car car = null;
            orderedCars.TryGetValue(id, out car);
            if(car != null)
            {
                orderedCars.Remove(car.ID);
            }
            else
            {
                testDrive.TryGetValue(id, out car);
                if(car != null)
                {
                    testDrive.Remove(car.ID);
                }
                else
                {
                    Console.WriteLine("There are no cars LEFT with the ID=" + id);
                    Console.WriteLine("====================================");
                }
            }
            return car;
        }

        public int DriveTest(int id)
        {
            int randomKm = new Random().Next(50, 100);
            if (orderedCars.ContainsKey(id))
            {
                testDrive.Add(id, orderedCars[id]);
                orderedCars.Remove(id);
                Thread.Sleep(200);
                testDrive[id].Kilometraj += randomKm;
            }
            else
            {
                if (testDrive.ContainsKey(id))
                {
                    testDrive[id].Kilometraj += randomKm;
                }
                else
                {
                    Console.WriteLine("Invalid id=" + id);
                    return -1;
                }
            }

            return testDrive[id].Kilometraj;
        }

        public void StockCar()
        {
            Console.WriteLine();
            Console.WriteLine("_____________Available cars_____________");
            if (orderedCars.Count != EMPTY_DICTIONARY)
            {
                Console.WriteLine("--------------Ordered cars--------------");
                foreach (KeyValuePair<int, Car> car in orderedCars)
                {
                    Console.WriteLine(car.Value.ToString());
                }
            }
            if (testDrive.Count != EMPTY_DICTIONARY)
            {
                Console.WriteLine("--------------Cars for testing--------------");
                foreach (KeyValuePair<int, Car> car in testDrive)
                {
                    Console.WriteLine(car.Value.ToString());
                }
            }
            Console.WriteLine();
        }
    }
}
