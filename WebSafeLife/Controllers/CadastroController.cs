using Microsoft.AspNetCore.Mvc;
using SafeLife.Lib;
using SafeLifeLib.Models;
using System;
using WebSafeLife.Lib;


namespace WebSafeLife.Controllers
{
    public class CadastroController : Controller
    {
        public IActionResult Index()
        {
            Mock mock = new Mock();

            ViewModels.CadastroViewModel cadastro = mock.Cadastros[0];
            SafeLife.Controllers.CadastroController controller = new SafeLife.Controllers.CadastroController();
            controller.Salvar(cadastro.Pessoa);
            
            return View(cadastro);
        }

        public void Salvar(ViewModels.CadastroViewModel model)
        {
            //if (tem_id_preenchido)
            //{
            //    update(model);
            //}
            //else
            //{
            //    insert(model);
            //}
        }

        public JsonResult DadosCep(string cep)
        {
            try
            {
                ViaCepModel viacep = new ViaCepModel();
                viacep = Util.GetJsonAndDeserialize<ViaCepModel>("https://viacep.com.br/ws/CEP/json/".Replace("CEP",
                    cep.Replace(".", "").Replace("-", "")), "", "GET", "text/json");
                viacep.Cidade = viacep.Localidade;
                return Json(viacep);
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}