using SafeLifeLib.Models;
using System;

namespace BD
{
    public interface IPacienteRepositorio
    {
        Guid Salvar(PacienteModel paciente);

        PacienteModel Consultar(Guid idUsuario);
    }
}
