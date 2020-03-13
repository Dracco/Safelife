using System;
using System.ComponentModel.DataAnnotations;

namespace BD.Models
{
    public class DadosMedicosModel : DadosControleModel
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
