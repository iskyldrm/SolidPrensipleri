using IOC_WindsorCastel.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC_WindsorCastel.Concrete
{
    public class Araba : ITasit
    {
        public DateTime Zaman { get; set; }
        public int YolcuSayisi { get; set; }
        public Araba()
        {
            Zaman = DateTime.Now;
        }
        public void Calistir()
        {
            Console.WriteLine("Araba çalıştır metodu çalıştı");
        }

        public void Durdur()
        {
            Console.WriteLine("Durdur metodu çalıştı");
        }

        public void FreneBas()
        {
            Console.WriteLine("FreneBas basıldı");
        }

        public void GazaBas()
        {
            Console.WriteLine("Gaza Basıldı");
        }
        public override string ToString()
        {
            Zaman = DateTime.Now;

            return Zaman.ToString();
        }
    }
}
