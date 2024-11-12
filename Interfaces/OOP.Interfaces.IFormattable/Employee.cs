using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOP.Interfaces.IFormattables
{
    public class Employee : IFormattable
    {
        public int Id { get; set; }
        public String Title { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String FullName => $"{Title} {FirstName} {LastName}";
        public override string ToString()
        {
            return this.ToString("F", CultureInfo.CurrentCulture);
        }
        public string ToString(string format)
        {
            return this.ToString(format,CultureInfo.CurrentCulture);
        }
        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (String.IsNullOrEmpty(format))
                format = "F";

            if (formatProvider == null)
                formatProvider = CultureInfo.CurrentCulture;

            switch (format.ToUpper())
            {
                case "F":
                    return $"{Id,-5} {Title,-20} {FirstName,-15} {LastName,-15}";
                case "FL":
                    return $"{FirstName} {LastName}";
                case "LF":
                    return $"{LastName} {FirstName} ";
                case "S":
                    return $"{LastName} {FirstName[0]} ";
                default:
                    throw new FormatException(String.Format("The {0} is not supported",format));
            }
            
        }
    }
}
