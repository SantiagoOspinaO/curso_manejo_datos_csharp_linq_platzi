using curso_manejo_datos_csharp_linq;
using curso_manejo_datos_csharp_linq.Models;

LinqQueries linqQueries = new LinqQueries();

imprimir(linqQueries.GetBooks());

void imprimir(IEnumerable<Book> listBooks)
{
  Console.WriteLine("{0,-60} {1,15} {2,15}\n", "Title", "Page count", "Published date");
  foreach (var book in listBooks)
  {
    Console.WriteLine("{0,-60} {1,15} {2,15}", book.title, book.pageCount, book.publishedDate.ToShortDateString());
  }
}