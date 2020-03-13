using SafeLifeLib.Models;
using System;
using System.Collections.Generic;

namespace BD
{
    public interface IConvenioRepositorio
    {
        Guid Salvar(ConvenioModel vacina);

        List<ConvenioModel> Consultar(Guid idPaciente);
    }
}
