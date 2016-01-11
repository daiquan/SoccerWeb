
using Castle.Windsor;
using Castle.Windsor.Installer;

namespace SoccerWeb.Tests.Controllers
{
    public class TestBase
    {
        private IWindsorContainer _container;
        public TestBase()
        {
            _container = new WindsorContainer().Install(FromAssembly.This());

        }

        public T Resolve<T>()
        {
            return _container.Resolve<T>();
        }
    }
}