using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        private double _price;
        public double Price
        {
            get { return _price; }
            set
            {
                if (value > 0) _price = value;
                else _price = 0;
            }
        }

        private int _count;
        public int Count
        {
            get { return _count; }
            set
            {
                if (value >= 0) _count = value;
                else _count = 0;
            }
        }

        public Product(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
        public Product(int id, string name, double price, int count) : this(id, name, price)
        {
            Count = count;
        }
    }
}
