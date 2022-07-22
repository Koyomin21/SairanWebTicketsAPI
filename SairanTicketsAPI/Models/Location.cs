using System.ComponentModel.DataAnnotations.Schema;

namespace SairanTicketsAPI.Models
{
    public class Location
    {
        public int Id { get; set; }
        
        [Column(TypeName = "nvarchar(200)")]
        public string Name { get; set; }

        [Column(TypeName = "decimal(3,2)")]
        public decimal Longitude { get; set; }

        [Column(TypeName = "decimal(2,2)")]
        public decimal Latitude { get; set; }
    }
}
