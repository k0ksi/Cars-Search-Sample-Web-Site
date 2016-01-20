namespace CarsSearch.Data
{
    using System.Data.Entity;
    using Models;

    public interface ICarsSearchDbContext
    {
        IDbSet<Brand> Brands { get; set; } 

        IDbSet<Car> Cars { get; set; } 

        IDbSet<Importer> Importers { get; set; }

        int SaveChanges();
    }
}