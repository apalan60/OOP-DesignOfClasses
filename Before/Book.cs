using System.Globalization;

namespace OOP_Design_of_Classes;

public class Book
{
    private string _title = string.Empty;
    private string _publisher = string.Empty;
    private int _edition;
    
    public Book(int edition, string title, string publisher, DateOnly publicationDate, CultureInfo culture, List<string> authorCollection)
    {
        Edition = edition;
        Title = title;
        Publisher = publisher;
        PublicationDate = publicationDate;
        Culture = culture;
        _authorCollection = authorCollection;
    }
    
    public CultureInfo Culture { get; set; }
    
    public string Title
    {
        get => _title;
        set => _title = !string.IsNullOrWhiteSpace(value)? value: throw new ArgumentException(nameof(Title));
    }

    public string Publisher
    {
        get => _publisher;
        set => _publisher = !string.IsNullOrWhiteSpace(value)? value: throw new ArgumentException(nameof(Publisher));
    }

    public int Edition
    {
        get => _edition;
        set => _edition = value > 0 ? value : throw new ArgumentException(nameof(Edition));
    }

    public DateOnly PublicationDate { get; set; }

    private readonly List<string> _authorCollection;
    public IEnumerable<string> Authors => _authorCollection;
    
    public void AppendAuthor(string author)
    {
        if (string.IsNullOrWhiteSpace(author))
        {
            throw new ArgumentException(author, nameof(author));
        }
        _authorCollection.Add(author);
    }
    
    public bool RemoveAuthor(string author) => _authorCollection.Remove(author);
    
    public bool MoveAuthorTo(int index, string author)
    {
        if (index < 0 || index >= _authorCollection.Count)
        {
            return false;
        }
        _authorCollection[index] = author;
        return true;
    }
}