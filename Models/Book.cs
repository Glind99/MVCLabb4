using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCLabb4.Models
{
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("Book id")]
        public int BookId { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string Title { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string Author { get; set; }

        [Required]
        public string Genre { get; set; }

        public string BookDisplay => $"{Title} - {Author}";

        public virtual ICollection<BookLoan>? BookLoans { get; set; } //Navigation

    }
}
