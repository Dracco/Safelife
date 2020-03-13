using SafeLifeLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BD
{
    public class LocalRepositorio : ILocalRepositorio
    {
        public List<LocalModel> Consultar()
        {
            using (var db = new MainContextFactory().CreateDbContext(null))
            {
                return db.Locais.ToList();
            }
        }
        public Guid Salvar(LocalModel local)
        {
            using (var db = new MainContextFactory().CreateDbContext(null))
            {
                db.Locais.Add(local);
                db.SaveChanges();
                return local.Id;
            }
        }
    }
}
