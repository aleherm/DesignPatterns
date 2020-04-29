using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            ICar basicCar = new BasicCar();
            basicCar.Assemble("blue", "diesel");
            basicCar.SetAccessories();
            Console.WriteLine("Basic car:");
            Console.WriteLine(basicCar.ToString());

            CarDecorator accessDeco = new AccessDecorator(basicCar);
            Console.WriteLine("\nBasic car with access decorations:");
            Console.WriteLine(basicCar.ToString());

            CarDecorator laureatDeco = new LaureateDecorator(basicCar);
            Console.WriteLine("\nBasic car with access & laureate decorations");
            Console.WriteLine(basicCar.ToString());

            CarDecorator ambianceDeco = new AmbianceDecorator(basicCar);
            Console.WriteLine("\nBasic car with access, laureate & ambiance decorations");
            Console.WriteLine(basicCar.ToString());
        }
    }
}
