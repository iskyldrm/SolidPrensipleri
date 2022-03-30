using OCPrinciple.Validate.Absract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPrinciple.Validate.Concrete
{
    public class Expresso : ICoffee
    {
        public double FiyatiHesapla(int adet, double fiyat)
        {
            return adet * fiyat;
        }
    }
}
