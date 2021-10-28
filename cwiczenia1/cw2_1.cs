using System;

namespace cwiczenia1
{
    class Program
    {
        static void Main(string[] args)
        {
            double tempc, tempf;
            Console.WriteLine("Podaj temperature w stopniach Celsjusza:");
            tempc = double.Parse(Console.ReadLine());
            tempf = tempc * 9 / 5 + 32;
            Console.WriteLine("Temperatura w C: " + tempc + " Temperatura w F: " + tempf);
            Console.ReadKey();
        }
    }
}
