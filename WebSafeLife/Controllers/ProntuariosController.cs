using Microsoft.AspNetCore.Mvc;

namespace WebSafeLife.Controllers
{
    public class ProntuariosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Receita()
        {
            return View();
        }
        public IActionResult Receita_Impressao()
        {
            return View();
        }
    }
}