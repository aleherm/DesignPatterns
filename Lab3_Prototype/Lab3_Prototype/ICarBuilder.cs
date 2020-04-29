using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Prototype
{
    interface ICarBuilder
    {
        void SetModel(ECarModel model);
        void SetColor(CarColor color);
        void SetEngine(EEngineType type);
        Car GetCar();
    }
}
