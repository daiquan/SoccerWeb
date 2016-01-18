using SoccerWeb.Repositories;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using SoccerWeb.DataAccessLayer;

namespace SoccerWeb.Installers
{
    public class RepositoryInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For(typeof(IRepository<>)).ImplementedBy(typeof(SqlRepository<>)));
            container.Register(Component.For(typeof(TeamLeagueContext)).Instance(new TeamLeagueContext()));
        }
    }
}