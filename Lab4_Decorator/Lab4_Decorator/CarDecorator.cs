using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Decorator
{
    abstract class CarDecorator : ICar
    {
        protected ICar DecoratedCar;

        public CarDecorator(ICar car)
        {
            DecoratedCar = car;
        }

        public ECarType Type { get => DecoratedCar.Type; set => DecoratedCar.Type = value; }
        public string Color { get => DecoratedCar.Color; set => DecoratedCar.Color = value; }
        public string Motorization { get => DecoratedCar.Motorization; set => DecoratedCar.Motorization = value; }
        public int Accessories { get => DecoratedCar.Accessories; set => DecoratedCar.Accessories = value; }

        public void Assemble(string color, string motorization)
        {
            DecoratedCar.Assemble(color, motorization);
        }

        public abstract void SetAccessories();

        public void ToString()
        {
            base.ToString();
        }
    }
}
