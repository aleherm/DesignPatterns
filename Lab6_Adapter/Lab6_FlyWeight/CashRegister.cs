using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_FlyWeight
{
    abstract class CashRegister
    {
        private Dictionary<double, Money> _sharedMoneyMap = new Dictionary<double, Money>();
        private Money _unsharedMoney;

        protected Money Lookup(double value)
        {
            if (IsSharedValue(value))
            {
                Money money;
                if (_sharedMoneyMap.TryGetValue(value, out money))
                {
                    return money;
                }
                else
                {
                    _sharedMoneyMap.Add(value, this.CreateNewMoney());
                    return _sharedMoneyMap[value];
                }
            }
            else
            {
                if (_unsharedMoney == null)
                    _unsharedMoney = this.CreateNewMoney();
                return _unsharedMoney;
            }

        }

        public void CashIn(double value)
        {
            Lookup(value).TotalCacheValue += value;
        }

        public void CashOut(double value)
        {
            Money money = Lookup(value);
            if (money.TotalCacheValue >= value)
                money.TotalCacheValue -= value;
            else
                Console.WriteLine("Not enough money of type " + money.GetMoneyType());
        }

        public double GetTotalCache()
        {
            double totalMoney = 0;
            foreach(KeyValuePair<double, Money> box in _sharedMoneyMap)
            {
                totalMoney += box.Value.TotalCacheValue;
            }
            if (_unsharedMoney != null)
                totalMoney += _unsharedMoney.TotalCacheValue;

            return totalMoney;
        }

        public abstract bool IsSharedValue(double value);
        public abstract Money CreateNewMoney();
    }
}
