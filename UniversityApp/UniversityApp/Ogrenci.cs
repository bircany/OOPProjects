using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApp
{
    public abstract class Ogrenci
    {
        private String Ad { get; set; }
        private String Soyad { get; set; }
        private int Numara { get; set; }
        private String? Bolum { get; set; }
        protected Ogrenci(String Ad,String Soyad)
        {
            this.Ad = Ad;
            this.Soyad = Soyad;
        }
        protected Ogrenci(String Ad, String Soyad,int Numara,String Bolum)
        {
            this.Ad = Ad;
            this.Soyad = Soyad;
            this.Numara = Numara;
            this.Bolum = Bolum;
        }
        protected abstract void BilgiVer();
    }
}
