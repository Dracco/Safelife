using System;
using System.ComponentModel.DataAnnotations;
using WebSafeLife.Lib;

namespace WebSafeLife.Models
{
    public class ConteudoUsuarioModel : DadosControle
    {
        [Key]
        public Guid Id { get; set; }
        public Guid IdConteudo { get; set; }
        public Guid IdUsuario { get; set; }

    }
}
