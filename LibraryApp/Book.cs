using System;

namespace LibraryApp
{
    public abstract class Book
    {
        public String Title { get; set; }
        public String Author { get; set; }
        public abstract string GetDescription();
    }
}
