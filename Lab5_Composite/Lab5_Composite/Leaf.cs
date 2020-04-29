using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Composite
{
    class Leaf : Vegetation
    {
        public Leaf(string name) : base(name)
        {  }

        public override void Add(Vegetation veg)
        {
            throw new NotImplementedException();
        }

        public override bool Remove(Vegetation veg)
        {
            throw new NotImplementedException();
        }

        public override void Display(int i)
        {
            Console.WriteLine($"{new String('*', i)} ({Name}) [{ParentName}]");
        }
    }
}
