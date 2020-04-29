using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_State
{
    class NoCoinState : State
    {
        public override bool BuyProduct()
        {
            Console.WriteLine("No coin!");
            return false;
        }

        public override bool Dispence()
        {
            Console.WriteLine("No coin!");
            return false;
        }

        public override bool EjectCoin()
        {
            Console.WriteLine("No coin!");
            return false;
        }

        public override bool InsertedCoin()
        {
            Machine.SetMachineState(Machine.HasCoinState);
            return true;
        }
    }
}
