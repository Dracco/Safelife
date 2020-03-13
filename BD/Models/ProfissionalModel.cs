using System;
using System.ComponentModel.DataAnnotations;

namespace BD.Models
{
    public class ProfissionalModel : DadosControleModel
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
