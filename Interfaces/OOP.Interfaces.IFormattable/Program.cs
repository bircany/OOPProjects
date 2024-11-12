using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interfaces.IFormattables
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(DateTime.Now.ToString("d"));  DateTime implements IFormattable
            var list = new List<Employee>()
            {
                new Employee()
                {
                    Id = 1,
                    Title = "Prof.Dr.",
                    FirstName = "Bircan",
                    LastName = "Yılmaz",
                },
                new Employee()
                {
                    Id = 2,
                    Title = "Doç.Dr.",
                    FirstName = "Ali",
                    LastName = "Gümüş",
                },
                new Employee()
                {
                    Id = 3,
                    Title = "Dr.Öğr.Üyesi",
                    FirstName = "Zafer",
                    LastName = "Cömert",
                },
            };
            foreach (var employee in list)
            {
                Console.WriteLine(employee.ToString("F"));
            }
            Console.ReadKey();

        }
    }
}
