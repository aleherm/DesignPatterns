using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_Observer
{
    class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }

        public Product(string name, string description, double price, int count)
        {
            Name = name;
            Description = description;
            Price = price;
            Count = count;
        }

        public override bool Equals(object obj)
        {
            Product product = obj as Product;
            if (product == null)
                return false;
            if (product.Name != this.Name || product.Description != this.Description || product.Price != this.Price)
                return false;
            return true; 
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return Name + " | " + Description + " | " + Price + " | " + "Items: " + Count;
        }
    }
}
