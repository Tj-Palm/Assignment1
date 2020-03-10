using System;
using System.Collections.Generic;

namespace Assignment1
{
    public class Book
    {
        #region Usage for later assignment
private static List<Book> books = new List<Book>();
        

        #endregion
        
        private string _title;
        private string _author;
        private int _page;
        private string _isbn13;

        public Book()
        {

        }

        public Book(string Title, string Author, int Page, string Isbn13)
        {
            _title = Title;
            _author = Author;
            _page = Page;
            _isbn13 = Isbn13;
        }

        public string Title
        {
            get => _title;
            set => _title = value;
        }

        public string Author
        {
            get => _author;
            set
            {
                if (value.Length < 2)
                    throw new ArgumentOutOfRangeException("Author",
                        "Name of the author shall be more than 2 characters long.");
                _author = value;
            }
        }

        public int Page
        {
            get => _page;
            set
            {
                if (4 >= value || value >= 1000)
                    throw new ArgumentOutOfRangeException("Page", "Number of pages shall be between 4 and 1000.");
                _page = value;
            }
        }

        public string Isbn13
        {
            get => _isbn13;
            set
            {
                if (value.Length != 13)
                    throw new ArgumentOutOfRangeException("Isbn13", "Isbn13 shall be exactly 13 characters long.");
                _isbn13 = value;
            }
        }
    }
}