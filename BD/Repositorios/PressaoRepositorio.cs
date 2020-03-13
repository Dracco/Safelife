using SafeLifeLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BD
{
    public class PressaoRepositorio : IPressaoRepositorio
    {
        public Guid Salvar(PressaoModel pressao)
        {
            using (var db = new MainContextFactory().CreateDbContext(null))
            {
                db.Pressoes.Add(pressao);
                db.SaveChanges();
                return pressao.Id;
            }
        }

        public List<PressaoModel> Consultar(Guid idPaciente)
        {
            using (var db = new MainContextFactory().CreateDbContext(null))
            {
                return db.Pressoes.Where(x => x.IdPaciente == idPaciente).ToList();
            }
        }        
    }
}
