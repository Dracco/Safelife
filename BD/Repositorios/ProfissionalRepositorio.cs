using SafeLifeLib.Models;
using System;
using System.Linq;

namespace BD
{
    public class ProfissionalRepositorio : IProfissionalRepositorio
    {
        public Guid Salvar(ProfissionalModel profissional)
        {
            using (var db = new MainContextFactory().CreateDbContext(null))
            {
                db.Profissionais.Add(profissional);
                db.SaveChanges();
                return profissional.Id;
            }

        }

        public ProfissionalModel Consultar(Guid idUsuario)
        {
            using (var db = new MainContextFactory().CreateDbContext(null))
            {
                return db.Profissionais.Where(x => x.IdUsuario == idUsuario).FirstOrDefault();
            }
        }
    }
}
