namespace BookManagementSystem
{
    public class Author
    {
        public string Name { get; }

        public Author(string name)
        {
            Name = name;
        }

        public Book WriteNewBook(string bookName, BookType type = BookType.Fiction)
        {
            return new Book(bookName, Name, type);
        }
    }
}