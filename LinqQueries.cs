using curso_manejo_datos_csharp_linq.Models;

namespace curso_manejo_datos_csharp_linq
{
    public class LinqQueries
    {
      private List<Book> books = new List<Book>();

        public LinqQueries()
        {
          using(StreamReader reader = new StreamReader("books.json"))
          {
            string json = reader.ReadToEnd();
            books = System.Text.Json.JsonSerializer.Deserialize<List<Book>>(json, new System.Text.Json.JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
                     
          }
        }

        public IEnumerable<Book> GetBooks()
        {
          return books;
        }
    }
}