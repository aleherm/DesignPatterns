using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_State
{
    class Program
    {
        static void Main(string[] args)
        {
            VendingMachine machine = new VendingMachine();
            machine.UpdateState(EUserOption.FillMachine);
            machine.UpdateState(EUserOption.InsertCoin);
            machine.UpdateState(EUserOption.EjectCoin);
            machine.UpdateState(EUserOption.BuyProduct);
            machine.UpdateState(EUserOption.InspectMachine);
            machine.UpdateState(EUserOption.InsertCoin);
            machine.UpdateState(EUserOption.EjectCoin);
        }
    }
}
