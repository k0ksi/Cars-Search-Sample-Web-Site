namespace CarsSearch.Data
{
    using CarsSearch.Models;
    using Microsoft.AspNet.Identity.EntityFramework;

    public class CarsSearchDbContext : IdentityDbContext<User>
    {
        public CarsSearchDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static CarsSearchDbContext Create()
        {
            return new CarsSearchDbContext();
        }
    }
}