using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    [Table("cities")]
    public class City
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("created")]
        public DateTime Created { get; set; }
    }
}
