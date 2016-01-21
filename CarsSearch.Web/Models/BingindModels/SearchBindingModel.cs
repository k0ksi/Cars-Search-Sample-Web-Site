namespace CarsSearch.Web.Models.BingindModels
{
    using System.ComponentModel.DataAnnotations;

    public class SearchBindingModel
    {
        [MinLength(3, ErrorMessage = "Полето за описание трябва да съдържа минимум 3 символа.")]
        [MaxLength(20, ErrorMessage = "Полето за описание трябва да съдържа не повече от 20 символа.")]
        [Display(Name = "Описание")]
        public string Description { get; set; } 

        [Display(Name = "Вносител")]
        public int ImporterId { get; set; }
    }
}