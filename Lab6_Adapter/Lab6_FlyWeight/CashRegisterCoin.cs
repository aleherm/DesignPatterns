using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_FlyWeight
{
    class CashRegisterCoin : CashRegister
    {
        public override Money CreateNewMoney()
        {
            return new CoinMoney();
        }

        public override bool IsSharedValue(double value)
        {
            return CoinMoney.IsSharedValue(value);
        }
    }
}
