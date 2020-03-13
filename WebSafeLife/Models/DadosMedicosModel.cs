using System;
using System.ComponentModel.DataAnnotations;
using WebSafeLife.Lib;

namespace WebSafeLife.Models
{
    public class DadosMedicosModel1 : DadosControle
    {
        [Key]
        public Guid Id { get; set; }
        public Guid IdPaciente { get; set; }
        public char TipoSanguineo { get; set; }
        public char FatorRh { get; set; }
        public string HistoricoFamiliar { get; set; }
        public string Altura { get; set; }
        public string Alergia { get; set; }
    }
}
