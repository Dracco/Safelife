using SafeLifeLib.Models;
using System;
using System.Collections.Generic;

namespace BD
{
    public interface IConteudoRepositorio
    {
        Guid Salvar(ConteudoModel contato);

        List<ConteudoModel> Buscar();
    }
}
