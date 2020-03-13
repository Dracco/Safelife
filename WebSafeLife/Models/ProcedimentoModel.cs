using System;
using System.ComponentModel.DataAnnotations;
using WebSafeLife.Lib;

namespace WebSafeLife.Models
{
    public class ProcedimentoModel:DadosControle
    {
        [Key]
        public Guid Id
        { get; set; }
        public Guid IdPaciente
        { get; set; }
        public bool StandCardiac { get; set; }
        public bool Safena { get; set; }
        public bool ProteseDentaria { get; set; }
        public bool ImplanteDentario { get; set; }
        public bool MarcaPasso { get; set; }
        public bool AparelhoAuricular { get; set; }
        public string Outros { get; set; }

    }
}
