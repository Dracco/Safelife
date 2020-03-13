using System;
using System.ComponentModel.DataAnnotations;

namespace BD.Models
{
    public class PacienteModel : DadosControleModel
    {
        [Key]
        public Guid Id { get; set; }
        public Guid IdUsuario { get; set; }
        public Guid IdPessoa { get; set; }
    }
}
