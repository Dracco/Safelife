using SafeLifeLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BD
{
    public class PesoRepositorio : IPesoRepositorio
    {
        public Guid Salvar(PesoModel peso)
        {
            using (var db = new MainContextFactory().CreateDbContext(null))
            {
                db.Pesos.Add(peso);
                db.SaveChanges();
                return peso.Id;
            }
        }

        public List<PesoModel> Consultar(Guid idPaciente)
        {
            using (var db = new MainContextFactory().CreateDbContext(null))
            {
                return db.Pesos.Where(x => x.IdPaciente == idPaciente).ToList();
            }
        }        
    }
}
