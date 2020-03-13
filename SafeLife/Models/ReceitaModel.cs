using System;
using System.ComponentModel.DataAnnotations;
using SafeLife.Lib;

namespace SafeLife.Models
{
    public class ReceitaModel : DadosControle
    {
        [Key]
        public Guid Id { get; set; }
        public Guid IdProntuario { get; set; }
        public Guid IdMedicamento { get; set; }
    }
}
