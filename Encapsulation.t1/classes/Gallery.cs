using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9.classes
{
    public class Gallery
    {
        public int Id { get; set; }
        public string Name { get; set; }
        private Car[] Cars = new Car[0];
        public void AddCar(Car car)
        {
            Array.Resize(ref Cars, Cars.Length + 1);
            Cars[^1] = car;
        }
        public void ShowAllCars()
        {
            foreach (Car car in Cars)
            {
                Console.WriteLine(car.CarCode);
            }
        }
        public Car[] GetAllCars() => Cars;
        public Car FindCarById(int id)
        {
            foreach (Car car in Cars)
            {
                if (car.Id == id) return car;
            }
            return null;
        }
        public Car FindCarByCarCode(string carCode)
        {
            foreach (Car car in Cars)
            {
                if (car.CarCode == carCode) return car;
            }
            return null;
        }
        public Car[] FindCarsBySpeedInterval(double min, double max)
        {
            Car[] FindedCars = new Car[0];
            foreach (Car car in Cars)
            {
                if (car.Speed >= min && car.Speed <= max)
                {
                    Array.Resize(ref FindedCars, FindedCars.Length + 1);
                    FindedCars[^1] = car;
                }
            }
            return FindedCars;
        }
    }
}
