using dasho.DataAccess.Data;
using dasho.DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace dasho.Areas.Customer.Controllers
{
    public class ProductController : Controller
    {
        private ApplicationDbContext _context;

        private readonly IUnitOfWorks _db;
        public ProductController(IUnitOfWorks db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
