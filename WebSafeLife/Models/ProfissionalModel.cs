using System;
using System.ComponentModel.DataAnnotations;
using WebSafeLife.Lib;

namespace WebSafeLife.Models
{
    public class ProfissionalModel : DadosControle
    {
        [Key]
        public Guid Id { get; set; }
        public Guid IdUsuario { get; set; }
        public string Registro { get; set; }
        public Guid IdPessoa { get; set; }
        public string Descricao { get; set; }
        public string Especialidade { get; set; }
    }
}
