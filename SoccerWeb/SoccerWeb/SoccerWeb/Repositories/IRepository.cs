using SoccerWeb.DataAccessLayer;
using System;
using System.Data.Entity;
using System.Linq;

namespace SoccerWeb.Repositories
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> Get();
        int Add(T obj);
        bool Update(T obj);
        bool Delete(int Id);
    }

    public class SqlRepository<T> : IRepository<T> where T : class
    {
        private TeamLeagueContext _entities = new TeamLeagueContext();

        public virtual int Add(T obj)
        {
            throw new NotImplementedException();
        }

        public virtual bool Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public virtual IQueryable<T> Get()
        {
            IQueryable<T> query = _entities.Set<T>();
            return query;
        }

        public virtual bool Update(T obj)
        {
            throw new NotImplementedException();
        }
    }

}
