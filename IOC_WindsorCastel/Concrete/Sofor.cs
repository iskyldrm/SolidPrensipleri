using IOC_WindsorCastel.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC_WindsorCastel.Concrete
{
    public class Sofor : ISofor
    {

        //SADCE OKUMASA SADECE CONSTRUCTER İÇİERİSNDE DEĞER ATILAMASI YAPILABİLİR 
        private readonly ITasit _tasit;

        public Sofor(ITasit tasit)
        {
            this._tasit = tasit;
        }


        public void Kullan()
        {
            _tasit.Calistir();
            _tasit.GazaBas();
            _tasit.FreneBas();
            _tasit.Durdur();
        }
    }
}
