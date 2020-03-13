using SafeLifeLib.Models;
using System;

namespace BD
{
    public interface IPessoaRepositorio
    {
        Guid Salvar(PessoaModel pessoa);

        PessoaModel Consultar(Guid id);
    }
}
