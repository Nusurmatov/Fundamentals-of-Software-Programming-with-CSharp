public class Library 
{
    public string Name { get; private set; }

    private Dictionary<ISNBNumber, Book> Books { get; set; }

    private Dictionary<Book, bool> BooksAvaliablity { get; set; }

    private Dictionary<Book, int> BooksCount { get; set; }

    private Dictionary<Book, Reader> BooksReader { get; set; }
    
    public Library(string name) : this(name, new List<Book>()) { }

    public Library(string name, params Book[] books) : this(name, books.ToList()) { }

    public Library(string name, List<Book> books)
    {
        this.Name = name;
        this.Books = new Dictionary<ISNBNumber, Book>();
        this.BooksAvaliablity = new Dictionary<Book, bool>();
        this.BooksCount = new Dictionary<Book, int>();
        this.BooksReader = new Dictionary<Book, Reader>();

        foreach (var book in books)
        {
            this.Books.Add(book.ISNBNumber, book);
            this.BooksAvaliablity.Add(book, true);
            this.BooksCount.Add(book, 1);
        }
    }   

    public void AddBook(Book book)
    {
        throw new NotImplementedException();
    }

    public void DeleteBook(Book book)
    {
        if (this.Contains(book))
        {
            this.Books.Remove(book.ISNBNumber);
        }
        else
        {
            throw new ArgumentException($"Library does not contain this book: '{book.Title}'!");
        }
    }

    public bool Contains(Book book) => this.Books.ContainsKey(book.ISNBNumber);

    public bool IsAvailable(Book book)
    {
        throw new NotImplementedException();
    }

    public Book BorrowBook(Book book, Reader redear)
    {
        throw new NotImplementedException();
    }
}