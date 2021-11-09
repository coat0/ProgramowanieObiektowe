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
            for(i = 0; i<wiersze; i++)
            {
                for (k = wiersze - i - 1; k>0 ; k--)
                    Console.Write(" ");
                for (j = 0; j <= i; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
