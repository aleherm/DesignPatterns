using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Composite
{
    class Branch : Vegetation
    {
        private List<Vegetation> children;

        public Branch(string name) : base(name)
        {
            children = new List<Vegetation>();
        }

        public override void Add(Vegetation veg)
        {
            if (!children.Contains(veg))
            {
                veg.ParentName = this.Name;
                children.Add(veg);
            }
        }

        public override bool Remove(Vegetation veg)
        {
            return children.Remove(veg);
        }

        public override void Display(int i)
        {
            Console.WriteLine($"{new String('-', i)} ({Name}) [{ParentName}]");
            foreach(Vegetation child in children)
            {
                child.Display(i + 1);
            }
        }
    }
}
