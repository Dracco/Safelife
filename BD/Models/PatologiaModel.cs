using System;
using System.ComponentModel.DataAnnotations;

namespace BD.Models
{
    public class PatologiaModel : DadosControleModel
    {
        [Key]
        public Guid Id { get; set; }
        public Guid IdPaciente { get; set; }
        public bool Presbiopia { get; set; }
        public bool Miopia { get; set; }
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
