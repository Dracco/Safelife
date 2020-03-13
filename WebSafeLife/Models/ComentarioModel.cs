using System;
using System.ComponentModel.DataAnnotations;
using WebSafeLife.Lib;

namespace WebSafeLife.Models
{
    public class ComentarioModel : DadosControle
    {
        [Key]
        public Guid Id { get; set; }
        public Guid IdProntuario { get; set; }
        public string Descricao { get; set; }
    }
}
