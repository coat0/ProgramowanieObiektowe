using System;

namespace cwiczenia1
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, Delta;
            Console.WriteLine("Podaj wspolczynnik A:");
            A = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wspolczynnik B:");
            B = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wspolczynnik C:");
            C = double.Parse(Console.ReadLine());
            Delta = B * B - 4 * A * C;
            Console.WriteLine("Delta tego rownania wynosi:" + Delta);
            Console.ReadKey();
        }
    }
}
