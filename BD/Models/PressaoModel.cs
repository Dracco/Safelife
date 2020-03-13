using System;
using System.ComponentModel.DataAnnotations;

namespace BD.Models
{
    public class PressaoModel : DadosControleModel
    {
        [Key]
        public Guid Id { get; set; }
        public Guid IdPaciente { get; set; }
        public int Sistolica { get; set; }
        public int Diastolica { get; set; }
        public DateTime Data { get; set; }
    }
}
