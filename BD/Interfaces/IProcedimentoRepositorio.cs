using SafeLifeLib.Models;
using System;
using System.Collections.Generic;

namespace BD
{
    public interface IProcedimentoRepositorio
    {
        Guid Salvar(ProcedimentoModel procedimento);

        List<ProcedimentoModel> Consultar(Guid idPaciente);
    }
}
