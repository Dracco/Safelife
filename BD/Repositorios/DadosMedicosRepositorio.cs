using SafeLifeLib.Models;
using System;
using System.Linq;

namespace BD
{
    public class DadosMedicosRepositorio : IDadosMedicosRepositorio
    {
        public DadosMedicosModel Consultar(Guid id)
        {
            using (var db = new MainContextFactory().CreateDbContext(null))
            {
                return db.DadosMedicos.Where(x => x.Id == id).FirstOrDefault();
            }
        }
        public Guid Salvar(DadosMedicosModel dadosMedicos)
        {
            using (var db = new MainContextFactory().CreateDbContext(null))
            {
                db.DadosMedicos.Add(dadosMedicos);
                db.SaveChanges();
                return dadosMedicos.Id;
            }
        }
    }
}
