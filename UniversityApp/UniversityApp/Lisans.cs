using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApp
{
    internal class Lisans : Ogrenci
    {
        protected int Yariyil;
        public Lisans(string Ad, string Soyad, int Yariyil) : base(Ad, Soyad)
        {
            this.Yariyil = Yariyil;
        }

        public Lisans(string Ad, string Soyad, int Numara, string Bolum,int Yariyil) : base(Ad, Soyad, Numara, Bolum)
        {
            this.Yariyil = Yariyil;
        }

        protected override void BilgiVer()
        {
            throw new NotImplementedException();
        }
    }
}
