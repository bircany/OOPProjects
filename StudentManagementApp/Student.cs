using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementApp
{
    public class Student : ICloneable, IFormattable
    {
        public String Name { get; set; }
        public String LastName { get; set; }
        public String Department { get; set; }
        public int Number { get; set; }
        public Student(){ }
        public object Clone() => new Student
        {
            Name = this.Name,
            LastName = this.LastName,
            Number = this.Number,
            Department = this.Department
        };
        public override string ToString() => ToString("F", CultureInfo.CurrentCulture);
        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (String.IsNullOrEmpty(format))
                format = "F";
            if(formatProvider == null)
                formatProvider = CultureInfo.CurrentCulture;
            switch (format.ToUpper()) 
            {
                case "F":
                    return $"{Number} - {Name} {LastName} - {Department}";
                case "A":
                    return $"{Name} {LastName}";
                case "B":
                    return $"{Department}";
                default:
                    throw new FormatException($"Format '{format}' desteklenmiyor.");
            }
        }
    }
}
