using Microsoft.AspNetCore.Mvc;
using WebSafeLife.ViewModels;

namespace WebSafeLife.Controllers
{
    public class MedicamentosController : Controller
    {
        public IActionResult Index()
        {
            MedicamentosViewModel medicamentos = new MedicamentosViewModel();
            return View(medicamentos);
        }
    }
}