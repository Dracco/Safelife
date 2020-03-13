using System;
using SafeLife.Lib;

namespace SafeLife.Models
{
    public class ConteudoModel:DadosControle
    {
        public Guid Id
        { get; set; }

        public string Titulo
        { get; set; }

        public string Resumo
        { get; set; }
        public string Imagem
        { get; set; }
        public string Html
        { get; set; }
        public bool Destaque { get; set; }
       
    }
}
