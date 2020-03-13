using SafeLifeLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BD.Repositorios
{
    internal class ComentarioRepositorio : IComentarioRepositorio
    {
        public List<ComentarioModel> Consultar(Guid idProntuario)
        {
            using (var db = new MainContextFactory().CreateDbContext(null))
            {
                return db.Comentarios.Where(x => x.IdProntuario == idProntuario).ToList();
            }
        }

        public Guid Salvar(ComentarioModel comentario)
        {
            using (var db = new MainContextFactory().CreateDbContext(null))
            {
                db.Comentarios.Add(comentario);
                db.SaveChanges();
                return comentario.Id;
            }
        }
    }
}
