using SafeLifeLib.Models;
using System;
using System.Linq;

namespace BD
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        public Guid Salvar(UsuarioModel usuario)
        {
            using (var db = new MainContextFactory().CreateDbContext(null))
            {
                db.Usuarios.Add(usuario);
                db.SaveChanges();
                return usuario.Id;
            }

        }
        
        public UsuarioModel Consultar(Guid id)
        {
            using (var db = new MainContextFactory().CreateDbContext(null))
            {
                return db.Usuarios.Where(x => x.Id == id).FirstOrDefault();
            }
        }
    }
}
