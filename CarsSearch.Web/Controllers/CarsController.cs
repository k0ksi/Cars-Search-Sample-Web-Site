namespace CarsSearch.Web.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Mvc;
    using System.Web.Mvc.Expressions;
    using CarsSearch.Models;
    using Data.UnitOfWork;
    using Extensions;
    using Models.BingindModels;
    using Models.ViewModels;

    public class CarsController : BaseController
    {
        private static ICollection<CarViewModel> searchResults; 

        public CarsController(ICarsSearchData data) 
            : base(data)
        {
        }

        [HttpGet]
        public ActionResult Add()
        {
            this.LoadImporters();
            this.LoadBrands();

            return this.View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(true)]
        public ActionResult Add(CarBindingModel model)
        {
            if (model != null && this.ModelState.IsValid)
            {
                this.LoadBrands();
                this.LoadImporters();

                var car = new Car()
                {
                    BrandId = model.BrandId,
                    YearManufactured = model.YearManufactured,
                    HorsePower = model.HorsePower,
                    ImporterId = model.ImporterId,
                    Description = model.Description
                };

                this.Data.Cars.Add(car);

                this.Data.SaveChanges();
                this.AddNotification("Добавихте нова кола!", NotificationType.SUCCESS);

                return this.RedirectToAction("Index", "Home");
            }

            this.LoadBrands();
            this.LoadImporters();

            return this.View(model);
        }

        [HttpGet]
        public ActionResult ViewResults()
        {
            return this.View(searchResults);
        }

        [HttpGet]
        public ActionResult Search()
        {
            this.LoadImporters();

            return this.View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Search(SearchBindingModel model)
        {
            if (model != null && this.ModelState.IsValid)
            {
                searchResults = new HashSet<CarViewModel>();

                var cars = this.Data.Cars
                    .All()
                    .Where(x => x.ImporterId == model.ImporterId);
                    

                if (!string.IsNullOrEmpty(model.Description))
                {
                    cars =  cars.Where(x => x.Description.ToLower().Contains(model.Description.ToLower()));
                }

                var results = cars.OrderBy(x => x.YearManufactured)
                    .Select(CarViewModel.Create)
                    .AsEnumerable();

                foreach (var car in results)
                {
                    searchResults.Add(car);
                }

                return this.RedirectToAction(a => ViewResults());
            }

            this.LoadBrands();
            this.LoadImporters();

            return this.View(model);
        }

        private IQueryable<SelectListItem> LoadImporters()
        {
            var importers = this.Data.Importers
                .All()
                .Select(x => new SelectListItem()
                {
                    Value = x.Id.ToString(),
                    Text = x.Name
                });
            this.ViewBag.Importers = importers;

            return importers;
        }

        private IQueryable<SelectListItem> LoadBrands()
        {
            var brands = this.Data.Brands
                .All()
                .Select(x => new SelectListItem()
                {
                    Value = x.Id.ToString(),
                    Text = x.Name
                });
            this.ViewBag.Brands = brands;

            return brands;
        } 
    }
}