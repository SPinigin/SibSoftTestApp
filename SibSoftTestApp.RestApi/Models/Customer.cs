using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SibSoftTestApp.RestApi.Models
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int customerId { get; set; }
        [MaxLength(12,ErrorMessage = "ИНН не может быть длинной более 12 символов")]
        [MinLength(10, ErrorMessage = "ИНН не может быть длинной менее 10 символов")]
        public string customerTaxNumber { get; set; }
        public string customerName { get; set; }
    }
}