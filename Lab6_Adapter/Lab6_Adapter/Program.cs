using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            CylindricalPlug plug = new CylindricalPlug("first", "second");
            Console.WriteLine(plug.GetPowerSupply(EAdapterType.eClassAdapter));

            Console.WriteLine(plug.GetPowerSupply(EAdapterType.eObjectAdapter));
        }
    }
}
