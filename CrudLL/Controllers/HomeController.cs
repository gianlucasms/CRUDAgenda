using CrudLL.Data;
using CrudLL.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CrudLL.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context )
        {
            _context = context; 
        }

        public IActionResult Index()
        {
            IEnumerable<TabelaBd> lista = _context.Cadastros;
            return View(lista);
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