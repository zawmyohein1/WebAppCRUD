using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebAppCRUD.Models;

namespace WebAppCRUD.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CRUDDbContext _crudDbContext;

        public HomeController(ILogger<HomeController> logger, CRUDDbContext dbContext)
        {
            _logger = logger;
            _crudDbContext = dbContext;
        }

        public IActionResult Index()
        {
            var employees = _crudDbContext.Employees;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
