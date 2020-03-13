using System;
using SafeLife.Lib;
using SafeLife.Enums;

namespace SafeLife.Models
{
    public class AnexoModel : DadosControle
    {
        public Guid Id { get; set; }
        public Guid IdUsuario { get; set; }
        public string NomeArquivo { get; set; }
        public string Anexo { get; set; }
        public TipoAnexo TipoAnexo { get; set; }
        public string Descricao { get; set; }
    }
}
