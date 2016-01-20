namespace CarsSearch.Data.UnitOfWork
{
    using System;
    using System.Collections.Generic;
    using Models;
    using Repositories;

    public class CartSearchData : ICartSearchData
    {
        private ICarsSearchDbContext context;
        private IDictionary<Type, object> repositories;

        public CartSearchData(ICarsSearchDbContext context)
        {
            this.context = context;
            this.repositories = new Dictionary<Type, object>();
        }

        public IRepository<User> Users => this.GetRepository<User>();

        public IRepository<Brand> Brands => this.GetRepository<Brand>();

        public IRepository<Importer> Importers => this.GetRepository<Importer>();

        public IRepository<Car> Cars => this.GetRepository<Car>();

        public int SaveChanges()
        {
            return this.context.SaveChanges();
        }

        private IRepository<T> GetRepository<T>() where T : class
        {
            var type = typeof(T);
            if (!this.repositories.ContainsKey(type))
            {
                var typeOfRepository = typeof(GenericRepository<T>);

                var repository = Activator.CreateInstance(typeOfRepository, this.context);
                this.repositories.Add(type, repository);
            }

            return (IRepository<T>)this.repositories[type];
        }
    }
}