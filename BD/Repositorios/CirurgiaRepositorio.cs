using SafeLifeLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BD.Repositorios
{
    internal class CirurgiaRepositorio : ICirurgiaRepositorio
    {
        public List<CirurgiaModel> Consultar(Guid idPaciente)
        {
            using (var db = new MainContextFactory().CreateDbContext(null))
            {
                return db.Cirurgias.Where(x => x.IdPaciente == idPaciente).ToList();
            }
        }

        public Guid Salvar(CirurgiaModel cirurgia)
        {
            using (var db = new MainContextFactory().CreateDbContext(null))
            {
                db.Cirurgias.Add(cirurgia);
                db.SaveChanges();
                return cirurgia.Id;
            }
        }
    }
}
