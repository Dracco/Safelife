using Microsoft.AspNetCore.Mvc;
using WebSafeLife.ViewModels;

namespace WebSafeLife.Controllers
{
    public class ExamesController : Controller
    {
        public IActionResult Index()
        {
            ExamesViewModel exames = new ExamesViewModel();
            return View(exames);
        }
    }
}