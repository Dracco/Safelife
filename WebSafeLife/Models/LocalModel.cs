using System;
using System.ComponentModel.DataAnnotations;
using WebSafeLife.Lib;
using WebSafeLife.Enums;

namespace WebSafeLife.Models
{
    public class LocalModel : DadosControle
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
