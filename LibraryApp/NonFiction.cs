using System;

namespace LibraryApp
{
    public class NonFiction : Book
    {
        public String Subject {  get; set; }

        public override string GetDescription()
        {
            return $"{Title} isimli kitap {Subject} konusunda ve bu kitabın yazarı {Author}.";
        }
    }
}
