using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Proxy
{
    class AccountProtected : IAccount
    {
        public double Balance { get; set; } = 0;

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void DisplayBalance()
        {
            Console.WriteLine("Available amount: " + Balance);
        }

        public bool Withdraw(double amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine("Not enough money!");
                return false;
            }
            return true;
        }
    }
}
