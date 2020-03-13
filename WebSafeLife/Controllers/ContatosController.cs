using Microsoft.AspNetCore.Mvc;
using WebSafeLife.ViewModels;

namespace WebSafeLife.Controllers
{
    public class ContatosController : Controller
    {
        public IActionResult Index()
        {
            ContatosViewModel contatos = new ContatosViewModel();
            return View(contatos);
        }
    }
}