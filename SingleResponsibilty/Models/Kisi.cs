using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilty
{
    public class Kisi
    {
        
        public int Id { get; set; }

        public string Adi { get; set; }

        public string TcNo { get; set; }

        public Kisi(string adi, string tcNo)
        {
            Random random = new Random();

            Id = random.Next(1, 100000);
           
            Adi = adi;
            TcNo = tcNo;
        }
    }
}
