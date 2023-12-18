using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SibSoftTestApp.Client.Models
{
    [Table("Vehicles")]
    public class Vehicle
    {
        public int vehicleId {  get; set; }
        public string vehicleNumber { get; set; }
        public string vehicleBrand {  get; set; }
        public string vehicleModel { get; set; }
    }
}