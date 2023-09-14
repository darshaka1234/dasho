using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dasho.DataAccess.Repository.IRepository;
using dasho.DataAccess.Data;
using dasho.Areas.Customer.Models;
using dasho.Models;

namespace dasho.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _db;


        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Product obj)
        {
            _db.Prodcts.Update(obj);
        }
    }
}
