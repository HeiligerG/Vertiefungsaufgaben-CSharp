using System.Collections.Generic;

namespace BookManagementSystem
{
    public class Bookshelf
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public List<Book> GetAllBooks()
        {
            return new List<Book>(books);
        }

        public Book LookAtNextBook()
        {
            if (books.Count == 0)
                return null;

            Book nextBook = books[0];
            books.RemoveAt(0);
            return nextBook;
        }

        public Book TakeNextBook()
        {
            if (books.Count == 0)
                return null;

            Book nextBook = books[0];
            books.RemoveAt(0);
            return nextBook;
        }
    }
}