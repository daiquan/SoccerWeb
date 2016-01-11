using SoccerWeb.Repositories;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using SoccerWeb.ModelServices;
using SoccerWeb.Tests.Fake;
namespace SoccerWeb.Installers
{
    public class FakeInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For(typeof(IRepository<>)).ImplementedBy(typeof(FakeSqlRepository<>)));
            container.Register(Component.For<ITeamService>().ImplementedBy<TeamService>());
        }
    }
}