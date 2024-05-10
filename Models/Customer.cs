using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MVCLabb4.Models
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("Customer id")]
        public int CustomerId { get; set; } = 0;
        [Required]
        [StringLength(50, MinimumLength = 1)]
        [DisplayName("First name")]
        public string FirstName { get; set; } = default!;
        [Required]
        [StringLength(50, MinimumLength = 1)]
        [DisplayName("Last name")]
        public string LastName { get; set; } = default!;

        public string FullName => $"{FirstName} {LastName}";

        [Required]
        [StringLength(70, MinimumLength = 1)]
        [DisplayName("Adress")]
        public string Address { get; set; } = default!;
        
        [Required]
        [MinLength(1), MaxLength(15)]
        [DisplayName("Phone number")]
        public string PhoneNumber { get; set; } = default!;
        public virtual ICollection<BookLoan>? BookLoans { get; set; } //Navigation

    }
}
