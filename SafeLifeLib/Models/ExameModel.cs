using System;
using SafeLifeLib.Enums;

namespace SafeLifeLib.Models
{
    public class ExameModel
    {
        public Guid Id { get; set; }
        public Guid IdAnexo { get; set; }
        public AnexoModel Anexo { get; set; }
        public Guid IdPaciente { get; set; }
        public TipoExame TipoExame { get; set; }
        public DateTime Data { get; set; }
        public string Local { get; set; }
    }
}
