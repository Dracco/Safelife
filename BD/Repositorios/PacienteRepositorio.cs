using SafeLifeLib.Models;
using System;
using System.Linq;

namespace BD
{
    public class PacienteRepositorio : IPacienteRepositorio
    {
        public Guid Salvar(PacienteModel paciente)
        {
            using (var db = new MainContextFactory().CreateDbContext(null))
            {
                db.Pacientes.Add(paciente);
                db.SaveChanges();
                return paciente.Id;
            }

        }

        public PacienteModel Consultar(Guid idUsuario)
        {
            using (var db = new MainContextFactory().CreateDbContext(null))
            {
                return db.Pacientes.Where(x => x.IdUsuario == idUsuario).FirstOrDefault();
            }
        }
    }
}
