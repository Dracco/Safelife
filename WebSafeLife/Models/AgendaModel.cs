using System;
using SafeLife.Lib;

namespace SafeLife.Models
{
    public class AgendaModel : DadosControle
    {
        public Guid Id
        { get; set; }
        public Guid IdUsuario
        { get; set; }
        public string Evento
        { get; set; }
        public DateTime Data
        { get; set; }
        public DateTime Hora
        { get; set; }
        public string Local
        { get; set; }
        public string Descricao
        { get; set; }


        
    }
}
