public class Book
{
    public string Title { get; private set; }

    public string Author { get; private set; }

    public string Publisher { get; private set;} 

    public DateTime ReleaseDate { get; private set; }

    public ISNBNumber ISNBNumber { get; private set; }

    public float Edition { get; private set; }

    public Book(string title, 
                string author, 
                string publisher, 
                DateTime releaseDate, 
                ISNBNumber isnbNumber,
                float edition = 1.0f)
    {
        this.Title = title;
        this.Author = author;
        this.Publisher = publisher;
        this.ReleaseDate = releaseDate;
        this.ISNBNumber = isnbNumber;
        this.Edition = edition;
    }

}