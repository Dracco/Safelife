using System;
using System.ComponentModel.DataAnnotations;
using SafeLife.Lib;

namespace SafeLife.Models
{
    public class NotificacaoModel : DadosControle
    {
        [Key]
        public Guid Id { get; set; }
        public Guid IdUsuario { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Html { get; set; }
        public bool Lida { get; set; }
        public bool Ignorada { get; set; }
    }
}
