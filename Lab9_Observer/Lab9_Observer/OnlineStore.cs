using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_Observer
{
    class OnlineStore : IOnlineStore
    {
        private List<ISubscriber> subscribers;
        public List<Product> InventoryProducts { get; set; }

        public void AddProducts(List<Product> products)
        {
            if (InventoryProducts == null)
                InventoryProducts = new List<Product>();
            List<Product> newProducts = null; 

            foreach (Product product in products)
            {
                if (InventoryProducts.Contains(product))
                {
                    int index = InventoryProducts.IndexOf(product);
                    InventoryProducts[index].Count += product.Count;
                }
                else
                {
                    if(newProducts == null)
                        newProducts = new List<Product>();
                    InventoryProducts.Add(product);
                    newProducts.Add(product);
                }
            }
            if (newProducts != null)
                Notify(newProducts);
        }

        public void Inventory()
        {
            foreach (Product product in InventoryProducts)
                Console.WriteLine(product);
        }

        private void Notify(List<Product> products)
        {
            if(subscribers != null)
                foreach(ISubscriber subscriber in subscribers)
                {
                    subscriber.Update(products);
                }
        }

        public bool Subscribe(ISubscriber subscriber)
        {
            if (subscribers == null)
                subscribers = new List<ISubscriber>();
            if (subscribers.Contains(subscriber))
                return false;

            subscribers.Add(subscriber);
            return true;
        }

        public bool UnSubscribe(ISubscriber subscriber)
        {
            if (subscribers.Contains(subscriber) && subscribers != null)
            {
                subscribers.Remove(subscriber);
                return true;
            }
            return false;
        }
    }
}
