using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Prototype
{
    [Serializable]
    class CarColor
    {
        public string Color { private get; set; }

        public CarColor(string color)
        {
            Color = color;
        }

        public override string ToString()
        {
            return Color;
        }
    }
}
