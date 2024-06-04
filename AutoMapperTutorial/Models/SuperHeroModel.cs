using System.ComponentModel.DataAnnotations;
using System.Data;

namespace AutoMapperTutorial.Models
{
    public class SuperHeroModel
    {
        [Key]
        public int Id { get; set; }
        public string? HeroName { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Active_City { get; set; }
        public DateTime HeroRegisterd { get; set; } = DateTime.Now;
        public bool isActive { get; set; }
    }
}
