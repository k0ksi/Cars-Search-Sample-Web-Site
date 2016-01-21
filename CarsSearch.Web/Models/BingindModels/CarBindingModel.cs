namespace CarsSearch.Web.Models.BingindModels
{
    using System.ComponentModel.DataAnnotations;

    public class CarBindingModel
    {
        [Display(Name = "Марка")]
        public int BrandId { get; set; }

        [Required(ErrorMessage = "Полето за година е задължително.")]
        [Range(1900, 2016, ErrorMessage = "Полето за година може да приема стойност от 1900 до 2016.")]
        [Display(Name = "Година")]
        public int YearManufactured { get; set; }

        [Required(ErrorMessage = "Полето за мощност е задължително.")]
        [Range(40, 1100, ErrorMessage = "Полето за мощност може да приема стойност от 40 до 1100.")]
        [Display(Name = "Мощност")]
        public double HorsePower { get; set; }

        [Display(Name = "Вносител")]
        public int ImporterId { get; set; }

        [Required(ErrorMessage = "Полето за описание е задължително.")]
        [MinLength(2, ErrorMessage = "Полето за описание трябва да съдържа минимум 2 символа.")]
        [MaxLength(1000, ErrorMessage = "Полето за описание трябва да съдържа не повече от 1000 символа.")]
        [Display(Name = "Описание")]
        public string Description { get; set; }
    }
}