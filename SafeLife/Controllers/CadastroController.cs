using Microsoft.AspNetCore.Mvc;
using SafeLifeLib.Models;

namespace SafeLife.Controllers
{
    [Route("Cadastro/[controller]")]
    public class CadastroController : Controller
    {
        

        [HttpPost]
        [Route("Salvar")]
        public JsonResult Salvar([FromBody]PessoaModel pessoa)
        {
            BD.PessoaRepositorio repositorio = new BD.PessoaRepositorio();
            repositorio.Salvar(pessoa);
            repositorio.Consultar(pessoa.Id);
            return Json(true);
        }
    }
}