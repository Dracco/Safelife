 using System;

namespace SafeLifeLib.Models
{
    public class AgendaModel
    {
        public Guid Id
        { get; set; }
        public Guid IdUsuario
        { get; set; }

        public string Evento
        { get; set; }
        public string Descricao
        { get; set; }
        public string Local
        { get; set; }

        public DateTime Data
        { get; set; }
        public DateTime Hora
        { get; set; }
    }
}
