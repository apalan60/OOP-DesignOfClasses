using System.Collections;
using System.Globalization;

namespace After;

public class AuthorList(IEnumerable<string> authors, CultureInfo cultureInfo) : IEnumerable<string>
{
    private readonly List<string> _authorCollection = authors.Where(IsValidAuthor).ToList();
    
    private CultureInfo CultureInfo { get; } = cultureInfo;

    public void AppendAuthor(string author)
    {
        IsValidAuthor(author);
        _authorCollection.Add(author);
    }
    
    public bool RemoveAuthor(string author) =>  _authorCollection.Remove(author);
    
    private Func<string, bool> FilterFor(string filter) => 
        author => string.Compare(author, filter, CultureInfo, CompareOptions.IgnoreCase) == 0;
    
    public void AuthorsToUpperCase() => _authorCollection
        .ForEach(author => _authorCollection[_authorCollection.IndexOf(author)] = CultureInfo.TextInfo.ToUpper(author));
    
    public bool MoveAuthorTo(int index, string author)
    {
        if (index < 0 || index >= _authorCollection.Count)
        {
            return false;
        }
        _authorCollection[index] = author;
        return true;
    }

    private static bool IsValidAuthor(string author)
    {
        if (string.IsNullOrWhiteSpace(author))
        {
            throw new ArgumentException(author, nameof(author));
        }

        return true;
    }

    public IEnumerator<string> GetEnumerator() => _authorCollection.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

public class Author
{
    
}