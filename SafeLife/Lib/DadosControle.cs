using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SafeLife.Lib
{
    public class DadosControle
    {
        public bool Ativo { get; set; }
        public string UsuarioInclusao { get; set; }
        public DateTime DataInclusao { get; set; }
        public string UsuarioAlteracao { get; set; }
        public DateTime DataAlteracao { get; set; }
        public string UsuarioExclusao { get; set; }
        public DateTime DataExclusao { get; set; }
    }
}
