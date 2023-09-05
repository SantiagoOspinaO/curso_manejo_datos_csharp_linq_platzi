using curso_manejo_datos_csharp_linq;
using curso_manejo_datos_csharp_linq.Models;

LinqQueries linqQueries = new LinqQueries();

//imprimir(linqQueries.GetBooks());
//imprimir(linqQueries.GetBooksAfter2000());
//imprimir(linqQueries.GetBooksOver250Pages());

void imprimir(IEnumerable<Book> listBooks)
{
  Console.WriteLine("\n{0,-60} {1,15} {2,15}\n", "Title", "Page count", "Published date");
  foreach (var book in listBooks)
  {
    Console.WriteLine("{0,-60} {1,15} {2,15}", book.title, book.pageCount, book.publishedDate.ToShortDateString());
  }
}

do
{
  Console.WriteLine("Select an option\n1. Get all books\n2. Get all books after 2000\n3. Get all books over 250 pages and contains in Action\n4. Exit");
  Console.Write("-> ");

  switch (Console.ReadKey().KeyChar)
  {
    case (char)ConsoleKey.D1:
      imprimir(linqQueries.GetBooks());
      break;
    case (char)ConsoleKey.D2:
      imprimir(linqQueries.GetBooksAfter2000());
      break;
    case (char)ConsoleKey.D3:
      imprimir(linqQueries.GetBooksOver250Pages());
      break;
    case (char)ConsoleKey.D4:
      Console.WriteLine("\nBye!");
      Environment.Exit(0);
      break;
  }

} while (Console.ReadKey().KeyChar != 4);