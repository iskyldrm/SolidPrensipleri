using IOC_WindsorCastel.Abstracts;
using IOC_WindsorCastel.Concrete;
using System;
using System.Threading;

namespace IOC_WindsorCastel
{
    class Program
    {
        static void Main(string[] args)
        {

            IOCContainer.TasitFactory();

            //ITasit toyota = new Araba();
            //ITasit mercedes = new Otobus();


            //Sofor ali = new Sofor(toyota);
            //Sofor veli = new Sofor(mercedes);

            //ali.Kullan();
            //veli.Kullan();

            var toyota = IOCContainer.ResolveTasit<ITasit>("Araba");
            //Console.WriteLine(toyota.ToString());
            var mercedes = IOCContainer.ResolveTasit<ITasit>("Otobus");
            Console.WriteLine(mercedes.ToString());
            var volvo = IOCContainer.ResolveTasit<ITasit>("Kamyon");
            var Tofas = IOCContainer.ResolveTasit<ITasit>("Araba");
            var TP = IOCContainer.ResolveTasit<ITasit>("Otobus");
            Console.WriteLine(TP.ToString());
           // Console.WriteLine(Tofas.ToString());

            Console.WriteLine("Hello World!");

            Console.WriteLine("Hello World!");
        }
    }
}
