using SafeLifeLib.Models;
using System;
using System.Collections.Generic;

namespace BD
{
    public interface IAnexoRepositorio
    {
        Guid Salvar(AnexoModel anexo);

        List<AnexoModel> Consultar(Guid idUsuario);
    }
}
