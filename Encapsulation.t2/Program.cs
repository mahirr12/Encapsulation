namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book(1, "Sherlock Holmes", 4.3, "Detective");
            Book book2 = new Book(2, "Les Misérables", 7.5, 3, "Tragedy");
            Book book3 = new Book(3, "Dune", 11, 0, "Sci-fi");
            Library lib1 = new Library();
            lib1.AddBook(book1);
            lib1.AddBook(book3);
            Console.WriteLine(lib1.GetBookById(3));
            Console.WriteLine(lib1.GetBookByName("Sherlock Holmes").Price);
        }

        public class Library
        {
            private Book[] Books = new Book[0];

            public void AddBook(Book book)
            {
                Array.Resize(ref Books, Books.Length + 1);
                Books[^1] = book;
            }
            public Book GetBookById(int id)
            {
                foreach (Book book in Books)
                {
                    if (book.Id == id) return book;
                }
                return null;
            }
            public Book GetBookByName(string name)
            {
                foreach (Book book in Books)
                {
                    if (book.Name == name) return book;
                }
                return null;
            }
            public Book[] GetFilteredBooks(string genre)
            {
                int length = 0;
                foreach (Book book in Books)
                {
                    if (book.Genre == genre) length++;
                }
                Book[] FilteredBooks = new Book[length];
                int i = 0;
                foreach (Book book in Books)
                {
                    if (book.Genre == genre) FilteredBooks[i++] = book;
                }
                return FilteredBooks;
            }
            public Book[] GetFilteredBooks(double minPrice, double maxPrice)
            {
                int legth = 0;
                foreach (Book book in Books)
                {
                    if ((book.Price <= minPrice) && (book.Price >= maxPrice)) legth++;
                }
                Book[] FilteredBooks = new Book[legth];
                int i = 0;
                foreach (Book book in Books)
                {
                    if ((book.Price <= minPrice) && (book.Price >= maxPrice)) FilteredBooks[i] = book;
                }
                return FilteredBooks;
            }
        }
    }
}
