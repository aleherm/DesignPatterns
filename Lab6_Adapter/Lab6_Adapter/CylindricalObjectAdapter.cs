using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Adapter
{
    class CylindricalObjectAdapter
    {
        private RectangularSocket _socket;

        public CylindricalObjectAdapter(RectangularSocket socket)
        {
            _socket = socket;
        }

        public string GetPowerSupply(string firstWire, string secondWire)
        {
            return _socket.GetSupply(firstWire, secondWire) + " with Power from ObjectAdapter";
        }
    }
}
