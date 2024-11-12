using OOP.Generic.RepositoryDesignPattern.Entity;
using System.Collections.Generic;

namespace RepositoryPattern.DAL.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
    }
}
