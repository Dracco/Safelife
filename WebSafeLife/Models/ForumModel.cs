using System;
using System.ComponentModel.DataAnnotations;
using WebSafeLife.Lib;

namespace WebSafeLife.Models
{
    public class ForumModel : DadosControle
    {
        [Key]
        public Guid Id { get; set; }
        public string Assunto { get; set; }
        public string Descricao { get; set; }
    }
}
