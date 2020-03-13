using Microsoft.AspNetCore.Mvc;
using WebSafeLife.ViewModels;

namespace WebSafeLife.Controllers
{
    public class FichaController : Controller
    {
        public IActionResult Index()
        {
            FichaViewModel ficha = new FichaViewModel();
            return View(ficha);
        }
    }
}