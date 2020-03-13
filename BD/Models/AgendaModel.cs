using System;

namespace BD.Models
{
    public class AgendaModel : DadosControleModel
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
