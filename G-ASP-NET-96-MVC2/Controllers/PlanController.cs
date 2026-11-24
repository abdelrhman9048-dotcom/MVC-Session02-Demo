
using G_ASP_NET_96_MVC2.Contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace G_ASP_NET_96_MVC2.Controllers
{
    public class PlanController : Controller
    {
        private readonly GymDbContext dbContext;

        public PlanController(GymDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IActionResult IndexTest()
        {
            return View();
        }

        public async Task<IActionResult> Index()
        {
            var plans = await dbContext.Plans.ToListAsync();
            return View(plans);
        }
    }
}
