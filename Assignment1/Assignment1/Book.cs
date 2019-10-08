using System;

namespace Assignment1
{
    public class Book
    {
        string title;
        string author;
        int pagenumber;
        string isbn13;

        public string Title { get => title; }
        public string Author { get => author;  }
        public int Pagenumber { get => pagenumber; }
        public string Isbn13 { get => isbn13; }

        public Book(string title, string author, int pagenumber, string isbn13)
        {
            validate(title, author, pagenumber, isbn13);


            
        }
        void validate(string title, string author, int pagenumber, string isbn13)
        {
            if (title.Length > 2)
                this.title = title;
            else
                throw new ArgumentException("Title have to be at least 2 character long!");
            if (pagenumber > 10 && pagenumber <= 1000)
                this.pagenumber = pagenumber;
            else
                throw new ArgumentException("pagenumber has to be between 10 and 1000!");
            if (isbn13.Length == 13)
                this.isbn13 = isbn13;
            else
                throw new ArgumentException("isbn must be 13 character long!");
            this.author = author;
        }
    }
}
