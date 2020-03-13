using SafeLifeLib.Models;
using System;

namespace BD
{
    public interface IDadosMedicosRepositorio
    {
        Guid Salvar(DadosMedicosModel dadosMedicos);

        DadosMedicosModel Consultar(Guid idPaciente);
    }
}
