using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCLabb4.Models
{
    public class BookLoan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookLoanId { get; set; }
        
        [ForeignKey("Customer")]
        [DisplayName("Customer")]
        public int FK_CustomerID { get; set; }
        
        [ForeignKey("Book")]
        [DisplayName("Book")]
        public int FK_BookID { get; set; }

        [Required]
        [DisplayName("Loan date")]
        public DateTime LoanDate { get; set; }
        
        [Required]
        [DisplayName("Returning date")]
        public DateTime? ReturnDate { get; set; }  //Nullable

        [DisplayName("Returned date")]
        public DateTime? ReturnedAt { get; set; } //Nullable
       
        [DisplayName("Late/not returned")]
        public bool IsLateOrNotReturned { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Book Book { get; set; }

    }
}
