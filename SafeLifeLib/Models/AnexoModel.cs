using System;

using SafeLifeLib.Enums;

namespace SafeLifeLib.Models
{
    public class AnexoModel : DadosControleModel
    {
        public Guid Id { get; set; }
        public Guid IdUsuario { get; set; }
        public string NomeArquivo { get; set; }
        public string Anexo { get; set; }
        public TipoAnexo TipoAnexo { get; set; }
        public string Descricao { get; set; }
    }
}
