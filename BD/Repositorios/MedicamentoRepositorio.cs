using SafeLifeLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BD
{
    public class MedicamentoRepositorio : IMedicamentoRepositorio
    {
        public Guid Salvar(MedicamentoModel medicamento)
        {
            using (var db = new MainContextFactory().CreateDbContext(null))
            {
                db.Medicamentos.Add(medicamento);
                db.SaveChanges();
                return medicamento.Id;
            }
        }

        public List<MedicamentoModel> Consultar(Guid idPaciente)
        {
            using (var db = new MainContextFactory().CreateDbContext(null))
            {
                return db.Medicamentos.Where(x => x.IdPaciente == idPaciente).ToList();
            }
        }        
    }
}
