using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Decorator
{
    class AccessDecorator : CarDecorator
    {
        public AccessDecorator(ICar car) : base(car)
        {
            DecoratedCar.Type = ECarType.ACCESS;
            SetAccessories();
        }

        public override void SetAccessories()
        {
            DecoratedCar.Accessories += 700;
        }
    }
}
