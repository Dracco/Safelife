using System;
using System.ComponentModel.DataAnnotations;
using SafeLife.Lib;

namespace SafeLife.Models
{
    public class VacinaModel : DadosControle
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
