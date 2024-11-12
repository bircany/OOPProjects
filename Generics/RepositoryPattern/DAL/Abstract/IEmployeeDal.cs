using OOP.Generic.RepositoryDesignPattern.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.DAL.Abstract
{
    public interface IEmployeeDal : IEntityRepository<Employee>
    {
    }
}
