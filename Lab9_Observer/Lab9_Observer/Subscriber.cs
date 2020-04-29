using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_Observer
{
    class Subscriber : ISubscriber
    {
        public string Name { get; set; }

        public Subscriber(string name)
        {
            Name = name;
        }

        public void Update(List<Product> products)
        {
            Console.WriteLine("Subscriber [" + Name + "] got notified for:");
            foreach (Product product in products)
                Console.WriteLine(product);
            Console.WriteLine();
        }
    }
}
