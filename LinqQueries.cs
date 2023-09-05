using System.Text.Json;
using curso_manejo_datos_csharp_linq.Models;

namespace curso_manejo_datos_csharp_linq
{
  public class LinqQueries
  {
    private readonly List<Book> _booksList;
    private const string FILE_PATH = "books.json";

    public LinqQueries()
    {
      _booksList = new List<Book>();
      if (File.Exists(FILE_PATH))
      {
        using StreamReader reader = new(FILE_PATH);
        string json = reader.ReadToEnd();
        var options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };
        List<Book>? books = JsonSerializer.Deserialize<List<Book>>(json, options);
        if (books != null)
        {
          this._booksList = books;
        }
      }
    }

    public IEnumerable<Book> GetBooks() => _booksList;

    public IEnumerable<Book> GetBooksAfter2000()
    {
      //return _booksList.Where(book => book.publishedDate.Year > 2000);
      return from book in _booksList
             where book.publishedDate.Year > 2000
             select book;
    }

    public IEnumerable<Book> GetBooksOver250Pages()
    {
      // return _booksList.Where(book => book.pageCount > 250 && book.title.Contains("in Action"));
      return from book in _booksList
             where book.pageCount > 250 && book.title.Contains("in Action")
             select book;
    }
  }
}