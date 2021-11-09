using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cwiczenia3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj swoja srednia ocen:");
            double srednia = Convert.ToDouble(Console.ReadLine());
            if (srednia >= 2 && srednia < 4)
                Console.WriteLine("Kwota stypendium: 0,00 zl");
            else if (srednia >= 4 && srednia < 4.8)
                Console.WriteLine("Kwota stypendium: 350,00 zl");
            else if (srednia >= 4.8 && srednia <5.01)
                Console.WriteLine("Kwota stypendium: 550,00 zl");
            else
                Console.WriteLine("Podales zla srednia");
            Console.ReadKey();
        }
    }
}
