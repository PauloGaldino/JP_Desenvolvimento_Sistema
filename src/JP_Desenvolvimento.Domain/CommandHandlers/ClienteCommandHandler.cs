﻿using JP_Desenvolvimento.Domain.Commands.Cadastro.Pessoas.Clientes;
using JP_Desenvolvimento.Domain.Core.Bus;
using JP_Desenvolvimento.Domain.Core.Notifications;
using JP_Desenvolvimento.Domain.Envents;
using JP_Desenvolvimento.Domain.Interfaces;
using JP_Desenvolvimento.Domain.Interfaces.RepositoriesCadastro.Pessoas.Clientes;
using JP_Desevolvimento.Domain.Models;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace JP_Desenvolvimento.Domain.CommandHandlers
{
    public class ClienteCommandHandler : CommandHandler,
        IRequestHandler<RegisterNewClienteCommand, bool>,
        IRequestHandler<UpdateClienteCommand, bool>,
        IRequestHandler<RemoveClienteCommand, bool>
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IMediatorHandler Bus;

        public ClienteCommandHandler(IClienteRepository clienteRepository,
                                      IUnitOfWork uow,
                                      IMediatorHandler bus,
                                      INotificationHandler<DomainNotification> notifications) : base(uow, bus, notifications)
        {
            _clienteRepository = clienteRepository;
            Bus = bus;
        }

        public Task<bool> Handle(RegisterNewClienteCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid())
            {
                NotifyValidationErrors(message);
                return Task.FromResult(false);
            }

            var cliente = new Cliente(Guid.NewGuid(), message.Nome, message.Email, message.DataCadastro);

            if (_clienteRepository.GetByEmail(cliente.Email) != null)
            {
                Bus.RaiseEvent(new DomainNotification(message.MessageType, "O e-mail do cliente já foi enviado."));
                return Task.FromResult(false);
            }

            _clienteRepository.Add(cliente);

            if (Commit())
            {
                Bus.RaiseEvent(new ClienteRegisteredEvent(cliente.Id, cliente.Nome, cliente.Email, cliente.DataCadastro));
            }

            return Task.FromResult(true);
        }

        public Task<bool> Handle(UpdateClienteCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid())
            {
                NotifyValidationErrors(message);
                return Task.FromResult(false);
            }

            var cliente = new Cliente(message.Id, message.Nome, message.Email, message.DataCadastro);
            var existingCliente = _clienteRepository.GetByEmail(cliente.Email);

            if (existingCliente != null && existingCliente.Id != cliente.Id)
            {
                if (!existingCliente.Equals(cliente))
                {
                    Bus.RaiseEvent(new DomainNotification(message.MessageType, "O e-mail do cliente já foi enviado."));
                    return Task.FromResult(false);
                }
            }

            _clienteRepository.Update(cliente);

            if (Commit())
            {
                Bus.RaiseEvent(new ClienteUpdatedEvent(cliente.Id, cliente.Nome, cliente.Email, cliente.BirthDate));
            }

            return Task.FromResult(true);
        }

        public Task<bool> Handle(RemoveClienteCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid())
            {
                NotifyValidationErrors(message);
                return Task.FromResult(false);
            }

            _clienteRepository.Remove(message.Id);

            if (Commit())
            {
                Bus.RaiseEvent(new ClienteRemovedEvent(message.Id));
            }

            return Task.FromResult(true);
        }

        public void Dispose()
        {
            _clienteRepository.Dispose();
        }
    }
}