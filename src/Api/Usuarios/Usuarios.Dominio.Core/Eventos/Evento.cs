using MediatR;
using System;

namespace Usuarios.Dominio.Core.Eventos
{
    public abstract class Evento : Mensagem, INotification
    {
        public DateTime Timestamp { get; private set; }
        public Evento()
        {
            Timestamp = DateTime.Now;
        }
    }
}
