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
            Console.WriteLine("Podaj wspolczynniki a, b, c rownania ax^2+bx+c:");
            double a, b, c, delta;
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            delta = b * b - 4 * a * c;
            if (delta > 0)
                Console.WriteLine("Rownanie {0}x^2+{1}x+{2} ma dwa pierwiastki", a, b, c);
            if (delta == 0)
                Console.WriteLine("Rownanie {0}x^2+{1}x+{2} ma jeden pierwiastek", a, b, c);
            if (delta < 0)
                Console.WriteLine("Rownanie {0}x^2+{1}x+{2} nie ma pierwiastkow", a, b, c);

            Console.ReadKey();
        }
    }
}
