using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SibSoftTestApp.RestApi.Models
{
    public class Vehicle
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int vehicleId { get; set; }
        public string vehicleNumber { get; set; }
        public string vehicleBrand { get; set; }
        public string vehicleModel { get; set; }
    }
}