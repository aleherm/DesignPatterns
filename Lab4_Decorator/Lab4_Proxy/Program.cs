using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            SafeAccountProxy proxy = new SafeAccountProxy();
            proxy.Activate("admin", "1234");

            proxy.Deposit(10);
            proxy.DisplayBalance();
            int amount = 9;
            if (proxy.Withdraw(amount))
            {
                Console.WriteLine("The amount of " + amount + " UM have been withdrawn");
            }

        }
    }
}
