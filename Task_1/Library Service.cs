using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Library_Service
    {
        public List<Book> books;
        public Library_Service()
        {
            books = new List<Book>();
        }
        public void Add_Book(Book book)
        {
            bool exists = books.Exists(b => b.Title == book.Title);
            if (!exists) books.Add(book);
        }
        public void Remove_Book(Book book)
        {
            Book b = books.FirstOrDefault(b => b.Title == book.Title);
            if(b != null)
            {
                books.Remove(b);
            }
        }
        public IEnumerable<Book> Search_Book_By_Title(string title)
        {
            return books.Where(b => b.Title == title);
        }

        public IEnumerable<Book> Search_Book_By_Author(string author)
        {
            return books.Where(b => b.Authors == author);
        }
    }

}
