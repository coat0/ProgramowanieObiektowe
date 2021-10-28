using System;

namespace cwiczenia1
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
            Console.WriteLine("Twoje BMI wynosi:" + BMI);
            Console.ReadKey();
        }
    }
}
