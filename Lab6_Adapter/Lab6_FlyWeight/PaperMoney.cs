using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_FlyWeight
{
    class PaperMoney : Money
    {
        public override EMoneyType GetMoneyType()
        {
            return EMoneyType.Paper;
        }

        public static bool IsSharedValue(double value)
        {
            if(value == 1 || value == 5 || value == 10 || value == 50 || value == 100 || value == 200 || value == 500)
                return true;
            return false;
        }
    }
}
