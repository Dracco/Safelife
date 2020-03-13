using System;
using System.ComponentModel.DataAnnotations;
using WebSafeLife.Lib;

namespace WebSafeLife.Models
{
    public class DiaaDiaModel : DadosControle
    {
        [Key]
        public Guid Id { get; set; }
        public Guid IdPaciente { get; set; }
        public int PraticaAtividadeFisica { get; set; }
        public int Fuma { get; set; }
        public int BebeAlcool { get; set; }
        public int UsaDrogas { get; set; }
    }
}
