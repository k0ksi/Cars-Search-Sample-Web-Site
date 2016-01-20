namespace CarsSearch.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Importer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(100)]
        public string Name { get; set; } 
    }
}