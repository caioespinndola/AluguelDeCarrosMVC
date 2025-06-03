using AluguelDeCarros.Data;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace AluguelDeCarros.Controllers
{
    public class SuporteController : Controller
    {
        private readonly AppDbContext _context;

        public SuporteController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var mensagens = _context.WebApplication.ToList();
            return View(mensagens);
        }

        public IActionResult Contato()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contato(SuporteMensagem mensagem)
        {
            _context.WebApplication.Add(mensagem);
            _context.SaveChanges();
            return RedirectToAction("Obrigado");
        }

        public IActionResult Obrigado()
        {
            return View();
        }
    }
}
