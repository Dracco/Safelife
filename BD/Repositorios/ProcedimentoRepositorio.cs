using SafeLifeLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BD
{
    public class ProcedimentoRepositorio : IProcedimentoRepositorio
    {
        public Guid Salvar(ProcedimentoModel procedimento)
        {
            using (var db = new MainContextFactory().CreateDbContext(null))
            {
                db.Procedimentos.Add(procedimento);
                db.SaveChanges();
                return procedimento.Id;
            }
        }

        public List<ProcedimentoModel> Consultar(Guid idPaciente)
        {
            using (var db = new MainContextFactory().CreateDbContext(null))
            {
                return db.Procedimentos.Where(x => x.IdPaciente == idPaciente).ToList();
            }
        }        
    }
}
