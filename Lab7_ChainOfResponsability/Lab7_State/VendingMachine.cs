using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_State
{
    class VendingMachine
    {
        private int capacity;
        private State machineState;

        public State SoldState { get; set; }
        public State SoldOutState { get; set; }
        public State NoCoinState { get; set; }
        public State HasCoinState { get; set; }

        public VendingMachine()
        {
            this.capacity = 0;
            SoldState = new SoldState();
            SoldOutState = new SoldOutState();
            NoCoinState = new NoCoinState();
            HasCoinState = new HasCoinState();
            machineState = SoldOutState;
            SoldState.Machine = this;
            SoldOutState.Machine = this;
            NoCoinState.Machine = this;
            HasCoinState.Machine = this;
        }

        public void UpdateState(EUserOption option)
        {
            switch(option)
            {
                case EUserOption.InsertCoin:
                    InsertCoin();
                    break;
                case EUserOption.EjectCoin:
                    EjectCoin();
                    break;
                case EUserOption.BuyProduct:
                    BuyProduct();
                    break;
                case EUserOption.FillMachine:
                    ReFill();
                    break;
                case EUserOption.InspectMachine:
                    Inspect();
                    break;
            }
        }

        public bool IsEmpty()
        {
            if (capacity <= 0)
                return true;
            return false;
        }

        public void SetMachineState(State state)
        {
            machineState = state;
        }

        private void ReFill()
        {
            capacity += 1;
            machineState = NoCoinState;
        }

        private bool InsertCoin()
        {
            if(this.IsEmpty())
            {
                Console.WriteLine("Empty machine! Should refill.");
                return false;
            }
            return machineState.InsertedCoin();
        }

        private bool EjectCoin()
        {
            Console.WriteLine("Coin ejected!");
            return machineState.EjectCoin();
        }

        private bool BuyProduct()
        {
            if (machineState.BuyProduct())
            {
                capacity--;
                machineState.Dispence();
                return true;
            }
            return false;
        }

        private bool Inspect()
        {
            if (!IsEmpty())
            {
                Console.WriteLine("Current capacity: " + capacity);
                return true;
            }

            Console.WriteLine("Empty!");
            return false;
        }
    }
}
