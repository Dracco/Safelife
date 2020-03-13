using SafeLifeLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BD
{
    public class VacinaRepositorio : IVacinaRepositorio
    {
        public Guid Salvar(VacinaModel vacina)
        {
            using (var db = new MainContextFactory().CreateDbContext(null))
            {
                db.Vacinas.Add(vacina);
                db.SaveChanges();
                return vacina.Id;
            }
        }

        public List<VacinaModel> Consultar(Guid idPaciente)
        {
            using (var db = new MainContextFactory().CreateDbContext(null))
            {
                return db.Vacinas.Where(x => x.IdPaciente == idPaciente).ToList();
            }
        }        
    }
}
