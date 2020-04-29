using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_AbstractFactory
{
    abstract class Car
    {
        public int ID;
        public int Kilometraj;

        protected int price;
        protected string brand;
        protected string color;
        
        public Car(int id, string brand, string color, int price)
        {
            ID = id;
            this.brand = brand;
            this.color = color;
            this.price = price;
            Kilometraj = 0;
        }

        public override string ToString()
        {
            return "[" + ID + "] Brand:" + this.brand + " | Color:" + this.color + " | Price:" + this.price + " | Km:" + Kilometraj;
        }

        public abstract ECarType Type();
    }
}
