using BD.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace BD.Models
{
    public class LocalModel : DadosControleModel
    {
        [Key]
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public TipoLocal TipoLocal { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
    }
}
