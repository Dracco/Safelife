 using System;

namespace SafeLife.Models
{
    public class Agenda
    {
        public int Id
        { get; set; }
        public int IdUsuario
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
