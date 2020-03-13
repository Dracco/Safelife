using SafeLifeLib.Models;
using System;
using System.Collections.Generic;

namespace BD
{
    public interface IPesoRepositorio
    {
        Guid Salvar(PesoModel peso);

        List<PesoModel> Consultar(Guid idPaciente);
    }
}
