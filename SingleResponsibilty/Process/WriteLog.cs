using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilty.Process
{
    public class WriteLog
    {
        public string Mesaj { get; set; }

        public WriteLog(string mesaj)
        {
            Mesaj = mesaj;
        }

        public bool WriteToLogFile()
        {
            try
            {

                File.WriteAllText("Log.txt",Mesaj);
                return true;
            }
            catch (Exception ex)
            {
                
                return false;
            }
        }
    }
}
