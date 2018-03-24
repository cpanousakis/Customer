using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Customers.Models
{
    public class CustomerContact
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        [MaxLength(100)]
        public string Email { get; set; }
        //Foreign Key from Customer
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        //Navigation property pointing to related customer
        public virtual Customer Customer { get; set; }

    }
}