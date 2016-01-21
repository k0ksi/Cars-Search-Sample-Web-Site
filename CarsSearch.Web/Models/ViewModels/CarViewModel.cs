namespace CarsSearch.Web.Models.ViewModels
{
    using System;
    using System.Linq.Expressions;
    using CarsSearch.Models;

    public class CarViewModel
    {
        public int Id { get; set; }

        public string BrandName { get; set; }

        public int YearManufactured { get; set; }

        public double HorsePower { get; set; }

        public string ImporterName { get; set; }

        public int ImporterId { get; set; }

        public string Description { get; set; }

        public static Expression<Func<Car, CarViewModel>> Create
        {
            get
            {
                return car => new CarViewModel()
                {
                    Id = car.Id,
                    BrandName = car.Brand.Name,
                    YearManufactured = car.YearManufactured,
                    HorsePower = car.HorsePower,
                    ImporterName = car.Importer.Name,
                    ImporterId = car.ImporterId,
                    Description = car.Description
                };
            }
        } 
    }
}