using SafeLifeLib.Models;
using System;
using System.Collections.Generic;

namespace BD
{
    public interface ILocalRepositorio
    {
        Guid Salvar(LocalModel local);

        List<LocalModel> Consultar();
    }
}
