using SafeLifeLib.Models;
using System;
using System.Collections.Generic;

namespace BD
{
    public interface IComentarioRepositorio
    {
        Guid Salvar(ComentarioModel comentario);

        List<ComentarioModel> Consultar(Guid idProntuario);
    }
}
