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
            Console.WriteLine("Podaj rok:");
            int rok;
            rok = Convert.ToInt16(Console.ReadLine());
            if (rok % 4 == 0)
                Console.WriteLine("Rok {0} jest przestępny", rok);
            else
                Console.WriteLine("Rok {0} nie jest przestepny", rok);
            Console.ReadKey();
        }
    }
}
