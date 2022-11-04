using CrudLL.Data;
using CrudLL.Models;
using Microsoft.AspNetCore.Mvc;

namespace CrudLL.Controllers
{
    public class CadastroController : Controller
    {
        private readonly AppDbContext _context; 
        public CadastroController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(TabelaBd cadastroModel)
        {
           if (ModelState.IsValid)
            {
                _context.Cadastros.Add(cadastroModel);
                _context.SaveChanges();
                TempData["sucesso"] = "Cadastro criado com sucesso";
                return RedirectToAction("Index", "Home");
            }
            return View(cadastroModel);
        }

        //EDITAR CADASTRO
        public IActionResult Editar(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            var cadastroFromDb = _context.Cadastros.Find(Id);

            if (cadastroFromDb == null)
            {
                return NotFound();
            }

            return View(cadastroFromDb);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Editar(TabelaBd cadastroModel)
        {
            if (ModelState.IsValid)
            {
                _context.Cadastros.Update(cadastroModel);
                _context.SaveChanges();
                TempData["sucesso"] = "Cadastro editado com sucesso";
                return RedirectToAction("Index", "Home");
            }
            return View(cadastroModel);
        }

        ///apagar
        public IActionResult Apagar(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            var cadastroFromDb = _context.Cadastros.Find(Id);

            if (cadastroFromDb == null)
            {
                return NotFound();
            }

            return View(cadastroFromDb);
        }
        [HttpPost]
        public IActionResult Apagar(TabelaBd cadastroModel)
        {
            _context.Cadastros.Remove(cadastroModel);
            _context.SaveChanges();
            TempData["sucesso"] = "Cadastro apagado com sucesso";
            return RedirectToAction("Index", "Home");
            }
        }
    }
