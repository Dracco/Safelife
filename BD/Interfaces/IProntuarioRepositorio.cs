using SafeLifeLib.Models;
using System;
using System.Collections.Generic;

namespace BD
{
    public interface IProntuarioRepositorio
    {
        Guid Salvar(ProntuarioModel prontuario);

        List<ProntuarioModel> Consultar(Guid idPaciente);
    }
}
