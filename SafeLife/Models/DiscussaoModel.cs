using System;
using System.ComponentModel.DataAnnotations;
using SafeLife.Lib;

namespace SafeLife.Models
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
