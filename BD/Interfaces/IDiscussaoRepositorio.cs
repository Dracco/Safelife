using SafeLifeLib.Models;
using System;
using System.Collections.Generic;

namespace BD
{
    public interface IDiscussaoRepositorio
    {
        Guid Salvar(DiscussaoModel discussao);

        List<DiscussaoModel> Consultar(Guid idForum);
    }
}
