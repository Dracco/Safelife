using SafeLifeLib.Models;
using System.Collections.Generic;


namespace WebSafeLife.ViewModels
{
    public class ExamesViewModel
    {
        public ExamesViewModel()
        {
            Exames = new List<ExameModel>();
        }

        public List<ExameModel> Exames { get; set; }

        
    }
}
