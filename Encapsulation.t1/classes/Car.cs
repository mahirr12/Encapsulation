using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9.classes
{
    public class Car
    {
        public int Id { get; private set; }

        public string Name { get; set; }
        public double Speed { get; set; }

        public string CarCode { get; private set; }
        public Car(string name, ref int count)
        {
            Name = name;
            Id = count;
            CarCode = "" + char.ToUpper(Name[0]) + char.ToUpper(Name[1]) + (count++ + 1000);
            
        }
    }
}
