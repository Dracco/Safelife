using System;


namespace SafeLifeLib.Models
{
    public class ContatoModel : DadosControleModel
    {
        public Guid Id { get; set; }
        public Guid IdPaciente { get; set; }
        public string Nome { get; set; }
        public string Celular { get; set; }
        public string Fixo { get; set; }
        public string Email { get; set; }
        public string Relacionamento { get; set; }

    }
}
