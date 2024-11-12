using OOP.Generic.RepositoryDesignPattern.Entity.Abstract;

namespace RepositoryPattern.Entity
{
    public class Product : IEntity
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int UnitsInStock { get; set; }
    }
}
