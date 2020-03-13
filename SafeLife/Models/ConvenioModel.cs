using System;
using System.ComponentModel.DataAnnotations;
using SafeLife.Lib;

namespace SafeLife.Models
{
    public class ConvenioModel : DadosControle
    {
        [Key]
        public Guid Id { get; set; }
        public Guid IdPaciente { get; set; }
        public string Operadora { get; set; }
        public string Plano { get; set; }
        public string Matricula { get; set; }
        public string ViaCarteirinha { get; set; }
        public string CodSeguranca { get; set; }
        public DateTime DataValidade { get; set; }
    }
}
