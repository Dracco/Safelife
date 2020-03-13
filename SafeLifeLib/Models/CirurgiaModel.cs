using System;


namespace SafeLifeLib.Models
{
    public class CirurgiaModel : DadosControleModel
    {
        public Guid Id { get; set; }
        public Guid IdPaciente { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
        public string Local { get; set; }
    }
}
