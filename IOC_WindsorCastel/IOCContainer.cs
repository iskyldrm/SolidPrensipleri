using Castle.MicroKernel.Registration;
using Castle.Windsor;
using IOC_WindsorCastel.Abstracts;
using IOC_WindsorCastel.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC_WindsorCastel
{
    public static class IOCContainer
    {
        private static readonly IWindsorContainer container = new WindsorContainer();
        public static void TasitFactory()
        {
            container.Register(Component.For<ITasit>().ImplementedBy<Araba>().Named("Araba").LifeStyle.Singleton);
            container.Register(Component.For<ITasit>().ImplementedBy<Otobus>().Named("Otobus").LifeStyle.Transient);
            container.Register(Component.For<ITasit>().ImplementedBy<Kamyon>().Named("Kamyon"));
            container.Register(Component.For<ISofor>().ImplementedBy<Sofor>());


        }

        public static T ResolveTasit<T>(string tasit)
        {

            return container.Resolve<T>(tasit);
        }
    }
}
