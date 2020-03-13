using SafeLifeLib.Models;
using System;

namespace BD
{
    public interface IDiaaDiaRepository
    {
        Guid Salvar(DiaaDiaModel diaaDia);

        DiaaDiaModel Consultar(Guid idPaciente);
    }
}
