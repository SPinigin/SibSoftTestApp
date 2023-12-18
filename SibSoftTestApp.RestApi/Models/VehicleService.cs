using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SibSoftTestApp.RestApi.Models
{
    public class VehicleService
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int serviceId { get; set; }
        public int customerId { get; set; }
        public int performerId { get; set; }
        public string vehicleNumber { get; set; }
        [DataType(DataType.Text)]
        [Column(TypeName = "nvarchar(2000)")]
        public string vehicleServiceDescription { get; set; }
        [DataType(DataType.Date)]
        [Column(TypeName = "date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime serviceDate { get; set; }
        public float servicePrice { get; set; }
        public float vehicleMileage { get; set; }
    }
}