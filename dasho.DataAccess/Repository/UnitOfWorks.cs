using dasho.DataAccess.Data;
using dasho.DataAccess.Repository.IRepository;


namespace dasho.DataAccess.Repository
{
    public class UnitOfWorks : IUnitOfWorks
    {
        private ApplicationDbContext _db;

        public ICategoryRepository Category { get; private set; }

        public UnitOfWorks(ApplicationDbContext db)
        {
           _db = db;
            Category = new CategoryRepository(_db);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
