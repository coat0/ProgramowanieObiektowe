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
            Console.WriteLine("Wpisz nr dnia tygodnia");
            string numer = Console.ReadLine();
            switch (numer)
            {
                case "1":
                    Console.WriteLine("Poniedzialek");
                    break;
                case "2":
                    Console.WriteLine("Wtorek");
                    break;
                case "3":
                    Console.WriteLine("Sroda");
                    break;
                case "4":
                    Console.WriteLine("Czwartek");
                    break;
                case "5":
                    Console.WriteLine("Piatek");
                    break;
                case "6":
                    Console.WriteLine("Sobota");
                    break;
                case "7":
                    Console.WriteLine("Niedziela");
                    break;
                default:
                    Console.WriteLine("Nie ma takiego dnia tygodnia");
                    break;
            }
            Console.ReadKey();
        }
    }
}
