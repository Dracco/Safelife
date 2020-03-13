using System;
using System.ComponentModel.DataAnnotations;

namespace BD.Models
{
    public class DiscussaoModel : DadosControleModel
    {
        [Key]
        public Guid Id { get; set; }
        public Guid IdForum { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
    }
}
