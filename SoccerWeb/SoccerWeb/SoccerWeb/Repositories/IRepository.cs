using SoccerWeb.DataAccessLayer;
using System;
using System.Data.Entity;
using System.Linq;

namespace SoccerWeb.Repositories
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> Get();
        T GetById(int id);
        void Add(T obj);
        void Update(T obj);
        void Delete(int Id);
        void Save();
    }

    public class SqlRepository<T> : IRepository<T> where T : class, new()
    {
        private TeamLeagueContext _entities = new TeamLeagueContext();
        private readonly IDbSet<T> teamsSet;

        public SqlRepository ()
        {
            teamsSet = _entities.Set<T>();
            _entities = _entities ?? new TeamLeagueContext();
        }

        public virtual T GetById(int id)
        {
            return teamsSet.Find(id);
        }

        public virtual void Add(T obj)
        {
            teamsSet.Add(obj);
            Save();
        }

        public virtual void Delete(int Id)
        {
            T item = GetById(Id);
            //teamsSet.Remove(item);
            //Save();

            _entities.Entry(item).State = EntityState.Deleted;
            _entities.SaveChanges();
        }

        public virtual IQueryable<T> Get()
        {
            return teamsSet;
        }

        public virtual void Update(T obj)
        {
            _entities.Entry(obj).State = EntityState.Modified;
            Save();
        }

        public virtual void Save()
        {
            _entities.SaveChanges();
        }
    }

}
