using SafeLifeLib.Models;
using System;

namespace BD
{
    public interface IProfissionalRepositorio
    {
        Guid Salvar(ProfissionalModel profissional);

        ProfissionalModel Consultar(Guid idUsuario);
    }
}
