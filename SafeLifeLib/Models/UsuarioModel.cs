using System;
using System.ComponentModel.DataAnnotations;

using SafeLifeLib.Enums;

namespace SafeLifeLib.Models
{
    public class UsuarioModel : DadosControleModel
    {
        [Key]
        public Guid Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public TipoUsuario TipoUsuario { get; set; }
        public string Local { get; set; }
        public DateTime Data { get; set; }
    }
}
