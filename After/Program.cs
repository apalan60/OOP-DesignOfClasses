using System.Globalization;
using After;

var book = new Book(1, "C# 9 and .NET 5", "barkley", new DateOnly(2020, 11, 20), CultureInfo.InvariantCulture, new AuthorList(["Mark J. Price"]));