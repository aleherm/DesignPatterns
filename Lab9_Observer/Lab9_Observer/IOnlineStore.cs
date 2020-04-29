using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_Observer
{
    interface IOnlineStore 
    {
        bool Subscribe(ISubscriber subscriber);
        bool UnSubscribe(ISubscriber subscriber);
        void AddProducts(List<Product> products);
        void Inventory();
    }
}
