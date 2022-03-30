using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPrinciple.BAD
{    
    public enum CoffeeType
     {
         TurkKahvesi,
         Expresso,
         Latte
     }

    
    public class BadCoffee
    {
        

        public double ToplamTutar = 0;

        public double TutarHesapla(CoffeeType KahveTipi,int adet)
        {
            switch (KahveTipi)
            {
                case CoffeeType.TurkKahvesi:
                    ToplamTutar = adet * 15;
                    break;
                case CoffeeType.Expresso:
                    ToplamTutar = adet * 16;
                    break;
                case CoffeeType.Latte:
                    ToplamTutar = adet * 17;
                    break;
                default:
                    break;
            }
            return ToplamTutar;
        }
    }
}
