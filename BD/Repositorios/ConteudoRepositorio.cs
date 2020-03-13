using SafeLifeLib.Models;
using System;
using System.Collections.Generic;

namespace BD.Repositorios
{
    internal class ConteudoRepositorio : IConteudoRepositorio
    {
        public List<ConteudoModel> Buscar()
        {
            throw new NotImplementedException();
        }

        public Guid Salvar(ConteudoModel conteudo)
        {
            using (var db = new MainContextFactory().CreateDbContext(null))
            {
                db.Conteudos.Add(conteudo);
                db.SaveChanges();
                return conteudo.Id;
            }
        }
    }
}
