using OCPrinciple.Validate.Absract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPrinciple.Validate.Concrete
{
    class FileLogger : ILogger
    {
        public bool LogYaz()
        {
            Console.WriteLine("File Loglandı");

            return true;
        }
    }
}
