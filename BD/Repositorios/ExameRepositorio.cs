using SafeLifeLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BD
{
    public class ExameRepositorio : IExameRepositorio
    {
        public Guid Salvar(ExameModel exame)
        {
            using (var db = new MainContextFactory().CreateDbContext(null))
            {
                db.Exames.Add(exame);
                db.SaveChanges();
                return exame.Id;
            }
        }
        

        public List<ExameModel> Consultar(Guid idPaciente, Guid idAnexo)
        {
            using (var db = new MainContextFactory().CreateDbContext(null))
            {
                return db.Exames.Where(x => x.IdPaciente == idPaciente && x.IdAnexo == idAnexo).ToList();
            }
        }
    }
}
