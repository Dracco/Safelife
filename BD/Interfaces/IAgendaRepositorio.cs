using SafeLifeLib.Models;
using System;
using System.Collections.Generic;

namespace BD
{
    public interface IAgendaRepositorio
    {
        Guid Salvar(AgendaModel contato);

        List<AgendaModel> Consultar(Guid idUsuario);
    }
}
