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
            Console.WriteLine("Podaj dwie liczby calkowite:");
            int pierwsza, druga;
            pierwsza = Convert.ToInt16(Console.ReadLine());
            druga = Convert.ToInt16(Console.ReadLine());
            if (pierwsza % druga == 0)
                Console.WriteLine("Liczba {0} jest dzielnikiem {1}.", druga, pierwsza);
            else
                Console.WriteLine("Liczba {0} nie jest dzielnikiem {1}.", druga, pierwsza);
            Console.ReadKey();
        }
    }
}
