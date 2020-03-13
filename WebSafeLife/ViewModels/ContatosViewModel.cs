using SafeLifeLib.Models;
using System.Collections.Generic;


namespace WebSafeLife.ViewModels
{
    public class ContatosViewModel
    {
        public List<ContatoModel> Contatos { get; set; }

        public ContatosViewModel()
        {
            Contatos = new List<ContatoModel>();
        }
    }
}
