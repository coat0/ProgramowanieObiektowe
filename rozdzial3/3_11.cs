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
            int suma, i, j;
            j = 0;
            suma = 0;
            for (i = 1; suma < 100; i++)
            {
                suma = suma + i;
                if (suma > 100)
                    j = i;
            }
            Console.WriteLine("Trzeba dodac do siebie {0} liczb calkowitych aby przekroczyc wartosc 100", j);
            Console.ReadKey();
        }
    }
}
