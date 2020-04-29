using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            CarBuildDirector carBuildDirector = new CarBuildDirector(new CarBuilder());

            carBuildDirector.Construct();
            Car car = carBuildDirector.GetResult();
            Console.WriteLine(car.ToString());
        }
    }
}
