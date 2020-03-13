using SafeLifeLib.Models;
using System;
using System.Collections.Generic;

namespace BD
{
    public interface IPatologiaRepositorio
    {
        Guid Salvar(PatologiaModel patologia);

        List<PatologiaModel> Consultar(Guid idPaciente);
    }
}
