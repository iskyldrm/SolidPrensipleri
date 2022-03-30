using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilty.Process
{
    public class KisiProcessor
    {
        public Kisi Kisi { get; set; }
        KisiWriteFile KisiWriter;
        public KisiProcessor(Kisi kisi)
        {
            Kisi = kisi;
        }

        public void KisiEkle()
        {
            KisiWriter = new KisiWriteFile("KisiKayitlar.txt", Kisi);
            KisiWriter.DosyaYaz();
        }
    }
}
