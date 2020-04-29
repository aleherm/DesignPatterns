using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_2
{
    class Program
    {
        static void Main(string[] args)
        {
            IBeerMachine proxy = new BeerMachineProxy();
            int age = proxy.ScanID(new DateTime(2005, 7, 2));
            proxy.GetBeer(age);
        }
    }
}
