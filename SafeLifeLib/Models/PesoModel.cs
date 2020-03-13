using System;
using System.ComponentModel.DataAnnotations;


namespace SafeLifeLib.Models
{
    public class PesoModel : DadosControleModel
    {
        [Key]
        public Guid Id { get; set; }
        public Guid IdPaciente { get; set; }
        public decimal Peso { get; set; }
        public DateTime Data { get; set; }
    }
}
