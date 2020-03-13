using SafeLifeLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BD
{
    public class AgendaRepositorio : IAgendaRepositorio
    {
        public Guid Salvar(AgendaModel agenda)
        {
            using (var db = new MainContextFactory().CreateDbContext(null))
            {
                db.Agendas.Add(agenda);
                db.SaveChanges();
                return agenda.Id;
            }
        }


        List<AgendaModel> IAgendaRepositorio.Consultar(Guid idUsuario)
        {
            using (var db = new MainContextFactory().CreateDbContext(null))
            {
                return db.Agendas.Where(x => x.IdUsuario == idUsuario).ToList();
            }
        }
    }
}
