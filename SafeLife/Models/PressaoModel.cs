using System;
using System.ComponentModel.DataAnnotations;
using SafeLife.Lib;

namespace SafeLife.Models
{
    public class PressaoModel : DadosControle
    {
        [Key]
        public Guid Id { get; set; }
        public Guid IdPaciente { get; set; }
        public int Sistolica { get; set; }
        public int Diastolica { get; set; }
        public DateTime Data { get; set; }
    }
}
