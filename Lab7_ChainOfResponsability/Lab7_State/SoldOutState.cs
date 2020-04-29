using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_State
{
    class SoldOutState : State
    {
        public override bool BuyProduct()
        {
            Console.WriteLine("Sold out!");
            return false;
        }

        public override bool Dispence()
        {
            Console.WriteLine("Sold out!");
            return false;
        }

        public override bool EjectCoin()
        {
            Console.WriteLine("Sold out!");
            return false;
        }

        public override bool InsertedCoin()
        {
            Console.WriteLine("Sold out!");
            return false;
        }
    }
}
