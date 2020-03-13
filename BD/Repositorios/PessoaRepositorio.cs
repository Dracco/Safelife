using SafeLifeLib.Models;
using System;
using System.Linq;

namespace BD
{
    public class PessoaRepositorio : IPessoaRepositorio
    {
        public Guid Salvar(PessoaModel pessoa)
        {
            using (var db = new MainContextFactory().CreateDbContext(null))
            {
                db.Pessoas.Add(pessoa);
                db.SaveChanges();
                return pessoa.Id;
            }

        }

        public PessoaModel Consultar(Guid id)
        {
            using (var db = new MainContextFactory().CreateDbContext(null))
            {
                return db.Pessoas.Where(x => x.Id == id).FirstOrDefault();
            }
        }
    }
}
