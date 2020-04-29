using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Proxy
{
    class SafeAccountProxy : IAccount
    {
        private IAccount RealSubject = null;
        private string Password { get; set; } = "admin";

        public bool Activate(string oldPass, string newPass)
        {
            if (!oldPass.Equals(Password))
            {
                Console.WriteLine("Problems at changing the password!");
                return false;
            }

            Password = newPass;
            Console.WriteLine("The password have been successfuly changed!");
            RealSubject = new AccountProtected();
            return true;
        }

        public void Deposit(double amount)
        {
            if(RealSubject != null)
                RealSubject.Deposit(amount);
        }

        public void DisplayBalance()
        {
            if (RealSubject != null)
                RealSubject.DisplayBalance();
        }

        public bool Withdraw(double amount)
        {
            bool isOk = false;
            if (RealSubject != null)
                isOk = RealSubject.Withdraw(amount);
            return isOk;
        }
    }
}
