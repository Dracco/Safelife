using System;
using System.ComponentModel.DataAnnotations;


namespace SafeLifeLib.Models
{
    public class VacinaModel : DadosControleModel
    {
        [Key]
        public Guid Id { get; set; }
        public Guid IdPaciente { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Local { get; set; }
        public DateTime Data { get; set; }
    }
}
