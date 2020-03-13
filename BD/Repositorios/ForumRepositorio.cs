using SafeLifeLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BD
{
    public class ForumRepositorio : IForumRepositorio
    {
        public List<ForumModel> Consultar()
        {
            using (var db = new MainContextFactory().CreateDbContext(null))
            {
                return db.Foruns.ToList();
            }
        }
        public Guid Salvar(ForumModel forum)
        {
            using (var db = new MainContextFactory().CreateDbContext(null))
            {
                db.Foruns.Add(forum);
                db.SaveChanges();
                return forum.Id;
            }
        }
    }
}
