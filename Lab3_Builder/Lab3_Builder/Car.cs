using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Builder
{
    class Car
    {
        public string Color { private get;  set; }
        public ECarModel Model { private get;  set; }
        public EEngineType Engine { private get; set; }
        public bool IsClone { private get; set; }

        public override string ToString()
        {
            return "______________New car built______________\nModel:" + Model + " | Color:" + Color + " | Engine:" + Engine;
        }
    }
}
