using SafeLifeLib.Models;
using System;
using System.Collections.Generic;

namespace BD
{
    public interface ICirurgiaRepositorio
    {
        Guid Salvar(CirurgiaModel Cirurgia);

        List<CirurgiaModel> Consultar(Guid idPaciente);
    }
}
