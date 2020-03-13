using SafeLifeLib.Models;
using System;
using System.Collections.Generic;

namespace BD
{
    public interface IVacinaRepositorio
    {
        Guid Salvar(VacinaModel vacina);

        List<VacinaModel> Consultar(Guid idPaciente);
    }
}
