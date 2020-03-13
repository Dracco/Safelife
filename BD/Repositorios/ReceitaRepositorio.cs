using SafeLifeLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BD
{
    public class ReceitaRepositorio : IReceitaRepositorio
    {
        public List<ReceitaModel> Consultar(Guid idProntuario)
        {
            using (var db = new MainContextFactory().CreateDbContext(null))
            {
                return db.Receitas.Where(x => x.IdProntuario == idProntuario).ToList();
            }
        }
        public Guid Salvar(ReceitaModel receita)
        {
            using (var db = new MainContextFactory().CreateDbContext(null))
            {
                db.Receitas.Add(receita);
                db.SaveChanges();
                return receita.Id;
            }
        }
    }
}
