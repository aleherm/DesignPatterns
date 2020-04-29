using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Prototype
{
    class CarBuilder : ICarBuilder
    {
        private Car car;

        public CarBuilder()
        {
            car = new Car();
        }

        public Car GetCar()
        {
            return car;
        }

        public void SetColor(CarColor color)
        {
            car.Color = color;
        }

        public void SetEngine(EEngineType type)
        {
            car.Engine = type;
        }

        public void SetModel(ECarModel model)
        {
            car.Model = model;
        }
    }
}
