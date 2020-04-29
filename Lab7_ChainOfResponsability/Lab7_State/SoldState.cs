using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_State
{
    class SoldState : State
    {
        public override bool BuyProduct()
        {
            return false;
        }

        public override bool Dispence()
        {
            if(Machine.IsEmpty())
            {
                Machine.SetMachineState(Machine.SoldOutState);
                return false;
            }
            Machine.SetMachineState(Machine.NoCoinState);
            return true;
        }

        public override bool EjectCoin()
        {
            return false;
        }

        public override bool InsertedCoin()
        {
            return false;
        }
    }
}
