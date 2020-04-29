using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            CarBuildDirector carBuildDirector = new CarBuildDirector(new CarBuilder());

            carBuildDirector.Construct();
            Car car1 = carBuildDirector.GetResult();
            Car car2 = car1.Clone();
            car2.Color.Color = "Blue";

            Console.WriteLine(car1.ToString());
            Console.WriteLine();
            Console.WriteLine(car2.ToString());
            Console.WriteLine();

            car1.Color.Color = "Brown";
            
            Console.WriteLine(car1.ToString());
            Console.WriteLine();
            Console.WriteLine(car2.ToString());
            Console.WriteLine();
        }
    }
}
