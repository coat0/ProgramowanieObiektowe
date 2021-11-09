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
            double Masa, Wzrost, BMI;
            Console.WriteLine("Podaj swoj wzrost w metrach:");
            Wzrost = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj swoja wage w kilogramach:");
            Masa = double.Parse(Console.ReadLine());
            BMI = Masa / (Wzrost * Wzrost);
            if(BMI < 18.5)
                Console.WriteLine("Twoje BMI wynosi {0:F1} co oznacza niedowage.", BMI);
            else if (BMI > 25)
                Console.WriteLine("Twoje BMI wynosi {0:F1} co oznacza nadwage", BMI);
            else
                Console.WriteLine("Twoje BMI wynosi {0:F1} co oznacza prawidlowa wage", BMI);
            Console.ReadKey();
        }
    }
}
