using OCPrinciple.BAD;
using OCPrinciple.Validate.Absract;
using OCPrinciple.Validate.Concrete;
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

            ICoffee Kahve = new Latte();
            ICoffee Kahve1 = new TurkKahvesi();
            ICoffee Kahve2 = new Expresso();
            ICoffee Kahve3 = new SogukKahve();

            ILogger logger = new FileLogger();
            logger.LogYaz();
            ILogger logger1 = new SMSLogger();
            logger1.LogYaz();


        }
    }
}
