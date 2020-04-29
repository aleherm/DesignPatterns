using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_Observer
{
    interface ISubscriber
    {
        string Name { get; set; }

        void Update(List<Product> products);
    }
}
