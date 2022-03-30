using OCPrinciple.Validate.Absract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPrinciple.Validate.Concrete
{
    public class SMSLogger : ILogger
    {
        public bool LogYaz()
        {
            Console.WriteLine("SMS Loglandı");

            return true;
        }
    }
}
