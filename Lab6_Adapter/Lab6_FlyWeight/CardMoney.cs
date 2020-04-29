using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_FlyWeight
{
    class CardMoney : Money
    {
        public override EMoneyType GetMoneyType()
        {
            return EMoneyType.Card;
        }
    }
}
