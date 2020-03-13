using SafeLifeLib.Models;
using System;
using System.Collections.Generic;

namespace BD
{
    public interface IForumRepositorio
    {
        Guid Salvar(ForumModel forum);

        List<ForumModel> Consultar();
    }
}
