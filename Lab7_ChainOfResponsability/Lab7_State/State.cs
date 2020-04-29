using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_State
{
    abstract class State
    {
        public VendingMachine Machine { get; set; }

        public abstract bool InsertedCoin();
        public abstract bool EjectCoin();
        public abstract bool BuyProduct();
        public abstract bool Dispence();
    }
}
