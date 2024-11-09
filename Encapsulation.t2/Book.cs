using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Book : Product
    {
        public string Genre { get; set; }
        public Book(int id, string name, double price, string genre) : base(id, name, price)
        {
            Genre = genre;
        }
        public Book(int id, string name, double price, int count, string genre) : base(id, name, price, count)
        {
            Genre = genre;
        }
    }
}
