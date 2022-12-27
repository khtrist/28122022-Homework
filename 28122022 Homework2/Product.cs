using System;
using System.Collections.Generic;
using System.Text;

namespace _28122022_Homework2
{
    internal class Product
    {
        public Product(string name, double price ,string datetime ,string value)
        {
            this.Name = name;
            this.Price = price;
            this.DateTime = datetime;   
            this.Value = value; 

        }
        public Product(string value)
        {
            this.Value = value; 
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public Product(string name, double price, string datetime) : this(name, price)
        {
        }

        public string Name;
        public double Price;
        

        public string DateTime { get; }
        public string Value { get; }

    }
}
