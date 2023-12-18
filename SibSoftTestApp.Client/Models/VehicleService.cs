using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SibSoftTestApp.Client.Models
{
    [Table("VehicleServices")]
    public class VehicleService
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int serviceId { get; set; }
        [ForeignKey("Customer")]
        public string customerTaxNumber { get; set; }
        [ForeignKey("Performer")]
        public string performerTaxNumber { get; set; }
        [ForeignKey("Vehicle")]
        public string vehicleNumber { get; set; }
        [DataType(DataType.Text)]
        [Column(TypeName = "nvarchar(2000)")]
        public string vehicleServiceDescription { get; set; }
        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        [DisplayFormat(DataFormatString = "{0:yyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime serviceDate { get; set; }
        [Column(TypeName = "float")]
        public float servicePrice { get; set; }
        [Column(TypeName = "float")]
        public float vehicleMileage { get; set; }
    }
}