using SafeLifeLib.Models;
using System.Collections.Generic;


namespace WebSafeLife.ViewModels
{
    public class DadosMedicosViewModel
    {
        public PesoModel Peso { get; set; }
        public DadosMedicosModel DadosMedicos { get; set; }
        public ProcedimentoModel Procedimento { get; set; }
        public PatologiaModel Patologia { get; set; }
        public DiaaDiaModel DiaaDia { get; set; }
        public List<VacinaModel> Vacinas { get; set; }
        public List<ConvenioModel> Convenios { get; set; }
        public List<CirurgiaModel> Cirurgias { get; set; }

        public DadosMedicosViewModel()
        {
            Vacinas = new List<VacinaModel>();
            Convenios = new List<ConvenioModel>();
            Cirurgias = new List<CirurgiaModel>();
        }
    }
}
