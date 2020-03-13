using SafeLifeLib.Models;
using System;
using System.Linq;

namespace BD.Repositorios
{
    internal class DiaaDiaRepositorio : IDiaaDiaRepository
    {
        public DiaaDiaModel Consultar(Guid idPaciente)
        {
            using (var db = new MainContextFactory().CreateDbContext(null))
            {
                return db.DiaaDia.Where(x => x.IdPaciente == idPaciente).FirstOrDefault();
            }
        }

        public Guid Salvar(DiaaDiaModel diaaDia)
        {
            using (var db = new MainContextFactory().CreateDbContext(null))
            {
                db.DiaaDia.Add(diaaDia);
                db.SaveChanges();
                return diaaDia.Id;
            }
        }
    }
}
