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
            Console.WriteLine("Podaj dwie liczby:");
            double pierwsza, druga, wynik;
            wynik = 0;
            char znak;
            pierwsza = Convert.ToDouble(Console.ReadLine());
            druga = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj znak dzialania(+ lub - lub * lub /):");
            znak = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if (druga == 0 && znak == '/')
                Console.WriteLine("NIE MOZNA DZIELIC PRZEZ 0!!!");
            else
            {
                switch (znak)
                {
                    case '+':
                        wynik = pierwsza + druga;
                        break;
                    case '-':
                        wynik = pierwsza - druga;
                        break;
                    case '*':
                        wynik = pierwsza * druga;
                        break;
                    case '/':
                        wynik = pierwsza / druga;
                        break;
                }
                Console.WriteLine("{0} {1} {2} = {3}", pierwsza, znak, druga, wynik);
            }
            Console.ReadKey();
        }
    }
}
