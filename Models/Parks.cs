using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace USPark.Models
{
    [Table("parks")]
    public class Park
    {
        [Key]
        public int ParkId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Age { get; set; }
    }
}