using System;
using System.Collections.Generic;

namespace WebSafeLife.Lib
{
    public class Mock
    {
        public List<WebSafeLife.ViewModels.CadastroViewModel> Cadastros { get; set; }

        public Mock()
        {
            Cadastros = new List<ViewModels.CadastroViewModel>();
            Cadastros.Add(new WebSafeLife.ViewModels.CadastroViewModel()
            {
                Pessoa = new SafeLifeLib.Models.PessoaModel()
                {
                    Ativo = true,
                    Bairro = "Camargos",
                    Cargo = "Analista de Sistemas",
                    Celular = "(31) 9 9199-9999",
                    Cep = "30.490-110",
                    Cidade = "Belo Horizonte",
                    Complemento = "Ap 001",
                    Cpf = "012.345.678-90",
                    DataNascimento = DateTime.Parse("12/05/2000"),
                    Email = "Email@dominio.com.br",
                    Endereco = "Rua dos olimpios",
                    EstadoCivil = SafeLifeLib.Enums.EstadoCivil.Casado,
                    Genero = SafeLifeLib.Enums.Genero.Feminino,
                    Id = Guid.NewGuid(),
                    Nome = "Joselino da Silva Rocha",
                    Numero = 12,
                    Profissao = "Pedreiro",
                    Telefone = "(32) 3221-0987",
                    Uf = "MG",
                }
            });
        }
    }
}
