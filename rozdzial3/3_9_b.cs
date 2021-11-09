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
            Console.WriteLine("Podaj liczbe wierszy:");
            int wiersze = Convert.ToInt16(Console.ReadLine());
            int i, j;
            for(i = wiersze; i>0; i--)
            {
                for (j = 0; j < i; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
