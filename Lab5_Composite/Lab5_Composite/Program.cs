using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Branch tree = new Tree("tree");

            Branch branch1 = new Branch("Branch1");
            Leaf leaf1 = new Leaf("L1");
            branch1.Add(leaf1);
            branch1.Add(new Leaf("L2"));

            Branch branch2 = new Branch("Branch2");
            branch2.Add(new Leaf("L3"));
            branch2.Add(new Leaf("L4"));

            Branch branch3 = new Branch("Branch3");
            branch3.Add(new Leaf("L5"));
            branch3.Add(new Leaf("L6"));
            branch2.Add(branch3);
            //branch1.Add(branch2);

            tree.Add(branch1);
            tree.Add(branch2);

            branch1.Remove(leaf1);
            

            tree.Display(0);
        }
    }
}
