using System.Globalization;

namespace OOP_Design_of_Classes;

public class Book
{
    private string _title = string.Empty;
    private string _publisher = string.Empty;
    private int _edition;

    public Book(int edition, string title, string publisher, DateOnly publicationDate, CultureInfo culture)
    {
        Edition = edition;
        Title = title;
        Publisher = publisher;
        PublicationDate = publicationDate;
        Culture = culture;
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


    
}