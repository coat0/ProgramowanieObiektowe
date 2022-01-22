using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211128
{
    class Car
    {
        private string marka;
        private int rok;
        private string model;
        private int iloscDrzwi;
        private double pojemnoscSilnika;
        public double srednieSpalanie;

        public Car(string x, int y)
        {
            if (y > 1769 && y < 2017)
            {
                marka = x;
                rok = y;
            }
            else
            {
                Console.WriteLine("Podałeś zły rok");
            }
        }

        public void ShowCar()
        {
            Console.WriteLine("Marka: {0, -10} Rok produkcji: {1}", marka, rok);
        }

        private double ObliczSpalanie(double road)
        {
            double spalanie = (srednieSpalanie * road);
            return spalanie;
        }

        public double ObliczKosztPrzejazdu(double road, double price)
        {
            double koszt = ObliczSpalanie(road) * price;
            return koszt;
        }
    }
}
