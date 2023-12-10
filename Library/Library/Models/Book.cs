using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class Book
    {
        [Display(Name = "ID")]
        public int BookId { get; set; }
        public required string Title { get; set; }
        [Display(Name = "Author")]
        public int AuthorId { get; set; }
        public Author? Author { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Publication Date")]
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }
    }
}
