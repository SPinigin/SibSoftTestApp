using System.ComponentModel.DataAnnotations.Schema;

namespace SibSoftTestApp.Client.Models
{
    [Table("Performers")]
    public class Performer
    {
        public int performerId { get; set; }
        public string performerTaxNumber{ get; set; }
        public string performerName { get; set; }
    }
}