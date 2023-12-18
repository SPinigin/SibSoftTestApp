using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SibSoftTestApp.RestApi.Models
{
    public class Performer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int performerId { get; set; }
        [MaxLength(12, ErrorMessage = "ИНН не может быть длинной более 12 символов")]
        [MinLength(10, ErrorMessage = "ИНН не может быть длинной менее 10 символов")]
        public string performerTaxNumber { get; set; }
        public string performerName { get; set; }
    }
}