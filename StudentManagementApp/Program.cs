using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var ogrenciKoleksiyonu = new StudentCollection();

            var ogrenci1 = new Student { Name = "Ali", LastName = "Yılmaz", Number = 123, Department = "Bilgisayar Mühendisliği" };
            var ogrenci2 = new Student { Name = "Ayşe", LastName = "Demir", Number = 456, Department = "Elektrik-Elektronik Mühendisliği" };

            ogrenciKoleksiyonu.Add(ogrenci1);
            ogrenciKoleksiyonu.Add(ogrenci2);

            var ogrenciKopya = (Student) ogrenci1.Clone();
            Console.WriteLine("Öğrenci Kopyası: " + ogrenciKopya.ToString("F", null));

            foreach (var ogrenci in ogrenciKoleksiyonu)
            {
                Console.WriteLine(ogrenci.ToString("F", null));  // Tam bilgi
                Console.WriteLine(ogrenci.ToString("A", null));  // Ad ve Soyad
                Console.WriteLine(ogrenci.ToString("B", null));  // Bölüm
            }

            Console.ReadKey();
        }
    }
}
