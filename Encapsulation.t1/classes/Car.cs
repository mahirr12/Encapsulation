using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9.classes
{
    public class Car
    {
        public int Id { get; set; }
        private static int count = 1;
        public string Name { get; set; }
        public double Speed { get; set; }
        private string _carCode;
        public string CarCode
        {
            get => _carCode;
            private set
            {
                _carCode = "" + char.ToUpper(Name[0]) + char.ToUpper(Name[1]) + (count + 1000);
            }
        }
        public Car(string name)
        {
            Name = name;
            CarCode = string.Empty;
            count++;
        }
    }
}
