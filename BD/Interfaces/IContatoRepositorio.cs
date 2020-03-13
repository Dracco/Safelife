using SafeLifeLib.Models;
using System;
using System.Collections.Generic;

namespace BD
{
    public interface IContatoRepositorio
    {
        Guid Salvar(ContatoModel contato);

        List<ContatoModel> Consultar(Guid idPaciente);
    }
}
