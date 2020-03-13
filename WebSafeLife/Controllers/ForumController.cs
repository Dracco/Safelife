using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;


namespace WebSafeLife.Controllers
{
    public class ForumController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Ler()
        {
            return View();
        }

        public IActionResult Escrever()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return null;
            //return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
