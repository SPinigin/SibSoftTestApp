using System.ComponentModel.DataAnnotations.Schema;

namespace SibSoftTestApp.Client.Models
{
    [Table("Customers")]
    public class Customer
    {
        public int customerId { get; set; }
        public string customerTaxNumber{ get; set; }
        public string customerName { get; set; }
    }
}