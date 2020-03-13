using SafeLifeLib.Models;
using System;
using System.Collections.Generic;

namespace BD
{
    public interface IExameRepositorio
    {
        Guid Salvar(ExameModel exame);

        List<ExameModel> Consultar(Guid idPaciente, Guid idAnexo);
    }
}
