using AluguelDeCarros.Data;

using AluguelDeCarrosMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace AluguelDeCarros.Controllers
{
    public class CarrosController : Controller
    {
        private readonly AppDbContext _context;

        public CarrosController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("Carros")]
        public IActionResult Index()
        {
            var carros = _context.Carros.ToList();
            return View(carros);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Carro carro)
        {
            _context.Carros.Add(carro);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
        [HttpGet]
        [Route("Carros/Detalhes/{id}")]
        public IActionResult Detalhes (int id)
        {
            var carros = _context.Carros.ToList().Where(x => x.Id == id).FirstOrDefault();
            return View(carros);

        }
    }
}