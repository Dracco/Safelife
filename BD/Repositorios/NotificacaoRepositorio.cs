using SafeLifeLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BD
{
    public class NotificacaoRepositorio : INotificacaoRepositorio
    {
        public List<NotificacaoModel> Consultar(Guid idUsuario)
        {
            using (var db = new MainContextFactory().CreateDbContext(null))
            {
                return db.Notificacoes.Where(x => x.IdUsuario == idUsuario).ToList();
            }
        }

        public Guid Salvar(NotificacaoModel local)
        {
            using (var db = new MainContextFactory().CreateDbContext(null))
            {
                db.Notificacoes.Add(local);
                db.SaveChanges();
                return local.Id;
            }
        }
    }
}
