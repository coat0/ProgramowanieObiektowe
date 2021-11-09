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
            Console.Write("Podaj n: ");
            int n = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();
            int i, j, silnia;
            silnia = 1;
            for(i = 1; i<= n; i++)
            {
                silnia = silnia * i;
            }
            Console.WriteLine("{0}! = {1}", n, silnia);
            Console.ReadKey();
        }
    }
}
