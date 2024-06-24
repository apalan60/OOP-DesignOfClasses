using System.Collections;

namespace After;

public class AuthorList(IEnumerable<string> authors) : IEnumerable<string>
{
    private readonly List<string> _authorCollection = authors.Where(IsValidAuthor).ToList();

    public void AppendAuthor(string author)
    {
        IsValidAuthor(author);
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