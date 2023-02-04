using System.ComponentModel.DataAnnotations;

namespace MvcBookstore.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string? Title { get; set; }
    }
}
