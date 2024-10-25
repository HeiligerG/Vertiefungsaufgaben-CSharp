namespace BookManagementSystem
{
    public class Book
    {
        public string BookName { get; }
        public string AuthorName { get; }
        public BookType Type { get; }

        public Book(string bookName, string authorName) : this(bookName, authorName, BookType.Fiction) { }

        public Book(string bookName, string authorName, BookType type)
        {
            BookName = bookName;
            AuthorName = authorName;
            Type = type;
        }
    }
}