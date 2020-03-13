using SafeLifeLib.Models;
using System;
using System.Collections.Generic;

namespace BD
{
    public interface INotificacaoRepositorio
    {
        Guid Salvar(NotificacaoModel notificacao);

        List<NotificacaoModel> Consultar(Guid idUsuario);
    }
}
