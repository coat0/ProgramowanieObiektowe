using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211128
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Opel", 1999);
            car1.ShowCar();
            /*Car car2 = new Car("Mercedes", 2015);
            car2.ShowCar();
            car1 = car2;
            car1.ShowCar();
            car2.ShowCar();*/
            Console.ReadKey();
        }
    }
}
