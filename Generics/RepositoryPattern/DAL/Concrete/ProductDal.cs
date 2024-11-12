using OOP.Generic.RepositoryDesignPattern.DAL.Abstract;
using OOP.Generic.RepositoryDesignPattern.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.DAL.Concrete
{
    public class ProductDal : BaseRepository<Product>, IProductDal
    {
    }
}
