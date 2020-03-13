using System;
using System.ComponentModel.DataAnnotations;
using SafeLife.Lib;

namespace SafeLife.Models
{
    public class FuncionarioModel : DadosControle
    {
        [Key]
        public Guid Id { get; set; }
        public Guid IdUsuario { get; set; }
        public string Registro { get; set; }
        public Guid IdPessoa { get; set; }
    }
}
