using System;
using System.ComponentModel.DataAnnotations;
using SafeLife.Lib;

namespace SafeLife.Models
{
    public class PatologiaModel : DadosControle
    {
        [Key]
        public Guid Id { get; set; }
        public Guid IdPaciente { get; set; }
        public bool Presbiopia { get; set; }
        public bool Miopia{ get; set; }
        public bool Hipermetropia { get; set; }
        public bool Astigmatismo { get; set; }
        public bool Diabetes { get; set; }
        public bool Cancer { get; set; }
        public bool Hipertensao { get; set; }
        public bool Hiv { get; set; }
        public bool Lupus { get; set; }
        public bool Alzheimer { get; set; }
        public bool Parkinson { get; set; }
        public string Outros { get; set; }

    }
}
