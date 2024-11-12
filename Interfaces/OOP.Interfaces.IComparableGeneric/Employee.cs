using System;

namespace OOP.Interfaces.IComparableGenerics
{
    public class Employee : IComparable<Employee>
    {
        public int Id { get; set; }
        public String FullName { get; set; }
        public decimal Salary { get; set; }

        public int CompareTo(Employee other)
        {
            //return this.Id.CompareTo(other.Id); //DEFAULT is Id but can be change with FullName and Salary or other field.
            if(this.Salary < other.Salary) return 1;
            else if(this.Salary > other.Salary) return 0;
            else return -1;
        }

        public override string ToString()
        {
            return $"{Id,-5} {FullName,-25} {Salary,-7}";
        }
    }
}
