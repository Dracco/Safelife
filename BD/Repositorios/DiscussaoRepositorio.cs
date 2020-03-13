using SafeLifeLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BD.Repositorios
{
    internal class DiscussaoRepositorio : IDiscussaoRepositorio
    {
        public List<DiscussaoModel> Consultar(Guid idForum)
        {
            using (var db = new MainContextFactory().CreateDbContext(null))
            {
                return db.Discussoes.Where(x => x.IdForum == idForum).ToList();
            }
        }

        public Guid Salvar(DiscussaoModel discussao)
        {
            using (var db = new MainContextFactory().CreateDbContext(null))
            {
                db.Discussoes.Add(discussao);
                db.SaveChanges();
                return discussao.Id;
            }
        }
    }
}
