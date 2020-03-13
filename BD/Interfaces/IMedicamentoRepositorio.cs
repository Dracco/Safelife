using SafeLifeLib.Models;
using System;
using System.Collections.Generic;

namespace BD
{
    public interface IMedicamentoRepositorio
    {
        Guid Salvar(MedicamentoModel medicamento);

        List<MedicamentoModel> Consultar(Guid idPaciente);
    }
}
