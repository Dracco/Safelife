using BD.Enums;
using System;

namespace BD.Models
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
