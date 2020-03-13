using System;
using SafeLife.Lib;

namespace SafeLife.Models
{
    public class CirurgiaModel : DadosControle
    {
        public Guid Id { get; set; }
        public Guid IdPaciente { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
        public string Local { get; set; }
    }
}
