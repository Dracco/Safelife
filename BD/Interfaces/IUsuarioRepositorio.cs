using SafeLifeLib.Models;
using System;

namespace BD
{
    public interface IUsuarioRepositorio
    {
        Guid Salvar(UsuarioModel usuario);

        UsuarioModel Consultar(Guid id);
    }
}
