using System;

namespace LibraryApp
{
    public class Fiction : Book
    {
        public String Genre {  get; set; }

        public override string GetDescription()
        {
            return $"{Title} isimli kitap {Genre} türünde ve bu kitabın yazarı {Author}";
        }
    }
}
