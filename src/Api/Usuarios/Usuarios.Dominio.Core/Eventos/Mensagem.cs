using MediatR;
using System;

namespace Usuarios.Dominio.Core.Eventos
{
    public abstract class Mensagem : IRequest<bool> 
    {
        public string MessageType { get; protected set; }
        public Guid AggregateId { get; protected set; }

        protected Mensagem()
        {
            MessageType = GetType().Name;
        }
    }
}
