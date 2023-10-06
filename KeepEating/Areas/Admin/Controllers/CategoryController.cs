using KeepEating.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace KeepEating.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        //GET
        public async Task<IActionResult> Index()
        {
            return View(await _db.Category.ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
