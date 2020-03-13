using Microsoft.AspNetCore.Mvc;
using WebSafeLife.ViewModels;

namespace WebSafeLife.Controllers
{
    public class DadosMedicosController : Controller
    {
        public IActionResult Index()
        {
            DadosMedicosViewModel dadosMedicos = new DadosMedicosViewModel();
            return View(dadosMedicos);
        }
    }
}