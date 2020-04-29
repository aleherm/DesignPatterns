using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Decorator
{
    class LaureateDecorator : CarDecorator
    {
        public LaureateDecorator(ICar car) : base(car)
        {
            DecoratedCar.Type = ECarType.LAUREAT;
            SetAccessories();
        }

        public override void SetAccessories()
        {
            DecoratedCar.Accessories += 1100;
        }
    }
}
