using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Composite
{
    class Tree : Branch
    {
        public Tree(string name) : base(name)
        { }

        public override void Display(int i)
        {
            base.Display(i);
        }
    }
}
