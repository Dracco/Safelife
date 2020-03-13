using System;
using System.ComponentModel.DataAnnotations;


namespace SafeLifeLib.Models
{
    public class ConteudoUsuarioModel : DadosControleModel
    {
        [Key]
        public Guid Id { get; set; }
        public Guid IdConteudo { get; set; }
        public Guid IdUsuario { get; set; }

    }
}
