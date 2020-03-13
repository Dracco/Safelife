using System;
using System.ComponentModel.DataAnnotations;
using WebSafeLife.Lib;

namespace WebSafeLife.Models
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
