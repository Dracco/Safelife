using SafeLifeLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BD
{
    public class ProntuarioRepositorio : IProntuarioRepositorio
    {
        public List<ProntuarioModel> Consultar(Guid idPaciente)
        {
            using (var db = new MainContextFactory().CreateDbContext(null))
            {
                return db.Prontuarios.Where(x => x.IdPaciente == idPaciente).ToList();
            }
        }
        public Guid Salvar(ProntuarioModel prontuario)
        {
            using (var db = new MainContextFactory().CreateDbContext(null))
            {
                db.Prontuarios.Add(prontuario);
                db.SaveChanges();
                return prontuario.Id;
            }
        }
    }
}
