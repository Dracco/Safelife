using SafeLifeLib.Models;
using System;
using System.Linq;

namespace BD
{
    public class FuncionarioRepositorio : IFuncionarioRepositorio
    {
        public Guid Salvar(FuncionarioModel funcionario)
        {
            using (var db = new MainContextFactory().CreateDbContext(null))
            {
                db.Funcionarios.Add(funcionario);
                db.SaveChanges();
                return funcionario.Id;
            }

        }

        public FuncionarioModel Consultar(Guid idUsuario)
        {
            using (var db = new MainContextFactory().CreateDbContext(null))
            {
                return db.Funcionarios.Where(x => x.IdUsuario == idUsuario).FirstOrDefault();
            }
        }
    }
}
