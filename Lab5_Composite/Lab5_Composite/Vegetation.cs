using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Composite
{
    abstract class Vegetation
    {
        public string Name { get; private set; }
        public string ParentName { get; set; }

        public Vegetation(string name)
        {
            Name = name;
        }

        public abstract void Add(Vegetation veg);

        public abstract bool Remove(Vegetation veg);

        public abstract void Display(int i);
    }
}
