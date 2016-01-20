namespace CarsSearch.Data.Migrations
{
    using System.Data.Entity.Migrations;

    public sealed class CartSearchDbConfiguration : DbMigrationsConfiguration<CarsSearchDbContext>
    {
        public CartSearchDbConfiguration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
            this.ContextKey = "CarsSearch.Data.CarsSearchDbContext";
        }

        protected override void Seed(CarsSearchDbContext context)
        {

        }
    }
}