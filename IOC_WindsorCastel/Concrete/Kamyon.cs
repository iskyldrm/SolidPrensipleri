using IOC_WindsorCastel.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC_WindsorCastel.Concrete
{
    public class Kamyon:ITasit
    {
        public int YukKapasitesi { get; set; }
        public void Calistir()
        {
            Console.WriteLine("Kamyon Calisti");
        }

        public void Durdur()
        {
            Console.WriteLine("Kamyon Durdu");
        }

        public void FreneBas()
        {
            Console.WriteLine("Kamyon Fren Yapti");
        }

        public void GazaBas()
        {
            Console.WriteLine("Kamyon Gaza Basti");
        }
    }
}
