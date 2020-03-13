using SafeLifeLib.Models;
using System;
using System.Collections.Generic;

namespace BD
{
    public interface IPressaoRepositorio
    {
        Guid Salvar(PressaoModel pressao);

        List<PressaoModel> Consultar(Guid idPaciente);
    }
}
