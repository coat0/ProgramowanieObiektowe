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
            int i, j, k;
            for(i = 0; i < wiersze; i++)
                Console.Write("*");
            Console.WriteLine();
            for(j = 0; j < wiersze - 2; j++)
            {
                Console.Write("*");
                for (k = 0; k < wiersze - 2; k++)
                    Console.Write(" ");
                Console.Write("*");
                Console.WriteLine();
            }
            for (i = 0; i < wiersze; i++)
                Console.Write("*");
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
