using SafeLifeLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BD.Repositorios
{
    internal class ContatoRepositorio : IContatoRepositorio
    {
        public List<ContatoModel> Consultar(Guid idPaciente)
        {
            using (var db = new MainContextFactory().CreateDbContext(null))
            {
                return db.Contatos.Where(x => x.IdPaciente == idPaciente).ToList();
            }
        }

        public Guid Salvar(ContatoModel contato)
        {
            using (var db = new MainContextFactory().CreateDbContext(null))
            {
                db.Contatos.Add(contato);
                db.SaveChanges();
                return contato.Id;
            }
        }
    }
}
