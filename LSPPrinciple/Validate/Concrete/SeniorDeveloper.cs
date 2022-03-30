using LSPPrinciple.Validate.Abstarct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPPrinciple.Validate.Concrete
{
    public class SeniorDeveloper : ISolidKullanabilir,IDeveloper
    {
        public void ProjeGelistirebilir()
        {
            throw new NotImplementedException();
        }

        public void SolidKulalnir()
        {
            throw new NotImplementedException();
        }
    }
}
