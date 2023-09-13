using dasho.Models;
using dasho.Repository.IRepository;

namespace dasho.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category obj);
    
    }
}
