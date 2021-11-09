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
            Console.Write("Podawaj liczby calkowite a ja je zssumuje (napisz 0 aby przerwac): ");
            int suma = 0;
            int j = Convert.ToInt16(Console.ReadLine());
            while (j != 0)
            {
                suma = suma + j;
                j = Convert.ToInt16(Console.ReadLine());
            }


            Console.WriteLine("Suma twoich liczb to {0}", suma);
            Console.ReadKey();
        }
    }
}
