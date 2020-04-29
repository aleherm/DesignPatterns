using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Builder
{
    interface ICarBuilder
    {
        void SetModel(ECarModel model);
        void SetColor(string color);
        void SetEngine(EEngineType type);
        Car GetCar();
    }
}
