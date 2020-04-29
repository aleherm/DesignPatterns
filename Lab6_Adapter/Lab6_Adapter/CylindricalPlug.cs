using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Adapter
{
    class CylindricalPlug
    {
        private string _firstWire;
        private string _secondWire;

        public CylindricalPlug(string firstWire, string secondWire)
        {
            _firstWire = firstWire;
            _secondWire = secondWire;
        }

        public string GetPowerSupply(EAdapterType type)
        {
            string power = null;
            switch(type)
            {
                case EAdapterType.eClassAdapter:
                    CylindricalClassAdapter classAdapter = new CylindricalClassAdapter();
                    power = classAdapter.GetPowerSupply(_firstWire, _secondWire);
                    break;
                case EAdapterType.eObjectAdapter:
                    CylindricalObjectAdapter objectAdapter = new CylindricalObjectAdapter(new RectangularSocket());
                    power =  objectAdapter.GetPowerSupply(_firstWire, _secondWire);
                    break;
                default:
                    power = "Error!";
                    break;
            }

            return power;
        }
    }
}
