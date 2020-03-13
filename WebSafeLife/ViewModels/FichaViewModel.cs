using SafeLifeLib.Models;
using System.Collections.Generic;


namespace WebSafeLife.ViewModels
{
    public class FichaViewModel
    {
        public PessoaModel Pessoa { get; set; }
        public PesoModel Peso { get; set; }
        public DadosMedicosModel DadosMedicos { get; set; }
        public ProcedimentoModel Procedimento { get; set; }
        public PatologiaModel Patologia { get; set; }
        public List<MedicamentoModel> Medicamentos { get; set; }
        public List<PressaoModel> Pressoes { get; set; }

        public FichaViewModel()
        {
            Pessoa = new PessoaModel();
            Medicamentos = new List<MedicamentoModel>();
            Pressoes = new List<PressaoModel>();
        }
    }
}
