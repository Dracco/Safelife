using SafeLifeLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BD
{
    public class PatologiaRepositorio : IPatologiaRepositorio
    {
        public Guid Salvar(PatologiaModel patologia)
        {
            using (var db = new MainContextFactory().CreateDbContext(null))
            {
                db.Patologias.Add(patologia);
                db.SaveChanges();
                return patologia.Id;
            }
        }

        public List<PatologiaModel> Consultar(Guid idPaciente)
        {
            using (var db = new MainContextFactory().CreateDbContext(null))
            {
                return db.Patologias.Where(x => x.IdPaciente == idPaciente).ToList();
            }
        }        
    }
}
