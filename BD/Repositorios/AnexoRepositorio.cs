using SafeLifeLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BD.Repositorios
{
    internal class AnexoRepositorio : IAnexoRepositorio
    {
        public List<AnexoModel> Consultar(Guid idUsuario)
        {
            using (var db = new MainContextFactory().CreateDbContext(null))
            {
                return db.Anexos.Where(x => x.IdUsuario == idUsuario).ToList();
            }
        }

        public Guid Salvar(AnexoModel anexo)
        {
            using (var db = new MainContextFactory().CreateDbContext(null))
            {
                db.Anexos.Add(anexo);
                db.SaveChanges();
                return anexo.Id;
            }
        }
    }
}
