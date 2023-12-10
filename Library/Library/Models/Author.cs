using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class Author
    {
        [Display(Name = "ID")]
        public int AuthorId { get; set; }
        public required string Name { get; set; }
        public required string Nationality { get; set; }
    }
}
