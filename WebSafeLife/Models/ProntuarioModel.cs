using System;
using System.ComponentModel.DataAnnotations;
using WebSafeLife.Lib;

namespace WebSafeLife.Models
{
    public class ProntuarioModel : DadosControle
    {
        [Key]
        public Guid Id { get; set; }
        public Guid IdPaciente { get; set; }
        public Guid IdConvenio { get; set; }
        public Guid IdFuncionario { get; set; }
        public string Observacao { get; set; }
        public string Queixa { get; set; }
        public string MedicamentosEmUso { get; set; }
        public DateTime Data { get; set; }
        public string Anamnese { get; set; }
        public string Cid10 { get; set; }
        public string Prescricao { get; set; }
        public string ExamesSolicitados { get; set; }
    }

}
