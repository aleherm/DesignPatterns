using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_State
{
    class HasCoinState : State
    {
        public override bool BuyProduct()
        {
            if(Machine.IsEmpty())
            {
                Console.WriteLine("Is empty!");
                return false;
            }

            Machine.SetMachineState(Machine.SoldState);
            return true;
        }

        public override bool Dispence()
        {
            Console.WriteLine("Not dispenced yet.");
            return false;
        }

        public override bool EjectCoin()
        {
            Machine.SetMachineState(Machine.NoCoinState);
            return false;
        }

        public override bool InsertedCoin()
        {
            return false;
        }
    }
}
