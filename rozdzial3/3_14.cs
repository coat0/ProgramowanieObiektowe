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
            Console.WriteLine("Podaj dowolna liczbe naturalna: ");
            int n = Convert.ToInt16(Console.ReadLine());
            int i, j, k, temp;
            for(i = 0; i < n; i++)
            {
                temp = 0;
                for(j = 1; j<i; j++)
                {
                    if (i % j == 0)
                    {
                        temp = temp + j;
                    }
                }
                if (temp == i && temp != 0)
                    Console.WriteLine("{0} jest liczba doskonala", i);
            }

            Console.ReadKey();
        }
    }
}
