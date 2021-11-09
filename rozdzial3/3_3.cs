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
            Console.WriteLine("Podaj trzy liczby calkowite:");
            int pierwsza, druga, trzecia;
            pierwsza = Convert.ToInt16(Console.ReadLine());
            druga = Convert.ToInt16(Console.ReadLine());
            trzecia = Convert.ToInt16(Console.ReadLine());
            if (pierwsza > druga) {
                if (pierwsza > trzecia)
                    Console.WriteLine("Liczba {0} jest wieksza od {1} i {2}", pierwsza, druga, trzecia);
                else
                    Console.WriteLine("Liczba {2} jest wieksza od {0} i {1}", pierwsza, druga, trzecia);
            }
            else if (druga>trzecia)
                Console.WriteLine("Liczba {1} jest wieksza od {0} i {2}", pierwsza, druga, trzecia);
            else
                Console.WriteLine("Liczba {2} jest wieksza od {0} i {1}", pierwsza, druga, trzecia);
            Console.ReadKey();
        }
    }
}
