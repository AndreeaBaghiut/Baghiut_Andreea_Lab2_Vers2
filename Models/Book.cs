using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace Baghiut_Andreea_Lab2.Models
{
    public class Book
    {
        public int ID { get; set; }

        [Display(Name = "Book Title")]
        [Required(ErrorMessage = "The title is required.")]
        [StringLength(150, MinimumLength = 3, ErrorMessage = "The title must be between 3 and 150 characters.")]
        public string Title { get; set; }
        // public string Author { get; set; }


        [Column(TypeName = "decimal(6, 2)") ]
        [Range(0.01, 500)]
        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime PublishingDate { get; set; }
        public int? PublisherID { get; set; }
        public Publisher? Publisher { get; set; }
        public int? AuthorId { get; set; }

        public Author? Author { get; set; }

        public int? BorrowingID { get; set; }
        public Borrowing? Borrowing { get; set; }

         [Display(Name = "Category")]
        public ICollection<BookCategory>? BookCategories { get; set; }

    }
}
