using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilty.Process
{
    public class KisiWriteFile
    {
        string _DosyaAdi;
        Kisi _kisi;
        
        public KisiWriteFile(string dosyaAdi,Kisi kisi)
        {
            _DosyaAdi = dosyaAdi;
            _kisi = kisi;
        }

        public bool DosyaYaz()
        {
            try
            {


                StringBuilder Kayit = new StringBuilder();

                Kayit.Append($"{_kisi.Id};{_kisi.Adi};{_kisi.TcNo}");

                File.WriteAllText("Kisiler.txt", Kayit.ToString());
                return true;
            }
            catch (Exception ex)
            {
                File.WriteAllText("Log.txt", ex.ToString());
                return false;
            }
        }
    }
}
