using System;
using System.ComponentModel.DataAnnotations;
using SafeLife.Lib;

namespace SafeLife.Models
{
    public class MedicamentoModel : DadosControle
    {
        [Key]
        public Guid Id { get; set; }
        public Guid IdPaciente { get; set; }
        public string Nome { get; set; }
        public string Dosagem { get; set; }
        //public string MedicamentosEmUso { get; set; }
        public string Laboratorio { get; set; }
        public DateTime Hora { get; set; }
        public int Intervalo { get; set; }
        public string Motivo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
    }

}
