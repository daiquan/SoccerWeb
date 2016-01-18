using SoccerWeb.Repositories;
using System;
using System.Linq;

namespace SoccerWeb.Tests.Fake
{
    public class FakeSqlRepository<T> : IRepository<T> where T : class, new()
    {
        public void Add(T obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> Get()
        {
            var t1 = new T();
            var ts = new[] { t1 };
            return ts.AsQueryable();
        }

        public T GetById(int id)
        {
            return new T();
        }

        public void Update(T obj)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
