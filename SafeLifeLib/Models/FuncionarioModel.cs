using System;
using System.ComponentModel.DataAnnotations;


namespace SafeLifeLib.Models
{
    public class FuncionarioModel : DadosControleModel
    {
        [Key]
        public Guid Id { get; set; }
        public Guid IdUsuario { get; set; }
        public string Registro { get; set; }
        public Guid IdPessoa { get; set; }
    }
}
