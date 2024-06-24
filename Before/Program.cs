using System.Globalization;
using OOP_Design_of_Classes;

var book = new Book(1, "C# 9 and .NET 5", "barkley", new DateOnly(2020, 11, 20), CultureInfo.InvariantCulture,
    ["Mark J. Price"]);
book.AppendAuthor("John Doe");
book.AppendAuthor("Jane Doe");
book.MoveAuthorTo(1, "Jane Smith");
book.RemoveAuthor("John Doe");
Console.WriteLine($"Title: {book.Title}");
Console.WriteLine($"Publisher: {book.Publisher}");
Console.WriteLine($"Edition: {book.Edition}");
Console.WriteLine($"Publication Date: {book.PublicationDate}");
Console.WriteLine($"Culture: {book.Culture}");
Console.WriteLine("Authors:");
foreach (var author in book.Authors)
{
    Console.WriteLine(author);
}