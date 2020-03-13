using SafeLifeLib.Models;
using System.Collections.Generic;


namespace WebSafeLife.ViewModels
{
    public class MedicamentosViewModel
    {
        public List<MedicamentoModel> Medicamentos { get; set; }

        public MedicamentosViewModel()
        {
            Medicamentos = new List<MedicamentoModel>();
        }
    }
}
