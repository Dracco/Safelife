using SafeLifeLib.Models;
using System;
using System.Collections.Generic;

namespace BD
{
    public interface IReceitaRepositorio
    {
        Guid Salvar(ReceitaModel receita);

        List<ReceitaModel> Consultar(Guid idProntuario);
    }
}
