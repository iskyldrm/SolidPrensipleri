using IOC_WindsorCastel.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC_WindsorCastel.Concrete
{
    class Otobus : ITasit
    {
        public DateTime Zaman { get; set; }
        public int KoltukSayisi { get; set; }
        public void Calistir()
        {
            Console.WriteLine("Otobus çalıştır metodu çalıştı");
        }

        public void Durdur()
        {
            Console.WriteLine("Otobus Durdur metodu çalıştı");
        }

        public void FreneBas()
        {
            Console.WriteLine("Otobus FreneBas basıldı");
        }

        public void GazaBas()
        {
            Console.WriteLine("Otobus Gaza Basıldı");
        }
        public override string ToString()
        {
            Zaman = DateTime.Now;

            return Zaman.ToString();
        }
    }
}
