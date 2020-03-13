using System;
using System.ComponentModel.DataAnnotations;
using WebSafeLife.Lib;

namespace WebSafeLife.Models
{
    public class DiscussaoModel : DadosControle
    {
        [Key]
        public Guid Id { get; set; }
        public Guid IdForum { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
    }
}
