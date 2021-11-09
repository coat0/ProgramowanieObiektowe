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
            int i, j, k, l, szereg;
            szereg = 0;
            j = 1;
            l = 1;
            for(i = 0; i<n; i++)
            {
                szereg = szereg + j;
                l = l * (-1);
                j = j * (-1);
                j = j + l;

            }
            Console.WriteLine("Suma tego szeregu wynosi {0}.", szereg);
            Console.ReadKey();
        }
    }
}
