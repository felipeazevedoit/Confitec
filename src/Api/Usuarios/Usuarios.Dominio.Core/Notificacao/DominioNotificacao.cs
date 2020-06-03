using System;
using System.Collections.Generic;
using System.Text;
using Usuarios.Dominio.Core.Eventos;

namespace Usuarios.Dominio.Core.Notificacao
{
    public class DominioNotificacao: Evento
    {
        public Guid DomainNotificationId { get; private set; }
        public string Key { get; private set; }
        public string Value { get; private set; }
        public int Version { get; private set; }

        public DominioNotificacao(string key, string value)
        {
            DomainNotificationId = Guid.NewGuid();
            Version = 1;
            Key = key;
            Value = value;
        }
    }
}
