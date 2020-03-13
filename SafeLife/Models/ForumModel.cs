using System;
using System.ComponentModel.DataAnnotations;
using SafeLife.Lib;

namespace SafeLife.Models
{
    public class ForumModel : DadosControle
    {
        [Key]
        public Guid Id { get; set; }
        public string Assunto { get; set; }
        public string Descricao { get; set; }
    }
}
