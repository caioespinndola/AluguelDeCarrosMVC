using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class AluguelController : Controller
    {
        public IActionResult Finalizar(int id)
        {
            
            ViewBag.CarroId = id;
            return View();
        }

        public IActionResult Confirmacao()
        {
            
            return View();
        }
    }
}
