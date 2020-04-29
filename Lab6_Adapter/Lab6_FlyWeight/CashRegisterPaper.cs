using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_FlyWeight
{
    class CashRegisterPaper : CashRegister
    {
        public override Money CreateNewMoney()
        {
            return new CardMoney();
        }

        public override bool IsSharedValue(double value)
        {
            return PaperMoney.IsSharedValue(value);
        }
    }
}
