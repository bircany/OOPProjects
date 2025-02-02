﻿using System;

namespace OOP.Interfaces.IComparableApp
{
    public class Employee : IComparable
    {
        public int Id { get; set; }
        public String FullName { get; set; }
        public decimal Salary { get; set; }

        public int CompareTo(object obj)
        {
            var other = (Employee)obj;
            if(this.Salary < other.Salary)
                return -1;
            else if (this.Salary.Equals(other.Salary))
                return 0;
            else
                return 1;
        }

        public override string ToString()
        {
            return $"{Id,-5} {FullName,-25} {Salary,-7}";
        }
    }
}
