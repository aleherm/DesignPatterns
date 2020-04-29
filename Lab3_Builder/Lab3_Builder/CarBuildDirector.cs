using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Builder
{
    class CarBuildDirector
    {
        private ICarBuilder builder;

        public CarBuildDirector(ICarBuilder carBuilder)
        {
            builder = carBuilder;
        }

        public void Construct()
        {
            builder.SetModel(ECarModel.ESedan);
            builder.SetColor("Green");
            builder.SetEngine(EEngineType.EDiesel);
        }

        public Car GetResult()
        {
            return builder.GetCar();
        }
    }
}
