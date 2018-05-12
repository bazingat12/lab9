using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    class Book
    {
        private int _BookID;
        private string _Author;
        private string _NameBook;
        private string _Genre;

        public int BookID
        {
            get
            {
                return _BookID;
            }
                set
            {
                if (value > 0)
                    _BookID = value;
                else
                    Console.WriteLine("Неподустимый код книги");
            }
                }

        public string Author
        {
            get
            {
                if (String.IsNullOrEmpty(_Author))
                    throw new Exception("Автор не может быть пустым");
                else
                    return _Author;
            }
                set
            {
                _Author = value;
            }
                }
        public string NameBook
        {
            get
            {
                if (String.IsNullOrEmpty(_NameBook))
                    throw new Exception("Наименование книги не может быть пустым");
                else
                    return _NameBook;
            }
            set
            {
                _NameBook = value;
            }
        }
public string Genre
        {
            get
            {
                if (String.IsNullOrEmpty(_Genre))
                    throw new Exception("Жанр книги не может быть пустым");
                else
                    return _Genre;
            }
            set
            {
                _Genre = value;
            }
        }

        public Book(int BookID, string Author, string NameBook, String Genre)
        {
            this.BookID = BookID;
            this.Author = Author;
            this.NameBook = NameBook;
            this.Genre = Genre;
        }

        public virtual void Info()
        {
            Console.WriteLine("Информация о книге: ");
            Console.WriteLine("    Код книги: {0}\n    Автор: {1}\n    Название книги: {2} \n    Жанр: {3}\n",
                BookID, Author, NameBook, Genre);
        }
    }
}
