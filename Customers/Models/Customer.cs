using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Customers.Models
{
    public class Customer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string Title { get; set; }
        [Range(0,10000)]
        public int NumberOfEmployees { get; set; }
    }
}