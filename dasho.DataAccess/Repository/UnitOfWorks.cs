using dasho.DataAccess.Data;
using dasho.DataAccess.Repository.IRepository;


namespace dasho.DataAccess.Repository
{
    public class UnitOfWorks : IUnitOfWorks
    {
        private ApplicationDbContext _db;

        public ICategoryRepository Category { get; private set; }
        public IProductRepository Product { get; private set; }

        public UnitOfWorks(ApplicationDbContext db)
        {
           _db = db;
            Category = new CategoryRepository(_db);
            Product = new ProductRepository(_db);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
