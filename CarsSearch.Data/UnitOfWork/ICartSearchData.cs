namespace CarsSearch.Data.UnitOfWork
{
    using Models;
    using Repositories;

    public interface ICartSearchData
    {
        IRepository<User> Users { get; } 

        IRepository<Brand> Brands { get; } 

        IRepository<Importer> Importers { get; } 

        IRepository<Car> Cars { get; }

        int SaveChanges();
    }
}