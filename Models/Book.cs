namespace curso_manejo_datos_csharp_linq.Models
{
    public class Book
    {
        public string? title { get; set; }
        public int pageCount { get; set; }
        public string? status { get; set; }
        public DateTime publishedDate { get; set; }
        public string? thumbnailUrl { get; set; }
        public string[]? authors { get; set; }
        public string[]? categories { get; set; }
    }
}