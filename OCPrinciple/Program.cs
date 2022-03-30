using OCPrinciple.BAD;
using System;

namespace OCPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            BadCoffee coffee = new BadCoffee();

            double tutar = coffee.TutarHesapla(CoffeeType.TurkKahvesi,2);
            Console.WriteLine("Toplam tutar: {0}",+tutar);
        }
    }
}
