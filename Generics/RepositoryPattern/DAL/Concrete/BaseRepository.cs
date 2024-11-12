using OOP.Generic.RepositoryDesignPattern.DAL.Abstract;
using OOP.Generic.RepositoryDesignPattern.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.DAL.Concrete
{
    public class BaseRepository<T> : IEntityRepository<T>
        where T : class , IEntity , new()
    {
        public void Create(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int entityId)
        {
            throw new NotImplementedException();
        }

        public T Get()
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
