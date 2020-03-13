using System;
using System.ComponentModel.DataAnnotations;


namespace SafeLifeLib.Models
{
    public class ReceitaModel : DadosControleModel
    {
        [Key]
        public Guid Id { get; set; }
        public Guid IdProntuario { get; set; }
        public Guid IdMedicamento { get; set; }
    }
}
