using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_FlyWeight
{
    class Program
    {
        static void Main(string[] args)
        {
            Cashier cashier = new Cashier();
            cashier.CashIn(10, EMoneyType.Paper);
            cashier.CashIn(100, EMoneyType.Paper);
            cashier.CashIn(0.1, EMoneyType.Coin);
            cashier.CashIn(135, EMoneyType.Card);

            Console.WriteLine(cashier.GetTotalCache());
        }
    }
}
