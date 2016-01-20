namespace CarsSearch.Data
{
    using System.Data.Entity;
    using Models;
    using Microsoft.AspNet.Identity.EntityFramework;

    public class CarsSearchDbContext : IdentityDbContext<User>, ICarsSearchDbContext
    {
        public CarsSearchDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public IDbSet<Brand> Brands { get; set; }

        public IDbSet<Car> Cars { get; set; }

        public IDbSet<Importer> Importers { get; set; }

        public static CarsSearchDbContext Create()
        {
            return new CarsSearchDbContext();
        }
    }
}