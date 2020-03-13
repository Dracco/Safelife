using System;
using System.ComponentModel.DataAnnotations;

using SafeLifeLib.Enums;

namespace SafeLifeLib.Models
{
    public class PessoaModel : DadosControleModel
    {
        [Key]
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Profissao { get; set; }
        public string Cargo { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Foto { get; set; }
        public DateTime DataNascimento { get; set; }
        public Genero Genero { get; set; }
        public EstadoCivil EstadoCivil { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Cep { get; set; }
    }
}
