using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_FlyWeight
{
    class CoinMoney : Money
    {
        public override EMoneyType GetMoneyType()
        {
            return EMoneyType.Coin;
        }

        public static bool IsSharedValue(double value)
        {
            return (value == 0.01 || value == 0.05 || value == 0.1 || value == 0.5);
        }
    }
}
