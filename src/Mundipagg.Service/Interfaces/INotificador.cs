using Mundipagg.Aplication.Notificacoes;
using System.Collections.Generic;

namespace Mundipagg.Aplication.Interfaces
{
    public interface INotificador
    {
        bool TemNotificacao();
        List<Notificacao> ObterNotificacoes();
        void Handle(Notificacao notificacao);
    }
}
