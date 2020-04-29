using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            IOnlineStore store = new OnlineStore();

            Product prod1 = new Product("p1", "descr1", 10, 1);
            Product prod2 = new Product("p2", "descr121", 20, 2);
            Product prod3 = new Product("p3", "descr3", 30, 3);
            Product prod4 = new Product("p4", "descr4", 40, 4);

            List<Product> products = new List<Product> { prod1, prod2, prod3, prod4};
            store.AddProducts(products);

            ISubscriber sub1 = new Subscriber("sub1");
            ISubscriber sub2 = new Subscriber("sub2");
            ISubscriber sub3 = new Subscriber("sub3");
            ISubscriber sub4 = new Subscriber("sub4");

            store.Subscribe(sub1);
            store.Subscribe(sub2);
            store.Subscribe(sub3);
            store.Subscribe(sub4);
            
            Product prod5 = new Product("p5", "descr5", 50, 5);
            Product prod6 = new Product("p6", "descr6", 60, 6);

            products = new List<Product> { prod5, prod6 };
            store.AddProducts(products);

            store.UnSubscribe(sub1);

            Product prod7 = new Product("p7", "descr7", 70, 7);
            Product prod8 = new Product("p8", "descr8", 80, 8);

            products = new List<Product> { prod7, prod8 };
            store.AddProducts(products);

        }
    }
}
