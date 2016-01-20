namespace CarsSearch.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Car
    {
        [Key]
        public int Id { get; set; }

        public int BrandId { get; set; }

        public virtual Brand Brand { get; set; }

        [Range(1900, 2016)]
        public int YearManufactured { get; set; }

        public double HorsePower { get; set; }

        public int ImporterId { get; set; }

        public virtual Importer Importer { get; set; }
        
        [Required]
        [MinLength(2)]
        [MaxLength(1000)]
        public string Description { get; set; }
    }
}