using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Decorator
{
    class AmbianceDecorator : CarDecorator
    {
        public AmbianceDecorator(ICar car) : base(car)
        {
            DecoratedCar.Type = ECarType.ACCESS;
            SetAccessories();
        }

        public override void SetAccessories()
        {
            DecoratedCar.Accessories += 900;
        }
    }
}
