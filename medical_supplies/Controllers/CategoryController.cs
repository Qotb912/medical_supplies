using medical_supplies.Data;
using Microsoft.AspNetCore.Mvc;

namespace medical_supplies.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext  dbContext)
        {
            _db = dbContext;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
