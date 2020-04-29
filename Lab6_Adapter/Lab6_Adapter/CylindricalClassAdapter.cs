using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Adapter
{
    class CylindricalClassAdapter : RectangularSocket
    {
        public string GetPowerSupply(string firstWire, string secondWire)
        {
            return base.GetSupply(firstWire, secondWire) + " with Power from ClassAdapter";
        }
    }
}
