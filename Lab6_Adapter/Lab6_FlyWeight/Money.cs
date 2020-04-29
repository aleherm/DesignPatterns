using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_FlyWeight
{
    abstract class Money
    {
        public double TotalCacheValue { get; set; }
        public Money()
        {
            TotalCacheValue = 0;
        }
        public abstract EMoneyType GetMoneyType();
    }
}
