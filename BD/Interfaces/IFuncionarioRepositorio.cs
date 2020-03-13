using SafeLifeLib.Models;
using System;

namespace BD
{
    public interface IFuncionarioRepositorio
    {
        Guid Salvar(FuncionarioModel funcionario);

        FuncionarioModel Consultar(Guid idUsuario);
    }
}
