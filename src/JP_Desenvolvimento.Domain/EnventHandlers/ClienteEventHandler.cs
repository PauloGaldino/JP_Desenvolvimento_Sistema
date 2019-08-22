using JP_Desenvolvimento.Domain.Envents;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace JP_Desenvolvimento.Domain.EnventHandlers
{
    public class ClienteEventHandler :
        INotificationHandler<ClienteRegisteredEvent>,
        INotificationHandler<ClienteUpdatedEvent>,
        INotificationHandler<ClienteRemovedEvent>
    {
        public Task Handle(ClienteUpdatedEvent message, CancellationToken cancellationToken)
        {
            // Send some notification e-mail

            return Task.CompletedTask;
        }

        public Task Handle(ClienteRegisteredEvent message, CancellationToken cancellationToken)
        {
            // Send some greetings e-mail

            return Task.CompletedTask;
        }

        public Task Handle(ClienteRemovedEvent message, CancellationToken cancellationToken)
        {
            // Send some see you soon e-mail

            return Task.CompletedTask;
        }
    }
}