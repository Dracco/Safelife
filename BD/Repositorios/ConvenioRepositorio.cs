using SafeLifeLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BD.Repositorios
{
    internal class ConvenioRepositorio : IConvenioRepositorio
    {
        public List<ConvenioModel> Consultar(Guid idPaciente)
        {
            using (var db = new MainContextFactory().CreateDbContext(null))
            {
                return db.Convenios.Where(x => x.IdPaciente == idPaciente).ToList();
            }
        }

        public Guid Salvar(ConvenioModel convenio)
        {
            using (var db = new MainContextFactory().CreateDbContext(null))
            {
                db.Convenios.Add(convenio);
                db.SaveChanges();
                return convenio.Id;
            }
        }
    }
}
