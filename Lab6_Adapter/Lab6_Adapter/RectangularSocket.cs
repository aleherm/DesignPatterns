using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Adapter
{
    class RectangularSocket
    {
        public string GetSupply(string firstWire, string secondWire)
        {
            return firstWire + " and " + secondWire + " are now connected";
        }
    }
}
