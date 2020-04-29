using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Proxy
{
    interface IAccount
    {
        void Deposit(double amount);
        bool Withdraw(double amount);
        void DisplayBalance();
    }
}
