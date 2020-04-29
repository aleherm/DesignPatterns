using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab2_AbstractFactory
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
            AbstractCarFactory carFactory;
            Car car = null;
            switch (brand)
            {
                case "MercedesBenz":
                    carFactory = new MercedesBenzCarFactory();
                    if (type == ECarType.EAuto)
                    {
                        car = carFactory.GetAutomobile(color, price);
                        orderedCars.Add(car.ID, car);
                    }
                    if (type == ECarType.ETruck)
                    {
                        car = carFactory.GetTruck(color, price);
                        orderedCars.Add(car.ID, car);
                    }
                    break;
                case "Volvo":
                    carFactory = new VolvoCarFactory();
                    if (type == ECarType.EAuto)
                    {
                        car = carFactory.GetAutomobile(color, price);
                        orderedCars.Add(car.ID, car);
                    }
                    if (type == ECarType.ETruck)
                    {
                        car = carFactory.GetTruck(color, price);
                        orderedCars.Add(car.ID, car);
                    }
                    break;
                case "Volkswagen":
                    carFactory = new VolkswagenCarFactory();
                    if (type == ECarType.EAuto)
                    {
                        car = carFactory.GetAutomobile(color, price);
                        orderedCars.Add(car.ID, car);
                    }
                    if (type == ECarType.ETruck)
                    {
                        car = carFactory.GetTruck(color, price);
                        orderedCars.Add(car.ID, car);
                    }
                    break;
                case "Renault":
                    carFactory = new RenaultCarFactory();
                    if (type == ECarType.EAuto)
                    {
                        car = carFactory.GetAutomobile(color, price);
                        orderedCars.Add(car.ID, car);
                    }
                    if (type == ECarType.ETruck)
                    {
                        car = carFactory.GetTruck(color, price);
                        orderedCars.Add(car.ID, car);
                    }
                    break;
            }
            if (car == null)
                return 0;
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
