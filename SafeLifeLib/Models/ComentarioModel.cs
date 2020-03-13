using System;
using System.ComponentModel.DataAnnotations;


namespace SafeLifeLib.Models
{
    public class ComentarioModel : DadosControleModel
    {
        [Key]
        public Guid Id { get; set; }
        public Guid IdProntuario { get; set; }
        public string Descricao { get; set; }
    }
}
