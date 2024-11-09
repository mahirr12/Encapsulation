using ConsoleApp9.classes;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //   1.Tapşırıq:
            //==================
            //Car class
            //==================
            //Id, 
            //Name,
            //Speed,
            //CarCode - Car adının ilk 2 hərfi böyük və 1000 üzərindən neçənci yaranıbsa o yazılır.   (LA1001,ME1002)

            //===================
            //Gallery class
            //===================
            //Id,
            //Name,
            //Cars - Car type`da array,

            //AddCar() - Car objecti qebul edib array'e add edir,
            //ShowAllCars() - Arraydeki butun Carlari gosterir,
            //GetAllCars() - Arraydeki butun Carlari qaytarir,
            //FindCarById() - verilmis id-e uygun olan car'i tapib qaytarir,
            //FindCarByCarCode() - CarCode uygun olan car'i tapib qaytarir,
            //FindCarsBySpeedInterval() - max ve min speed qebul edib bu suret araligindaki car'lari geri    qaytarir

            //minimum 3 Car obyekti yaradırsınız və Gallery`ə əlavə edib methodları yoxlayırsınız.
            Gallery gal1 = new Gallery();
            int count = 1;

            Car car1 = new Car("BMW", ref count);
            Car car2 = new Car("Mercedes", ref count);
            Car car3 = new Car("Honda", ref count);
            car1.Speed = 211.4;
            car2.Speed = 203.7;
            car3.Speed = 299.2;

            gal1.AddCar(car1);
            gal1.AddCar(car2);
            gal1.AddCar(car3);
            gal1.ShowAllCars();
            foreach (var item in gal1.GetAllCars())
            {
                Console.WriteLine(item.Name);
            }
            var wanted1 = gal1.FindCarById(2);
            if (wanted1 != null) Console.WriteLine(wanted1.CarCode);
            else Console.WriteLine("Bele car obyekti yoxdur");

            var wanted2 = gal1.FindCarByCarCode("HO1003");
            if (wanted2 != null) Console.WriteLine(wanted2.Name);
            else Console.WriteLine("Bele car obyekti yoxdur");
            foreach (var item in gal1.FindCarsBySpeedInterval(210, 250))
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
