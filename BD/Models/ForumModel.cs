using System;
using System.ComponentModel.DataAnnotations;

namespace BD.Models
{
    public class ForumModel : DadosControleModel
    {
        [Key]
        public Guid Id { get; set; }
        public string Assunto { get; set; }
        public string Descricao { get; set; }
    }
}
