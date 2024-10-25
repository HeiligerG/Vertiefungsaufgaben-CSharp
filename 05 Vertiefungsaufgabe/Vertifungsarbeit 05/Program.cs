using System;
using System.Collections.Generic;

namespace BookManagementSystem
{
    class Program
    {
        static Bookshelf bookshelf = new Bookshelf();
        static Author currentAuthor = null;
        static Book currentBook = null;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Geben Sie einen Befehl ein (oder 'Stop' zum Beenden): ");
                string command = Console.ReadLine();

                if (command.ToLower() == "stop")
                    break;

                ProcessCommand(command);
            }
        }

        static void ProcessCommand(string command)
        {
            switch (command.ToLower())
            {
                case "newbook":
                    CreateNewBook();
                    break;
                case "showbooks":
                    ShowAllBooks();
                    break;
                case "lookatnextbook":
                    LookAtNextBook();
                    break;
                case "newauthor":
                    CreateNewAuthor();
                    break;
                case "writenewbook":
                    WriteNewBook();
                    break;
                case "takenextbook":
                    TakeNextBook();
                    break;
                case "returnbook":
                    ReturnBook();
                    break;
                case "iscurrentauthor":
                    CheckCurrentAuthor();
                    break;
                default:
                    Console.WriteLine("Unbekannter Befehl. Bitte versuchen Sie es erneut.");
                    break;
            }
        }

        static void CreateNewBook()
        {
            Console.Write("Geben Sie den Buchtitel ein: ");
            string bookName = Console.ReadLine();

            Console.Write("Geben Sie den Autor ein: ");
            string authorName = Console.ReadLine();

            BookType type = ChooseBookType();

            Book newBook = new Book(bookName, authorName, type);
            bookshelf.AddBook(newBook);
            Console.WriteLine($"Neues Buch erstellt und ins Regal gestellt: {newBook.BookName} von {newBook.AuthorName} (Typ: {newBook.Type})");
        }

        static void ShowAllBooks()
        {
            List<Book> allBooks = bookshelf.GetAllBooks();
            if (allBooks.Count == 0)
            {
                Console.WriteLine("Das Bücherregal ist leer.");
            }
            else
            {
                Console.WriteLine("Bücher im Regal:");
                foreach (var book in allBooks)
                {
                    Console.WriteLine($"- {book.BookName} von {book.AuthorName} (Typ: {book.Type})");
                }
            }
        }

        static void LookAtNextBook()
        {
            Book nextBook = bookshelf.LookAtNextBook();
            if (nextBook != null)
            {
                Console.WriteLine($"Nächstes Buch: {nextBook.BookName} von {nextBook.AuthorName} (Typ: {nextBook.Type})");
                bookshelf.AddBook(nextBook);
            }
            else
            {
                Console.WriteLine("Keine Bücher im Regal.");
            }
        }

        static void CreateNewAuthor()
        {
            Console.Write("Geben Sie den Namen des Autors ein: ");
            string authorName = Console.ReadLine();
            currentAuthor = new Author(authorName);
            Console.WriteLine($"Neuer Autor erstellt: {authorName}");
        }

        static void WriteNewBook()
        {
            if (currentAuthor == null)
            {
                Console.WriteLine("Kein Autor vorhanden. Bitte zuerst einen Autor erstellen.");
                return;
            }

            Console.Write("Geben Sie den Buchtitel ein: ");
            string bookName = Console.ReadLine();

            BookType type = ChooseBookType();

            Book newBook = currentAuthor.WriteNewBook(bookName, type);
            bookshelf.AddBook(newBook);
            Console.WriteLine($"Neues Buch erstellt und ins Regal gestellt: {newBook.BookName} von {newBook.AuthorName} (Typ: {newBook.Type})");
        }

        static void TakeNextBook()
        {
            if (currentBook != null)
            {
                Console.WriteLine("Es wurde bereits ein Buch entnommen. Bitte legen Sie es zuerst zurück.");
                return;
            }

            currentBook = bookshelf.TakeNextBook();
            if (currentBook != null)
            {
                Console.WriteLine($"Entnommenes Buch: {currentBook.BookName} von {currentBook.AuthorName} (Typ: {currentBook.Type})");
            }
            else
            {
                Console.WriteLine("Keine Bücher im Regal.");
            }
        }

        static void ReturnBook()
        {
            if (currentBook == null)
            {
                Console.WriteLine("Kein Buch zum Zurücklegen vorhanden.");
                return;
            }

            bookshelf.AddBook(currentBook);
            Console.WriteLine($"Buch zurückgelegt: {currentBook.BookName} von {currentBook.AuthorName} (Typ: {currentBook.Type})");
            currentBook = null;
        }

        static void CheckCurrentAuthor()
        {
            if (currentAuthor == null)
            {
                Console.WriteLine("Kein aktueller Autor vorhanden.");
                return;
            }

            if (currentBook == null)
            {
                Console.WriteLine("Kein Buch entnommen.");
                return;
            }

            bool isCurrentAuthor = currentBook.AuthorName == currentAuthor.Name;
            Console.WriteLine($"Ist der aktuelle Autor der Autor des Buches? {isCurrentAuthor}");
        }

        static BookType ChooseBookType()
        {
            Console.WriteLine("Verfügbare Buchtypen:");
            foreach (BookType type in Enum.GetValues(typeof(BookType)))
            {
                Console.WriteLine($"- {type}");
            }
            Console.Write("Wählen Sie einen Buchtyp: ");
            string input = Console.ReadLine();
    
            if (Enum.IsDefined(typeof(BookType), input))
            {
                return (BookType)Enum.Parse(typeof(BookType), input, true);
            }
            else
            {
                Console.WriteLine("Ungültiger Buchtyp. Verwende Standard (Fiction).");
                return BookType.Fiction;
            }
        }
    }
}