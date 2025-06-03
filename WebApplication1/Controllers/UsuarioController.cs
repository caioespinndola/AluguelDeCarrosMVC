using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class UsuarioController : Controller
    {

        public IActionResult Perfil()
        {
            return View();
        }

        
        public IActionResult MeusAlugueis()
        {
            return View();
        }
    }
}
