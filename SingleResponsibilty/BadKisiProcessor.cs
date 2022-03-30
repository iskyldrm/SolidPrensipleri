using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilty
{
    public class BadKisiProcessor
    {
        private int _id=0;
        public int Id { get; set; }

        public string Adi { get; set; }

        public string TcNo { get; set; }

        public BadKisiProcessor(string adi,string tcNo)
        {
            _id += 1;
            Id = _id;
            Adi = adi;
            TcNo = tcNo;
        }

        public void KisiEkle()
        {
            try
            {

           
            StringBuilder Kayit = new StringBuilder();

            Kayit.Append($"{Id};{Adi};{TcNo}");

            File.WriteAllText("Kisiler.txt", Kayit.ToString());

            }
            catch (Exception ex)
            {
                File.WriteAllText("Log.txt", ex.ToString());
            }
        }
    }
}
